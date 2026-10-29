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

    public partial class MousePage2 : Form
    {
        Thread? t1;
        public MousePage2()
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
            pictureBox2.Width = imageWidth;
            pictureBox2.Height = imageWidth;
            ////Button Sizes
            double divSize = 6;
            //btnTarget.Width = Convert.ToInt32(Width / divSize - 100);
            //btnTarget.Height = Convert.ToInt32(Height / divSize);


            //Images X
            pictureBox1.Left = centerX + Convert.ToInt32(Width / 30);
            pictureBox2.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            //btnTarget.Left = centerX - Convert.ToInt32(Width / 7);
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            hScrollBar1.Left = centerX - Convert.ToInt32(Width / 6);
            vScrollBar1.Left = centerX + Convert.ToInt32(Width / 3.5);
            trackBar1.Left = centerX - Convert.ToInt32(Width / 6);

            //Text X
            textBox2.Left = centerX + Convert.ToInt32(Width / 7);
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
            trackBar1.Top = Convert.ToInt32(Height / 2);
            //Text Y
            double textTop = 1.5;
            textBox1.Top = Convert.ToInt32(Height / textTop);
            textBox2.Top = Convert.ToInt32(Height / textTop);
            label2.Top = centerX - Convert.ToInt32(Height / 1.75);
            label3.Top = centerX - Convert.ToInt32(Height / 1.75);
            label5.Top = centerX - Convert.ToInt32(Height / 2);
            label6.Top = centerX - Convert.ToInt32(Height / 1.4);
        }

        private void btnPraticaKeyboard_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openMousePage3);
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
        private void openMousePage3()
        {
            Application.Run(new MousePage3());
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

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value >= hScrollBar1.Maximum - hScrollBar1.LargeChange + 1)
            {
                label2.Enabled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value >= trackBar1.Maximum)
            {
                label3.Enabled = true;
            }
        }

        bool done;
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
                return;
            }
        }
    }
}
