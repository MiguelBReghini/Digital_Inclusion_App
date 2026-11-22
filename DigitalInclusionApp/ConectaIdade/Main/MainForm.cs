using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário principal da aplicação Digital Inclusion.
    /// Apresenta as opções principais: Aprender, Créditos e Sair.
    /// </summary>
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnAprender.Left = centerX - Convert.ToInt32(Width / 2.8);
            btnCreditos.Left = centerX - Convert.ToInt32(Width / 2.8);
            btnSair.Left = centerX + Convert.ToInt32(Width / 110);

            double divTop1 = 4;
            double divTop2 = 1.9;
            double divSize1 = 1.381;
            double divSize2 = 4;
            double lowSize1 = 2.8;
            double lowSize2 = 3.5;

            btnAprender.Top = Convert.ToInt32(Height / divTop1);
            btnCreditos.Top = Convert.ToInt32(Height / divTop2);
            btnSair.Top = Convert.ToInt32(Height / divTop2);

            btnAprender.Width = Convert.ToInt32(Width / divSize1);
            btnCreditos.Width = Convert.ToInt32(Width / lowSize1);
            btnSair.Width = Convert.ToInt32(Width / lowSize1);

            btnAprender.Height = Convert.ToInt32(Height / divSize2);
            btnCreditos.Height = Convert.ToInt32(Height / lowSize2);
            btnSair.Height = Convert.ToInt32(Height / lowSize2);

            btnAprender.Font = new Font("Segoe UI", btnAprender.Width / 10, FontStyle.Bold);
            btnCreditos.Font = new Font("Segoe UI", btnCreditos.Width / 10, FontStyle.Bold);
            btnSair.Font = new Font("Segoe UI", btnSair.Width / 10, FontStyle.Bold);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Learning>(this);
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Credits>(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
