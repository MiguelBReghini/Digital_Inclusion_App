using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace DigitalInclusionApp
{

    public partial class Mouse : Form
    {
        Thread? t1;
        private Random random = new Random();
        public Mouse()
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

            var centerX = this.ClientSize.Width / 2;
            var centerY = this.ClientSize.Height / 2;

            mouseLabel.Left = centerX - (mouseLabel.Width / 2);
            btnTarget.Left = centerX - (btnTarget.Width / 2);
            btnTarget.Top = centerY - (btnTarget.Height / 2);
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;

            int x = random.Next(0, Math.Max(1, maxX + 1));
            int y = random.Next(0, Math.Max(1, maxY + 1));

            btnTarget.Location = new Point(x, y);
            btnTarget.Visible = false;
            btnTargetDir.Visible = true;
            btnTarget.Text = "Botão Esquerdo";
        }
        private void btnTargetDir_Click_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;

            if (maxX <= 0 || maxY <= 0)
            {
                return;
            }
            int x = random.Next(maxX + 1);
            int y = random.Next(maxY + 1);

            btnTargetDir.Location = new Point(x, y);


            btnTargetDir.Visible = false;
            btnTarget.Visible = true;
        }


        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openInformatics);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        public void openInformatics()
        {
            Application.Run(new Informatics());
            return;
        }

        private void mouseLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnTargetDir_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_Load(object sender, EventArgs e)
        {

        }
    }
}
