using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class Keyboard : Form
    {
        Thread? t1;
        public Keyboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            label1.MaximumSize = new Size(panel1.Width - 20, 0);
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {

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
