using Microsoft.VisualBasic;
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
    public partial class Informatics : Form
    {
        Thread? t1;
        public Informatics()
        {
            InitializeComponent();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openKeyboard);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            return;
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            //this.Close();
            //t1 = new Thread(openMouse);
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
        public void openKeyboard()
        {
            Application.Run(new Keyboard());
            return;
        }

        public void openMouse()
        {
            //Application.Run(new Mouse());
            return;
        }

        public void openLearning()
        {
            Application.Run(new Learning());
            return;
        }
    }
}
