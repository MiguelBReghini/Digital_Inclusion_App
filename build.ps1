# Script de compilação
cd "DigitalInclusionApp\DigitalInclusionApp"
dotnet build --no-restore 2>&1
$buildResult = $LASTEXITCODE
cd ..\..

if ($buildResult -eq 0) {
	Write-Host "✓ Build concluído com sucesso!" -ForegroundColor Green
} else {
	Write-Host "✗ Build falhou com código $buildResult" -ForegroundColor Red
}

exit $buildResult
