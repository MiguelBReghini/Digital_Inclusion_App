using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Primeira página do módulo de Conceitos Básicos de Informática.
    /// Apresenta informações sobre aparelhos eletrônicos básicos.
    /// </summary>
    public partial class BasicPage1 : BaseForm
    {
        public BasicPage1()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            // Image Sizes
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 4 - 80);
            imgCelular.Width = imageWidth;
            imgCelular.Height = imageWidth;
            imgConjunto.Width = imageWidth;
            imgConjunto.Height = imageWidth;

            txtAparelhos.Width = Convert.ToInt32(imageWidth * 3.9);
            txtAparelhos.Height = Convert.ToInt32(imageWidth * 0.8);
            txtAparelhos.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);

            // Images X
            imgCelular.Left = centerX - Convert.ToInt32(Width / 2.5);
            imgConjunto.Left = centerX + Convert.ToInt32(Width / 5);
            // Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnProximo.Left = centerX + Convert.ToInt32(Width / 12);
            // Text X
            txtAparelhos.Left = centerX - Convert.ToInt32(Width / 2.5);

            // Images Y
            double divTop = 6;
            imgCelular.Top = Convert.ToInt32(Height / divTop);
            imgConjunto.Top = Convert.ToInt32(Height / divTop);
            // Button Y
            // Text Y
            double textTop = 1.7;
            txtAparelhos.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<BasicPage2>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Informatics>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
