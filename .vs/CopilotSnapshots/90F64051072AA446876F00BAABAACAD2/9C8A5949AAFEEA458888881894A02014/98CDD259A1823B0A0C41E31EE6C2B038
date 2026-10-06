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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Rectangle area = Screen.FromControl(this).WorkingArea;
            if (area.Width == 0 || area.Height == 0)
                return;

            if (this.Width > area.Width || this.Height > area.Height)
            {
                float scaleX = (float)area.Width / this.Width;
                float scaleY = (float)area.Height / this.Height;
                float scale = Math.Min(scaleX, scaleY);
                this.Scale(new SizeF(scale, scale));
            }

            this.Location = new Point(
                area.Left + (area.Width - this.Width) / 2,
                area.Top + (area.Height - this.Height) / 2
            );
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
