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
            socialProjectTxt.Left = centerX - (socialProjectTxt.Width / 2);
            textBox1.Left = centerX - (textBox1.Width / 2);
            btnBack.Left = centerX - (btnBack.Width / 2);

            socialProjectTxt.Location = new Point(centerX - Convert.ToInt32(Width / 4.8), Height / 5);
            textBox1.Location = new Point(centerX - Convert.ToInt32(Width / 4.8), Convert.ToInt32(Height / 1.6));

            socialProjectTxt.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            socialProjectTxt.CharacterCasing = CharacterCasing.Upper;

            textBox1.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            textBox1.CharacterCasing = CharacterCasing.Upper;
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

        private void SocialProjectlbl_Click(object sender, EventArgs e)
        {

        }

        private void socialProjectTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
