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
            btnBack.Left = centerX - (btnBack.Width / 2);
            imgCienciaComp.Left = centerX - Convert.ToInt32(Width / 2.5);
            //imgCoordEx.Left = centerX + Width / 20;
            //imgCoordEx.Image = Properties.Resources.coordenadoria_de_extensao;
            //imgCoordEx.SizeMode = PictureBoxSizeMode.StretchImage;
            //panel1.Controls.SetChildIndex(imgCoordEx, panel1.Controls.Count - 1);

            imgCienciaComp.Top = Convert.ToInt32(Height / 1.5);
            //imgCoordEx.Top = Convert.ToInt32(Height / 1.5);

            socialProjectTxt.Location = new Point(centerX - Convert.ToInt32(Width / 1.9), Height / 5);
            textBox1.Location = new Point(centerX - Width / 80, Convert.ToInt32(Height / 5));

            socialProjectTxt.Font = new Font("Segoe UI", Width/100, FontStyle.Bold);
            textBox1.Font = new Font("Segoe UI", Width / 100);

            socialProjectTxt.Width = Width / 2;
            textBox1.Width = Width / 2;
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
