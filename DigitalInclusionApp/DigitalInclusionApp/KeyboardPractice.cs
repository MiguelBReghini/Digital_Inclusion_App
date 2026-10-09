using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Drawing.Text;
using DigitalInclusionApp.Games;
namespace DigitalInclusionApp
{
    public partial class KeyboardPractice : Form
    {
        Thread? t1;
        private WordRandomizer randomizer = new WordRandomizer();

        public KeyboardPractice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomizer.RandomizeIndex();
            Palavra.Text = randomizer.RandomWord;
        }

        private void backBtnKeyboardPractice_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openKeyboard);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            
        }
        private void openKeyboard()
        {
            Application.Run(new Keyboard());
            return;
        }
    }
}
