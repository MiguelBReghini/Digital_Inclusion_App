using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private int clicks = 0;
        private int quotaClicks = 15;
        public Mouse()
        {
            InitializeComponent();
            progressMouse.Minimum = 0;
            progressMouse.Maximum = quotaClicks;
            progressMouse.Value = 0;
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

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if (RegisterClick())
                return;

            if (TryMoveToValidPosition(btnTargetDir))
            {
                btnTarget.Visible = false;
                btnTargetDir.Visible = true;
            }
        }

        private void btnTargetDir_Click_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            if (RegisterClick())
                return;

            if (TryMoveToValidPosition(btnTarget))
            {
                btnTargetDir.Visible = false;
                btnTarget.Visible = true;
            }
        }

        private bool RegisterClick()
        {
            clicks++;

            progressMouse.Value = Math.Min(
                clicks,
                progressMouse.Maximum
            );

            if (clicks >= quotaClicks)
            {
                progressMouse.Value = progressMouse.Maximum;

                MessageBox.Show(
                    "Você concluiu 15 cliques! Prossiga ao próximo exercício de mouse!"
                );

                ResetGame();
                return true;
            }

            return false;
        }

        private void ResetGame()
        {
            clicks = 0;
            progressMouse.Value = 0;

            btnTargetDir.Visible = false;
            btnTarget.Visible = true;

            TryMoveToValidPosition(btnTarget);
        }
        private bool TryMoveToValidPosition(Control alvo)
        {
            Control pai = alvo.Parent;

            if (pai == null)
                return false;

            int maxX = pai.ClientSize.Width - alvo.Width;
            int maxY = pai.ClientSize.Height - alvo.Height;

            if (maxX < 0 || maxY < 0)
                return false;

            for (int i = 0; i < 200; i++)
            {
                Point posicao = new Point(
                    random.Next(maxX + 1),
                    random.Next(maxY + 1)
                );

                Rectangle areaAlvo = new Rectangle(posicao, alvo.Size);

                if (IsPositionFree(alvo, pai, areaAlvo))
                {
                    alvo.Location = posicao;
                    return true;
                }
            }

            return false;
        }

        private bool IsPositionFree(
            Control alvo,
            Control pai,
            Rectangle areaAlvo)
        {
            foreach (Control controle in this.Controls)
            {
                if (!CheckControlTree(
                    controle, alvo, pai, areaAlvo))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckControlTree(
            Control controle,
            Control alvo,
            Control pai,
            Rectangle areaAlvo)
        {
            if (controle == alvo || !controle.Visible)
                return true;

          
            if (controle == btnTarget || controle == btnTargetDir)
                return true;

            
            foreach (Control filho in controle.Controls)
            {
                if (!CheckControlTree(filho, alvo, pai, areaAlvo))
                    return false;
            }

            
            Rectangle areaControle = new Rectangle(
                pai.PointToClient(controle.Parent.PointToScreen(controle.Location)),
                controle.Size
            );

            return !areaAlvo.IntersectsWith(areaControle);
        }


    }
}
