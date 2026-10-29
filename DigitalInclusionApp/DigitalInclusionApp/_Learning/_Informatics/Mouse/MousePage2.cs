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
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;
            var imageWidth = Math.Min(520, panel1.ClientSize.Width / 2 - 80);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = (int)(imageWidth * 0.86);
            pictureBox1.Left = centerX - (pictureBox1.Width / 2) - 170;

            var textWidth = Math.Min(420, panel1.ClientSize.Width / 3);
            textBox1.Width = textWidth;
            textBox1.Left = centerX + 20;

            voltarBtn.Left = centerX - 340;
            btnPraticaKeyboard.Left = centerX + 20;
            label1.Left = centerX - (label1.Width / 2);
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
