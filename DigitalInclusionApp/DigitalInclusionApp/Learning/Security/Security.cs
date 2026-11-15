using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de seleção de tópicos de Segurança.
    /// Oferece acesso ao módulo: Prevenção de Fraudes.
    /// </summary>
    public partial class Security : BaseForm
    {
        public Security()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnScam.Left = centerX - Convert.ToInt32(Width / 5.1);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 3;
            double divSize = 2.6;

            btnScam.Top = Convert.ToInt32(Height / divTop);
            btnScam.Width = Convert.ToInt32(Width / divSize);
            btnScam.Height = Convert.ToInt32(Height / divSize);
        }

        private void btnScam_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPage1>(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Learning>(this);
        }
    }
}
