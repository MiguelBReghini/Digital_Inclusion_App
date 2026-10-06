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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Rectangle area = Screen.FromControl(this).WorkingArea;
            if (area.Width == 0 || area.Height == 0)
                return;

            if (this.Width > area.Width || this.Height > area.Height)
            {
                float scaleX = (float)area.Width / this.Width;
                float scaleY = (float)area.Height / this.Height;
                float scale = Math.Min(scaleX, scaleY);
                this.Scale(new SizeF(scale, scale));
            }

            this.Location = new Point(
                area.Left + (area.Width - this.Width) / 2,
                area.Top + (area.Height - this.Height) / 2
            );
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
