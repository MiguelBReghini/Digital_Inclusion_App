using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Terceira página do módulo de aprendizado do mouse.
    /// Demonstra cliques direitos do mouse.
    /// </summary>
    public partial class MousePage3 : BaseForm
    {
        /// <summary>
        /// Inicializa uma nova instância de MousePage3.
        /// </summary>
        public MousePage3()
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
            pictureBox1.Width = Convert.ToInt32(imageWidth * 2);
            pictureBox1.Height = Convert.ToInt32(imageWidth);
            pictureBox2.Width = imageWidth;
            pictureBox2.Height = imageWidth;
            //Button Sizes
            double divSize = 6;
            btnTarget.Width = Convert.ToInt32(Width / divSize - 100);
            btnTarget.Height = Convert.ToInt32(Height / divSize);
            btnTarget.Font = new Font("Segoe UI", Width / 90, FontStyle.Bold);
            //Text Sizes
            textBox1.Width = Convert.ToInt32(imageWidth * 2);
            textBox2.Width = Convert.ToInt32(imageWidth * 2);
            textBox1.Height = Convert.ToInt32(Height / 4);
            textBox2.Height = Convert.ToInt32(Height / 4);
            textBox1.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);
            textBox2.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);


            //Images X
            pictureBox1.Left = centerX + Convert.ToInt32(Width / 30);
            pictureBox2.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            btnTarget.Left = centerX - Convert.ToInt32(Width / 7);
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox1.Left = centerX + Convert.ToInt32(Width / 7);
            textBox2.Left = centerX - Convert.ToInt32(Width / 2.5);

            //Images Y
            double divTop = 6;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            pictureBox2.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            btnTarget.Top = Convert.ToInt32(Height / divTop);
            //Text Y
            double textTop = 1.7;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox2.Top = Convert.ToInt32(Height / textTop);

            var textWidth = Math.Min(420, panel1.ClientSize.Width / 3);
            textBox1.Width = textWidth;
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Mouse>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MousePage2>(this);
        }

        private void btnTarget_Click_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            btnTarget.Text = "Você clicou!!! ✔✔✔✔";
            btnTarget.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            btnTarget.ForeColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTarget_Click(object sender, EventArgs e)
        {

        }
    }
}
