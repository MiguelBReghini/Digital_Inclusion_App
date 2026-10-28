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
            btnKeyboard.Left = centerX - Convert.ToInt32(Width / 2.3);
            btnMouse.Left = centerX + Convert.ToInt32(Width / 20);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 3;
            double divSize = 2.6;

            btnKeyboard.Top = Convert.ToInt32(Height / divTop);
            btnMouse.Top = Convert.ToInt32(Height / divTop);

            btnKeyboard.Width = Convert.ToInt32(Width / divSize);
            btnMouse.Width = Convert.ToInt32(Width / divSize);

            btnKeyboard.Height = Convert.ToInt32(Height / divSize);
            btnMouse.Height = Convert.ToInt32(Height / divSize);
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
            this.Close();
            t1 = new Thread(openMouse);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
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
            Application.Run(new KeyboardPage1());
            return;
        }

        public void openMouse()
        {
            Application.Run(new Mouse());
            return;
        }

        public void openLearning()
        {
            Application.Run(new Learning());
            return;
        }
    }
}
