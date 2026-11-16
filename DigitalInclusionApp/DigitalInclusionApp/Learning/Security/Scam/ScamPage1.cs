using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Primeira página do módulo de aprendizado sobre golpes
    /// (scams) na internet, apresentando tipos comuns.
    /// </summary>
    public partial class ScamPage1 : BaseForm
    {
        /// <summary>
        /// Inicializa uma nova instância de ScamPage1.
        /// </summary>
        public ScamPage1()
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
            pictureBox3.Width = imageWidth;
            pictureBox3.Height = imageWidth;

            textBox1.Width = Convert.ToInt32(imageWidth * 1.3);
            textBox1.Height = Convert.ToInt32(imageWidth * 0.7);
            textBox3.Width = Convert.ToInt32(imageWidth * 1.3);
            textBox3.Height = Convert.ToInt32(imageWidth * 0.7);
            textBox1.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);
            textBox3.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);
            //Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 3);
            pictureBox3.Left = centerX + Convert.ToInt32(Width / 8);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox3.Left = centerX + Convert.ToInt32(Width / 9.8);
            textBox1.Left = centerX - Convert.ToInt32(Width / 2.8);

            //Images Y
            double divTop = 6;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            pictureBox3.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            double textTop = 1.7;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox3.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPage2>(this);
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
