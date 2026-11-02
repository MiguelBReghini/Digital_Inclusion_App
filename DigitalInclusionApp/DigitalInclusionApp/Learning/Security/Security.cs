using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    public partial class Security : Form
    {
        Thread? t1;
        public Security()
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

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnScam.Left = centerX - (btnScam.Width / 2);
            btnBack.Left = centerX - (btnBack.Width / 2);

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnScam.Left = centerX - Convert.ToInt32(Width / 5.1);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 3;
            double divSize = 2.6;

            btnScam.Top = Convert.ToInt32(Height / divTop);

            btnScam.Width = Convert.ToInt32(Width / divSize);

            btnScam.Height = Convert.ToInt32(Height / divSize);
        }

        private void btnScam_Click(object sender, EventArgs e)
        {
            //this.Close();
            //t1 = new Thread(openScams);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
            return;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLearning);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openScams()
        {
            //Application.Run(new Scams());
            return;
        }
        public void openLearning()
        {
            Application.Run(new Learning());
            return;
        }
    }
}
