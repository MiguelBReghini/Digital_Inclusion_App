using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalInclusionApp
{
    public partial class MainForm : Form
    {
        Thread? t1;
        public MainForm()
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
            var centerY = panel1.ClientSize.Height / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnAprender.Left = centerX - Convert.ToInt32(Width / 2.8);
            btnCreditos.Left = centerX - Convert.ToInt32(Width / 2.8);
            btnSair.Left = centerX + Convert.ToInt32(Width / 110);

            double divTop1 = 4;
            double divTop2 = 1.9;
            double divSize1 = 1.381;
            double divSize2 = 4;
            double lowSize1 = 2.8;
            double lowSize2 = 3.5;

            btnAprender.Top = Convert.ToInt32(Height / divTop1);
            btnCreditos.Top = Convert.ToInt32(Height / divTop2);
            btnSair.Top = Convert.ToInt32(Height / divTop2);

            btnAprender.Width = Convert.ToInt32(Width / divSize1);
            btnCreditos.Width = Convert.ToInt32(Width / lowSize1);
            btnSair.Width = Convert.ToInt32(Width / lowSize1);

            btnAprender.Height = Convert.ToInt32(Height / divSize2);
            btnCreditos.Height = Convert.ToInt32(Height / lowSize2);
            btnSair.Height = Convert.ToInt32(Height / lowSize2);

            btnAprender.Font = new Font("Segoe UI", Width / 15, FontStyle.Bold);
            btnCreditos.Font = new Font("Segoe UI", Width / 25, FontStyle.Bold);
            btnSair.Font = new Font("Segoe UI", Width / 25, FontStyle.Bold);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            Close();
            t1 = new Thread(openLearning);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openCredits);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void openLearning()
        {
            Application.Run(new Learning());
            return;
        }
        public void openCredits()
        {
            Application.Run(new Credits());
            return;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
