using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalInclusionApp
{

    public partial class MousePage1 : Form
    {
        Thread? t1;
        public MousePage1()
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
            double Width = Bounds.Width;
            double Height = Bounds.Height;
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            //Image Sizes
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 4 - 80);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;
            pictureBox3.Width = imageWidth;
            pictureBox3.Height = imageWidth;
            //Button Sizes
            double divSize = 6;
            btnTarget.Width = Convert.ToInt32(Width / divSize - 100);
            btnTarget.Height = Convert.ToInt32(Height / divSize);


            //Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            pictureBox3.Left = centerX + Convert.ToInt32(Width / 30);
            //Button X
            btnTarget.Left = centerX - Convert.ToInt32(Width / 6.5);
            button1.Left = centerX + Convert.ToInt32(Width / 3.5);
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox3.Left = centerX + Convert.ToInt32(Width / 7);
            textBox1.Left = centerX - Convert.ToInt32(Width / 2.5);

            //Images Y
            double divTop = 3.8;
            pictureBox1.Top = Convert.ToInt32(Height / 6);
            pictureBox3.Top = Convert.ToInt32(Height / 6);
            //Button Y
            btnTarget.Top = Convert.ToInt32(Height / divTop);
            button1.Top = Convert.ToInt32(Height / divTop);
            //Text Y
            double textTop = 1.7;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox3.Top = Convert.ToInt32(Height / textTop);
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
            Application.Run(new MousePage2());
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            btnTarget.Text = "Você clicou!!! ✔✔✔✔";
            btnTarget.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            btnTarget.ForeColor = Color.Green;
        }

        private int cliqueCount = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            cliqueCount++;

            if (cliqueCount == 1)
            {
                timer1.Start();
            }
            else if (cliqueCount == 2)
            {
                timer1.Stop();
                cliqueCount = 0;

                button1.Text = "Você clicou!!! ✔✔✔✔";
                button1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                button1.ForeColor = Color.Green;
            }
        }
    }
}
