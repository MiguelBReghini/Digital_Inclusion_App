using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Segunda página do módulo de aprendizado sobre golpes
    /// (scams) na internet, apresentando exemplos práticos.
    /// </summary>
    public partial class ScamPage2 : BaseForm
    {
        /// <summary>
        /// Inicializa uma nova instância de ScamPage2.
        /// </summary>
        public ScamPage2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Centraliza os controles do formulário quando redimensionado.
        /// </summary>
        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            //Image Sizes
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 4 - 80);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;

            textBox1.Width = Convert.ToInt32(imageWidth * 1.3);
            textBox1.Height = Convert.ToInt32(imageWidth * 0.7);
            textBox3.Width = Convert.ToInt32(imageWidth * 1.1);
            textBox3.Height = Convert.ToInt32(imageWidth * 2);
            textBox2.Width = Convert.ToInt32(imageWidth * 1.1);
            textBox2.Height = Convert.ToInt32(imageWidth * 2);
            textBox1.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);
            textBox2.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);
            textBox3.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);

            //Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox3.Left = centerX - Convert.ToInt32(Width / 10);
            textBox2.Left = centerX + Convert.ToInt32(Width / 5);
            textBox1.Left = centerX - Convert.ToInt32(Width / 2.33);

            //Images Y
            double divTop = 6;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            double textTop = 1.7;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox3.Top = Convert.ToInt32(Height / 7);
            textBox2.Top = Convert.ToInt32(Height / 7);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPage3>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPage1>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
