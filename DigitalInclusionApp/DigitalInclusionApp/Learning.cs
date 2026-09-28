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
