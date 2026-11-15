using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Terceira página do módulo de Conceitos Básicos de Informática.
    /// Apresenta informações sobre periféricos de armazenamento e saída.
    /// </summary>
    public partial class BasicPage3 : BaseForm
    {
        public BasicPage3()
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
            imgArmazenadores.Width = imageWidth;
            imgArmazenadores.Height = imageWidth;
            imgImpressora.Width = imageWidth;
            imgImpressora.Height = imageWidth;
            imgFone.Width = imageWidth;
            imgFone.Height = imageWidth;

            textBox2.Width = Convert.ToInt32(imageWidth * 3.9);
            textBox2.Height = Convert.ToInt32(imageWidth * 0.8);
            textBox2.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);

            // Images X
            imgImpressora.Left = centerX - Convert.ToInt32(Width / 10);
            imgArmazenadores.Left = centerX - Convert.ToInt32(Width / 2.5);
            imgFone.Left = centerX + Convert.ToInt32(Width / 5);
            // Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnProximo.Left = centerX + Convert.ToInt32(Width / 12);
            // Text X
            textBox2.Left = centerX - Convert.ToInt32(Width / 2.5);

            // Images Y
            double divTop = 6;
            imgArmazenadores.Top = Convert.ToInt32(Height / divTop);
            imgImpressora.Top = Convert.ToInt32(Height / divTop);
            imgFone.Top = Convert.ToInt32(Height / divTop);
            // Button Y
            // Text Y
            double textTop = 1.7;
            textBox2.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<BasicPage1>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<BasicPage2>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
