using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class ScamPage3 : Form
    {
        Thread? t1;
        public ScamPage3()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFullscreen();
            CenterControls();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (IsHandleCreated)
            {
                CenterControls();
            }
        }

        private void ApplyFullscreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CenterControls()
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
            //this.Close();
            //t1 = new Thread(openScamPage4);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
            return;
        }


        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openScamPage2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void openScamPage4()
        {
            Application.Run(new ScamPage4());
            return;
        }
        public void openScamPage2()
        {
            Application.Run(new ScamPage2());
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
