using System;
using System.Windows.Forms;

namespace DigitalInclusionApp.Infrastructure
{
    /// <summary>
    /// Classe base para todos os formulários da aplicação.
    /// Fornece funcionalidades comuns como fullscreen, redimensionamento responsivo
    /// e centralização de controles.
    /// </summary>
    public abstract class BaseForm : Form
    {
        /// <summary>
        /// Inicializa uma nova instância de BaseForm com configurações padrão.
        /// </summary>
        public BaseForm()
        {
            InitializeFormDefaults();
        }

        /// <summary>
        /// Inicializa as configurações padrão do formulário.
        /// Chamado no construtor para garantir consistência.
        /// </summary>
        protected virtual void InitializeFormDefaults()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Manipula o evento OnLoad do formulário.
        /// Aplica configurações de fullscreen e centraliza controles.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFullscreenSettings();
            CenterControls();
        }

        /// <summary>
        /// Manipula o evento OnResize do formulário.
        /// Recentra controles quando o tamanho muda.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (IsHandleCreated)
            {
                CenterControls();
            }
        }

        /// <summary>
        /// Aplica as configurações de fullscreen ao formulário.
        /// </summary>
        protected virtual void ApplyFullscreenSettings()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        /// <summary>
        /// Centraliza os controles do formulário.
        /// Deve ser sobrescrito por classes derivadas para comportamento específico.
        /// </summary>
        protected abstract void CenterControls();
    }
}
