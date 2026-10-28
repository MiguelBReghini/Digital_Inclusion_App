using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class Keyboard : Form
    {
        Thread? t1;
        public Keyboard()
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
            t1 = new Thread(openKeyboardPractice);
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
        private void openKeyboardPractice()
        {
            Application.Run(new KeyboardPractice());
            return;
        }
        public void openInformatics()
        {
            Application.Run(new Informatics());
            return;
        }
       
    }
}
