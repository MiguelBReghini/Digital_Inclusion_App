using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    public partial class KeyboardPage3 : BaseForm
    {
        public KeyboardPage3()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            // Image Sizes
            var imageWidth = Convert.ToInt32(Width / 2.5);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;

            // Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.2);
            // Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            // Text X
            textBox1.Left = centerX + Convert.ToInt32(Width / 50);

            // Images Y
            double divTop = 7;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            // Text Y
            double textTop = 5;
            textBox1.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<KeyboardPractice>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<KeyboardPage2>(this);
        }
    }
}
