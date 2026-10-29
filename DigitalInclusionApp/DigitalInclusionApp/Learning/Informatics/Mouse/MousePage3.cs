using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class MousePage3 : Form
    {
        Thread? t1;
        public MousePage3()
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
            double Width = Bounds.Width;
            double Height = Bounds.Height;
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
            pictureBox2.Width = imageWidth;
            pictureBox2.Height = imageWidth;
            pictureBox3.Width = imageWidth;
            pictureBox3.Height = imageWidth;
            //Button Sizes
            double divSize = 6;
            btnTarget.Width = Convert.ToInt32(Width / divSize - 100);
            btnTarget.Height = Convert.ToInt32(Height / divSize);


            //Images X
            pictureBox1.Left = centerX + Convert.ToInt32(Width / 30);
            pictureBox2.Left = centerX - Convert.ToInt32(Width / 2.5);
            pictureBox3.Left = centerX + Convert.ToInt32(Width / 4);
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
            pictureBox3.Top = Convert.ToInt32(Height / divTop);
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
            this.Close();
            t1 = new Thread(openKeyboardPage2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            return;
        }


        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openInformatics);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void openKeyboardPage2()
        {
            Application.Run(new Mouse());
            return;
        }
        public void openInformatics()
        {
            Application.Run(new Informatics());
            return;
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
