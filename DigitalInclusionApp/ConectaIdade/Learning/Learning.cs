using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de seleção de módulos de aprendizado.
    /// Oferece acesso aos módulos: Informática e Segurança.
    /// </summary>
    public partial class Learning : BaseForm
    {
        public Learning()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnInformatics.Left = centerX - Convert.ToInt32(Width / 2.3);
            btnSecurity.Left = centerX + Convert.ToInt32(Width / 20);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 3;
            double divSize = 2.6;

            btnInformatics.Top = Convert.ToInt32(Height / divTop);
            btnSecurity.Top = Convert.ToInt32(Height / divTop);

            btnInformatics.Width = Convert.ToInt32(Width / divSize);
            btnSecurity.Width = Convert.ToInt32(Width / divSize);

            btnInformatics.Height = Convert.ToInt32(Height / divSize);
            btnSecurity.Height = Convert.ToInt32(Height / divSize);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MainForm>(this);
        }

        private void btnInformatics_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Informatics>(this);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Security>(this);
        }
    }
}
