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
