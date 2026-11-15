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
            lblDev.Left = centerX - Convert.ToInt32(Width / 2.2);
            lblApoio.Left = centerX + Convert.ToInt32(Width / 9);
            imgCienciaComp.Left = centerX - Convert.ToInt32(Width / 2.2);
            imgCoordEx.Left = centerX + Convert.ToInt32(Width / 9);

            double VerticalLabels = 1.8;
            lblDev.Top = Convert.ToInt32(Height / VerticalLabels);
            lblApoio.Top = Convert.ToInt32(Height / VerticalLabels);

            double VerticalImagens = 1.7;
            imgCienciaComp.Top = Convert.ToInt32(Height / VerticalImagens);
            imgCoordEx.Top = Convert.ToInt32(Height / VerticalImagens);

            socialProjectTxt.Location = new Point(centerX - Convert.ToInt32(Width / 1.9), Height / 5);
            textBox1.Location = new Point(centerX - Width / 80, Convert.ToInt32(Height / 5));

            socialProjectTxt.Font = new Font("Segoe UI", Width/100, FontStyle.Bold);
            textBox1.Font = new Font("Segoe UI", Width / 100);

            socialProjectTxt.Width = Width / 2;
            textBox1.Width = Width / 2;

            double LarguraImagens = 2.53;
            double AlturaImagens = 5;
            imgCienciaComp.Width = Width / Convert.ToInt32(LarguraImagens);
            imgCoordEx.Width = Width / Convert.ToInt32(LarguraImagens);
            imgCienciaComp.Height = Height / Convert.ToInt32(AlturaImagens);
            imgCoordEx.Height = Height / Convert.ToInt32(AlturaImagens);
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
