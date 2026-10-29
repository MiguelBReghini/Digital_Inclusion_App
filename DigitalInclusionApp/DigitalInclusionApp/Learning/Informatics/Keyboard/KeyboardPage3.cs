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

    public partial class KeyboardPage3 : Form
    {
        Thread? t1;
        public KeyboardPage3()
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
            var imageWidth = Convert.ToInt32(Width / 2.5);
            pictureBox1.Width = imageWidth;
            pictureBox1.Height = imageWidth;

            //Images X
            pictureBox1.Left = centerX - Convert.ToInt32(Width / 2.5);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnPraticaKeyboard.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox1.Left = centerX + Convert.ToInt32(Width / 10);

            //Images Y
            double divTop = 7;
            pictureBox1.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            double textTop = 5;
            textBox1.Top = Convert.ToInt32(Height / textTop);
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
