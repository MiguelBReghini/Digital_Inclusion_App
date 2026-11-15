using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    public partial class ScamPage3 : BaseForm
    {
        public ScamPage3()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            //Image Sizes
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 4 - 80);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;

            panel3.Width = Convert.ToInt32(Width / 1.6);

            textBox1.Width = Convert.ToInt32(imageWidth * 1.3);
            textBox1.Height = Convert.ToInt32(imageWidth * 0.7);

            //Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            //textBox3.Left = centerX - Convert.ToInt32(Width / 10);
            //textBox2.Left = centerX + Convert.ToInt32(Width / 5);
            textBox1.Left = centerX - Convert.ToInt32(Width / 2.33);
            panel3.Left = centerX - Convert.ToInt32(Width / 6);
            lblUrgencia.Font = new Font("Segoe UI", Width / 50, FontStyle.Bold);
            lblPIX.Font = new Font("Segoe UI", Width / 50, FontStyle.Bold);
            lblLink.Font = new Font("Segoe UI", Width / 50, FontStyle.Bold);
            lblCPF.Font = new Font("Segoe UI", Width / 50, FontStyle.Bold);

            //Images Y
            double divTop = 6;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            panel3.Top = Convert.ToInt32(Height / divTop);
            double textTop = 1.7;
            textBox1.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPractice>(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<ScamPage2>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPIX_Click(object sender, EventArgs e)
        {

        }
    }
}
