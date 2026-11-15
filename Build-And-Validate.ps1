#!/usr/bin/env pwsh
# Script de Compilação e Validação - Digital Inclusion App
# Compatível com PowerShell 5.0+

param(
	[switch]$Clean,
	[switch]$Rebuild,
	[switch]$Test,
	[switch]$Verbose
)

# Cores
$Success = 'Green'
$Error = 'Red'
$Warning = 'Yellow'
$Info = 'Cyan'

# Função: Imprimir mensagem com cor
function Write-ColorOutput {
	param(
		[string]$Message,
		[string]$Color = 'White'
	)
	Write-Host $Message -ForegroundColor $Color
}

# Função: Imprimir header
function Show-Header {
	Clear-Host
	Write-ColorOutput "╔════════════════════════════════════════════════════════════════════╗" $Info
	Write-ColorOutput "║  Digital Inclusion App - Build & Validation Script                ║" $Info
	Write-ColorOutput "║  Versão 1.0 - Pós Refatoração WindowsForms Profissional            ║" $Info
	Write-ColorOutput "╚════════════════════════════════════════════════════════════════════╝" $Info
	Write-Host ""
}

# Função: Verificar dependências
function Check-Prerequisites {
	Write-ColorOutput "→ Verificando pré-requisitos..." $Info

	# Verificar .NET SDK
	$dotnetVersion = dotnet --version 2>$null
	if (-not $dotnetVersion) {
		Write-ColorOutput "  ✗ .NET SDK não encontrado!" $Error
		exit 1
	}
	Write-ColorOutput "  ✓ .NET SDK $dotnetVersion encontrado" $Success

	# Verificar se estamos no diretório correto
	if (-not (Test-Path "DigitalInclusionApp\DigitalInclusionApp\DigitalInclusionApp.csproj")) {
		Write-ColorOutput "  ✗ Arquivo .csproj não encontrado!" $Error
		Write-ColorOutput "    Execute este script do diretório raiz do repositório." $Warning
		exit 1
	}
	Write-ColorOutput "  ✓ Estrutura do projeto validada" $Success
	Write-Host ""
}

# Função: Limpar build anterior
function Clean-Build {
	Write-ColorOutput "→ Limpando build anterior..." $Info
	Push-Location "DigitalInclusionApp\DigitalInclusionApp"
	dotnet clean -q 2>$null | Out-Null
	Pop-Location
	Write-ColorOutput "  ✓ Build anterior removido" $Success
	Write-Host ""
}

# Função: Restaurar pacotes NuGet
function Restore-NuGet {
	Write-ColorOutput "→ Restaurando pacotes NuGet..." $Info
	Push-Location "DigitalInclusionApp\DigitalInclusionApp"
	dotnet restore -q 2>&1 | Out-Null
	Pop-Location
	Write-ColorOutput "  ✓ Pacotes restaurados" $Success
	Write-Host ""
}

# Função: Compilar projeto
function Build-Project {
	Write-ColorOutput "→ Compilando projeto..." $Info
	Push-Location "DigitalInclusionApp\DigitalInclusionApp"

	$buildOutput = dotnet build
	$exitCode = $LASTEXITCODE

	Pop-Location

	if ($exitCode -eq 0) {
		Write-ColorOutput "  ✓ Compilação bem-sucedida!" $Success
		return $true
	} else {
		Write-ColorOutput "  ✗ Erro na compilação!" $Error
		if ($Verbose) {
			Write-Host $buildOutput
		}
		return $false
	}
	Write-Host ""
}

