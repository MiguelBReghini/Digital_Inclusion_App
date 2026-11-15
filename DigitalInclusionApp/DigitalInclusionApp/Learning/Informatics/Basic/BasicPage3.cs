using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class BasicPage3 : Form
    {
        Thread? t1;
        public BasicPage3()
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
            imgArmazenadores.Width = imageWidth;
            imgArmazenadores.Height = imageWidth;
            imgImpressora.Width = imageWidth;
            imgImpressora.Height = imageWidth;
            imgFone.Width = imageWidth;
            imgFone.Height = imageWidth;

            textBox2.Width = Convert.ToInt32(imageWidth * 3.9);
            textBox2.Height = Convert.ToInt32(imageWidth * 0.5);
            textBox2.Font = new Font("Segoe UI", Width / 80, FontStyle.Bold);


            //Images X
            imgImpressora.Left = centerX - Convert.ToInt32(Width / 10);
            imgArmazenadores.Left = centerX - Convert.ToInt32(Width / 2.5);
            imgFone.Left = centerX + Convert.ToInt32(Width / 5);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnProximo.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            textBox2.Left = centerX - Convert.ToInt32(Width / 2.5);

            //Images Y
            double divTop = 6;
            imgArmazenadores.Top = Convert.ToInt32(Height / divTop);
            imgImpressora.Top = Convert.ToInt32(Height / divTop);
            imgFone.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            double textTop = 1.7;
            textBox2.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openBasicPractice);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            return;
        }


        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openBasicPage2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void openBasicPage3()
        {
            Application.Run(new BasicPage3());
            return;
        }
        public void openBasicPage2()
        {
            Application.Run(new BasicPage2());
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void openBasicPractice()
        {
            Application.Run(new BasicPractice());
            return;
        }
    }
}
