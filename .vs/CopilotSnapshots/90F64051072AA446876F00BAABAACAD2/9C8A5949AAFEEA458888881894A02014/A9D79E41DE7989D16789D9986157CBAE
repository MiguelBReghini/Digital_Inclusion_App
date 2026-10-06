using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DigitalInclusionApp
{
    public partial class Credits : Form
    {
        Thread? t1;
        public Credits()
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
        public void openMain()
        {
            Application.Run(new MainForm());
            return;
        }
    }
}