# Função: Validar refatoração
function Validate-Refactoring {
	Write-ColorOutput "→ Validando refatoração..." $Info

	$errors = @()
	$warnings = @()

	# Contar Forms que herdam de BaseForm
	$baseFormCount = (Get-ChildItem -Path "DigitalInclusionApp\DigitalInclusionApp" -Filter "*.cs" -Recurse | 
		Select-String "public partial class.*: BaseForm" | Measure-Object).Count

	if ($baseFormCount -eq 20) {
		Write-ColorOutput "  ✓ Todos os 20 Forms herdam de BaseForm" $Success
	} else {
		Write-ColorOutput "  ✗ Apenas $baseFormCount/20 Forms herdam de BaseForm" $Warning
		$warnings += "Forms não completamente migrados para BaseForm"
	}

	# Verificar FormNavigator imports
	$navigatorCount = (Get-ChildItem -Path "DigitalInclusionApp\DigitalInclusionApp" -Filter "*.cs" -Recurse | 
		Select-String "using DigitalInclusionApp.Infrastructure" | Measure-Object).Count

	if ($navigatorCount -ge 20) {
		Write-ColorOutput "  ✓ Imports de Infrastructure presentes" $Success
	} else {
		Write-ColorOutput "  ⚠ Apenas $navigatorCount imports de Infrastructure encontrados" $Warning
		$warnings += "Alguns Forms podem estar faltando imports"
	}

	# Verificar se não há código antigo de Thread
	$threadCount = (Get-ChildItem -Path "DigitalInclusionApp\DigitalInclusionApp" -Filter "*.cs" -Recurse | 
		Select-String "Thread\? t1" | Measure-Object).Count

	if ($threadCount -eq 0) {
		Write-ColorOutput "  ✓ Nenhum código antigo de Thread encontrado" $Success
	} else {
		Write-ColorOutput "  ✗ Ainda existem $threadCount referências a 'Thread t1'" $Error
		$errors += "Código antigo de Thread ainda presente"
	}

	Write-Host ""

	if ($errors.Count -gt 0) {
		Write-ColorOutput "❌ Erros encontrados:" $Error
		foreach ($error in $errors) {
			Write-ColorOutput "   • $error" $Error
		}
		Write-Host ""
		return $false
	}

	if ($warnings.Count -gt 0) {
		Write-ColorOutput "⚠️  Avisos:" $Warning
		foreach ($warning in $warnings) {
			Write-ColorOutput "   • $warning" $Warning
		}
		Write-Host ""
	}

	return $true
}

# Função: Mostrar resumo
function Show-Summary {
	param(
		[bool]$Success,
		[int]$BuildTime
	)

	Write-Host ""
	Write-ColorOutput "╔════════════════════════════════════════════════════════════════════╗" $Info

	if ($Success) {
		Write-ColorOutput "║  ✅ BUILD E VALIDAÇÃO CONCLUÍDOS COM SUCESSO!                      ║" $Success
		Write-ColorOutput "║                                                                    ║" $Info
		Write-ColorOutput "║  Próximos passos:                                                 ║" $Info
		Write-ColorOutput "║  1. Pressione F5 no Visual Studio para iniciar a aplicação        ║" $Info
		Write-ColorOutput "║  2. Teste a navegação entre todos os formulários                  ║" $Info
		Write-ColorOutput "║  3. Verifique se a centralização de controles funciona            ║" $Info
		Write-ColorOutput "║  4. Veja PLANO_TESTES_POS_REFATORACAO.md para testes detalhados   ║" $Info
	} else {
		Write-ColorOutput "║  ❌ BUILD FALHOU!                                                  ║" $Error
		Write-ColorOutput "║                                                                    ║" $Info
		Write-ColorOutput "║  Verifique os erros acima e corrija o código.                     ║" $Info
	}

	Write-ColorOutput "║                                                                    ║" $Info
	Write-ColorOutput "║  Tempo total: ${BuildTime}s                                           ║" $Info
	Write-ColorOutput "╚════════════════════════════════════════════════════════════════════╝" $Info
}

# Main
try {
	Show-Header

	$startTime = Get-Date

	Check-Prerequisites

	if ($Clean) {
		Clean-Build
	}

	Restore-NuGet

	$buildSuccess = Build-Project

	if (-not $buildSuccess) {
		$buildTime = [math]::Round(((Get-Date) - $startTime).TotalSeconds, 1)
		Show-Summary $false $buildTime
		exit 1
	}

	$validationSuccess = Validate-Refactoring

	$buildTime = [math]::Round(((Get-Date) - $startTime).TotalSeconds, 1)

	Show-Summary ($buildSuccess -and $validationSuccess) $buildTime

	if (-not ($buildSuccess -and $validationSuccess)) {
		exit 1
	}

	exit 0
}
catch {
	Write-ColorOutput "❌ Erro ao executar script: $_" $Error
	exit 1
}
