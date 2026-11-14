using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class BasicPage1 : Form
    {
        Thread? t1;
        public BasicPage1()
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
            imgCelular.Width = imageWidth;
            imgCelular.Height = imageWidth;
            imgConjunto.Width = imageWidth;
            imgConjunto.Height = imageWidth;

            txtAparelhos.Width = Convert.ToInt32(imageWidth * 3.9);
            txtAparelhos.Height = Convert.ToInt32(imageWidth * 0.5);
            txtAparelhos.Font = new Font("Segoe UI", Width/80, FontStyle.Bold);

            //Images X
            imgCelular.Left = centerX - Convert.ToInt32(Width / 2.5);
            imgConjunto.Left = centerX + Convert.ToInt32(Width / 5);
            //Button X
            voltarBtn.Left = centerX - Convert.ToInt32(Width / 3);
            btnProximo.Left = centerX + Convert.ToInt32(Width / 12);
            //Text X
            txtAparelhos.Left = centerX - Convert.ToInt32(Width / 2.5);

            //Images Y
            double divTop = 6;
            imgCelular.Top = Convert.ToInt32(Height / divTop);
            imgConjunto.Top = Convert.ToInt32(Height / divTop);
            //Button Y
            //Text Y
            double textTop = 1.7;
            txtAparelhos.Top = Convert.ToInt32(Height / textTop);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openBasicPage2);
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
        private void openBasicPage2()
        {
            Application.Run(new BasicPage2());
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
    }
}
