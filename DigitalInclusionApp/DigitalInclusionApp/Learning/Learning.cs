using Microsoft.VisualBasic;
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
    public partial class Learning : Form
    {
        Thread? t1;
        public Learning()
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

            double Width = Bounds.Width;
            double Height = Bounds.Height;
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
            btnInformatics.Left = centerX - Convert.ToInt32(Width/ 2.3);
            btnSecurity.Left = centerX + Convert.ToInt32(Width/ 20);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 3;
            double divSize = 2.6;

            btnInformatics.Top = Convert.ToInt32(Height / divTop);
            btnSecurity.Top = Convert.ToInt32(Height / divTop);

            btnInformatics.Width = Convert.ToInt32(Width/ divSize);
            btnSecurity.Width = Convert.ToInt32(Width / divSize);

            btnInformatics.Height = Convert.ToInt32(Height / divSize);
            btnSecurity.Height = Convert.ToInt32(Height / divSize);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openMain);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnInformatics_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openInformatics);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openSecurity);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openInformatics()
        {
            Application.Run(new Informatics());
            return;
        }

        public void openSecurity()
        {
            Application.Run(new Security());
            return;
        }

        public void openMain()
        {
            Application.Run(new MainForm());
            return;
        }
    }
}
