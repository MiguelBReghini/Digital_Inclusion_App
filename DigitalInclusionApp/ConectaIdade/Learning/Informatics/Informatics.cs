using System;
using System.Drawing;
using System.Windows.Forms;
using DigitalInclusionApp.Infrastructure;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de seleção de tópicos de Informática.
    /// Oferece acesso aos módulos: Teclado, Mouse e Conceitos Básicos.
    /// </summary>
    public partial class Informatics : BaseForm
    {
        public Informatics()
        {
            InitializeComponent();
        }

        protected override void CenterControls()
        {
            if (panel1 == null)
                return;

            var centerX = panel1.ClientSize.Width / 2;

            lblTitulo.Left = centerX - (lblTitulo.Width / 2);
            btnKeyboard.Left = centerX - Convert.ToInt32(Width / 2.6);
            btnBasics.Left = centerX - Convert.ToInt32(btnBasics.Width / 2);
            btnMouse.Left = centerX + Convert.ToInt32(Width / 10);
            btnBack.Left = centerX - (btnBack.Width / 2);

            double divTop = 4.7;
            double divTop2 = 1.9;
            double divSize = 3.6;

            btnKeyboard.Top = Convert.ToInt32(Height / divTop);
            btnMouse.Top = Convert.ToInt32(Height / divTop);
            btnBasics.Top = Convert.ToInt32(Height / divTop2);

            btnKeyboard.Width = Convert.ToInt32(Width / divSize);
            btnMouse.Width = Convert.ToInt32(Width / divSize);
            btnBasics.Width = Convert.ToInt32(Width / divSize);

            btnKeyboard.Height = Convert.ToInt32(Height / divSize);
            btnMouse.Height = Convert.ToInt32(Height / divSize);
            btnBasics.Height = Convert.ToInt32(Height / divSize);
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<KeyboardPage1>(this);
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<MousePage1>(this);
        }

        private void btnBasics_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<BasicPage1>(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Learning>(this);
        }
    }
}
