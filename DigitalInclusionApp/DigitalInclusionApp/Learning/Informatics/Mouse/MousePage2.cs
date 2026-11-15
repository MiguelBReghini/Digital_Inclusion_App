using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Segunda página do módulo de aprendizado do mouse.
    /// Demonstra operações de scroll horizontal e vertical.
    /// </summary>
    public partial class MousePage2 : BaseForm
    {
        private bool done;

        /// <summary>
        /// Inicializa uma nova instância de MousePage2.
        /// </summary>
        public MousePage2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Centraliza os controles do formulário quando redimensionado.
        /// </summary>
        protected override void CenterControls()
        {
            double Width = Bounds.Width;
            double Height = Bounds.Height;
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            //Image Sizes
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 4 - 80);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;
            pictureBox2.Width = imageWidth;
            pictureBox2.Height = imageWidth;
            ////Button Sizes
            double divSize = 6;
            //btnTarget.Width = Convert.ToInt32(Width / divSize - 100);
            //btnTarget.Height = Convert.ToInt32(Height / divSize);

            textBox1.Width = Convert.ToInt32(imageWidth * 2);

            textBox2.Width = Convert.ToInt32(imageWidth * 2);



            //Images X
            pictureBox2.Left = centerX + Convert.ToInt32(Width / 30);
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            //btnTarget.Left = centerX - Convert.ToInt32(Width / 7);
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            hScrollBar1.Left = centerX - Convert.ToInt32(Width / 6);
            vScrollBar1.Left = centerX + Convert.ToInt32(Width / 3.5);

            //Text X
            textBox2.Left = centerX + Convert.ToInt32(Width / 20);
            textBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            label2.Left = centerX - Convert.ToInt32(Width / 10);
            label3.Left = centerX - Convert.ToInt32(Width / 6);
            label5.Left = centerX + Convert.ToInt32(Width / 2.7);
            label6.Left = centerX + Convert.ToInt32(Width / 2.7);

            //Images Y
            double divTop = 6;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            pictureBox2.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            hScrollBar1.Top = Convert.ToInt32(Height / 6);
            vScrollBar1.Top = Convert.ToInt32(Height / 6);
            //Text Y
            double textTop = 1.75;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox2.Top = Convert.ToInt32(Height / textTop);
            label2.Top = centerX - Convert.ToInt32(Height / 1.75);
            label3.Top = centerX - Convert.ToInt32(Height / 1.75);
            label5.Top = centerX - Convert.ToInt32(Height / 2);
            label6.Top = centerX - Convert.ToInt32(Height / 1.4);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MousePage3>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MousePage1>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value >= hScrollBar1.Maximum - hScrollBar1.LargeChange + 1)
            {
                label2.Enabled = true;
                done = true;
            }
            else if ((hScrollBar1.Value <= hScrollBar1.Minimum + hScrollBar1.LargeChange + 1) && done)
            {
                label3.Enabled = true;
                done = false;
                return;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        { 
            if (vScrollBar1.Value >= vScrollBar1.Maximum - vScrollBar1.LargeChange + 1)
            {
                label5.Enabled = true;
                done = true;
            }
            else if ((vScrollBar1.Value <= vScrollBar1.Minimum + vScrollBar1.LargeChange + 1) && done)
            {
                label6.Enabled = true;
                done = false;
                return;
            }
        }
    }
}
