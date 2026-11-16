using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário que exibe os créditos da aplicação.
    /// Mostra informações sobre desenvolvedores e parceiros.
    /// </summary>
    public partial class Credits : BaseForm
    {
        public Credits()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnBack.Left = centerX - (btnBack.Width / 2);
            lblDev.Left = centerX - Convert.ToInt32(Width / 2.2);
            lblApoio.Left = centerX + Convert.ToInt32(Width / 9);
            imgCienciaComp.Left = centerX - Convert.ToInt32(Width / 2.2);
            imgCoordEx.Left = centerX + Convert.ToInt32(Width / 9);

            double VerticalLabels = 1.9;
            lblDev.Top = Convert.ToInt32(Height / VerticalLabels);
            lblApoio.Top = Convert.ToInt32(Height / VerticalLabels);

            double VerticalImagens = 1.7;
            imgCienciaComp.Top = Convert.ToInt32(Height / VerticalImagens);
            imgCoordEx.Top = Convert.ToInt32(Height / VerticalImagens);

            socialProjectTxt.Location = new Point(centerX - Convert.ToInt32(Width / 1.9), Height / 5);
            textBox1.Location = new Point(centerX - Width / 80, Convert.ToInt32(Height / 5));

            socialProjectTxt.Font = new Font("Segoe UI", Width/100, FontStyle.Bold);
            textBox1.Font = new Font("Segoe UI", Width / 100);

            socialProjectTxt.Width = Width / 2;
            textBox1.Width = Width / 2;
            socialProjectTxt.Height = Height / 3;
            textBox1.Height = Height / 3;

            double LarguraImagens = 2.53;
            double AlturaImagens = 5;
            imgCienciaComp.Width = Width / Convert.ToInt32(LarguraImagens);
            imgCoordEx.Width = Width / Convert.ToInt32(LarguraImagens);
            imgCienciaComp.Height = Height / Convert.ToInt32(AlturaImagens);
            imgCoordEx.Height = Height / Convert.ToInt32(AlturaImagens);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MainForm>(this);
        }

        private void SocialProjectlbl_Click(object sender, EventArgs e)
        {

        }

        private void socialProjectTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
