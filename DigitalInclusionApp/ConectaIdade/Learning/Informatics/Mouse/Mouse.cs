using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de prática do mouse com desafios interativos.
    /// Inclui cliques simples, duplos, cliques direitos e scroll.
    /// </summary>
    public partial class Mouse : BaseForm
    {
        private Random random = new Random();
        private int clicks;
        private int quotaClicks = 20;
        private int doubleClickCount;
        private bool horizontalDone = false;
        private bool verticalDone = false;
        private bool scrollTaskCompleted = false;

        /// <summary>
        /// Inicializa uma nova instância de Mouse.
        /// </summary>
        public Mouse()
        {
            InitializeComponent();

            hScrollBar1.Scroll += ScrollBar_Scroll;
            vScrollBar1.Scroll += ScrollBar_Scroll;

            progressMouse.Minimum = 0;
            progressMouse.Maximum = quotaClicks;
            progressMouse.Value = 0;
        }

        /// <summary>
        /// Centraliza os controles do formulário quando redimensionado.
        /// </summary>
        protected override void CenterControls()
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
            FormNavigator.NavigateAndClose<MousePage3>(this);
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
            btnTarget.Text = "Botão Esquerdo";

            if (RegisterClick())
                return;

            
        }
        private void NextTask()
        {
            btnTarget.Visible = false;
            btnTargetDir.Visible = false;
            btnDoubleTarget.Visible = false;

            hScrollBar1.Visible = false;
            vScrollBar1.Visible = false;

            horizontalDone = false;
            verticalDone = false;

            scrollTaskCompleted = false;

            int desafio = random.Next(0, 5);

            switch (desafio)
            {
                case 0:
                    if (TryMoveToValidPosition(btnTarget))
                    {
                        btnTarget.Text = "Botão Esquerdo";
                        btnTarget.Visible = true;
                    }
                    break;

                case 1:
                    if (TryMoveToValidPosition(btnTargetDir))
                        btnTargetDir.Visible = true;
                    break;

                case 2:
                    if (TryMoveToValidPosition(btnDoubleTarget))
                        btnDoubleTarget.Visible = true;
                    break;

                case 3:
                    hScrollBar1.Value = hScrollBar1.Minimum;
                    hScrollBar1.Visible = true;
                    break;

                case 4:
                    vScrollBar1.Value = vScrollBar1.Minimum;
                    vScrollBar1.Visible = true;
                    break;
            }
        }

        private void btnTargetDir_Click_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            RegisterClick();
        }

        private bool RegisterClick()
        {
            clicks++;

            progressMouse.Value = Math.Min(clicks, quotaClicks);

            if (clicks >= quotaClicks)
            {
                MessageBox.Show("Você concluiu todos os desafios!");

                ResetGame();
                return true;
            }

            NextTask();
            return false;
        }

        private void ResetGame()
        {
            clicks = 0;
            progressMouse.Value = 0;

            NextTask();
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

        private void btnDoubleTarget_Click(object sender, EventArgs e)
        {
            doubleClickCount++;

            if (doubleClickCount == 1)
            {
                timerDoubleClick.Start();
            }
            else if (doubleClickCount == 2)
            {
                timerDoubleClick.Stop();
                doubleClickCount = 0;

                RegisterClick();
            }
        }
            private void timerDoubleClick_Tick(object sender, EventArgs e)
        {
            timerDoubleClick.Stop();
            doubleClickCount = 0;
        }
        private void CheckScrollCompletion()
        {
            int limiteH = hScrollBar1.Maximum
                - hScrollBar1.LargeChange + 1;

            int limiteV = vScrollBar1.Maximum
                - vScrollBar1.LargeChange + 1;

            if (hScrollBar1.Value >= limiteH)
                horizontalDone = true;

            if (vScrollBar1.Value >= limiteV)
                verticalDone = true;

            if (horizontalDone && verticalDone)
            {
                RegisterClick();
            }
        }
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrollTaskCompleted)
                return;

            System.Windows.Forms.ScrollBar barra = (System.Windows.Forms.ScrollBar)sender;


            int limite = barra.Maximum - barra.LargeChange + 1;

            if (barra.Value >= limite)
            {
                scrollTaskCompleted = true;
                RegisterClick();
            }
        }
    }
    
}
