using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DigitalInclusionApp.Games;

namespace DigitalInclusionApp
{
    public partial class KeyboardPractice : Form
    {
        private bool placeholderAtivo = true;
        private bool erroAtivo = false;
        private int palavrasCompletadas = 0;
        private const int quotaPalavras = 10;
        private Thread? t1;
        private readonly WordRandomizer randomizer = new();
        private readonly TypingValidator validator = new();

        public KeyboardPractice()
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
            if (panel2 == null)
                return;

            var centerX = panel2.ClientSize.Width / 2;
            keyboardProgressBar.Left = centerX - (keyboardProgressBar.Width / 2);
            backBtnKeyboardPractice.Left = centerX - (backBtnKeyboardPractice.Width / 2);
            Palavra.Left = centerX - (Palavra.Width / 2);
            instructionsKeyboardPractice.Left = centerX - (instructionsKeyboardPractice.Width / 2);
            inputWord.Left = centerX - (inputWord.Width / 2);
            disclaimerKeyboardPractice.Left = centerX - (disclaimerKeyboardPractice.Width / 2);
            diclaimerKeyboardPractice2.Left = centerX - (diclaimerKeyboardPractice2.Width / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomizer.RandomizeIndex();
            Palavra.Text = randomizer.RandomWord;
            validator.StartWord(randomizer.RandomWord);
            keyboardProgressBar.Maximum = quotaPalavras;
            keyboardProgressBar.Value = 0;
            CenterControls();
        }

        private void backBtnKeyboardPractice_Click(object sender, EventArgs e)
        {
            Close();
            t1 = new Thread(openKeyboard);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openKeyboard()
        {
            Application.Run(new Keyboard());
        }

        private void inputWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void KeyboardPractice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (validator.IsComplete)
            {
                return;
            }

            if (placeholderAtivo)
            {
                inputWord.Clear();
                placeholderAtivo = false;
            }

            bool acertou = validator.ValidateChar(e.KeyChar);
            if (acertou)
            {
                if (erroAtivo)
                {
                    inputWord.Text = inputWord.Text.Substring(0, inputWord.Text.Length - 1);
                    erroAtivo = false;
                }

                AppendColored(e.KeyChar.ToString(), inputWord.ForeColor);

                if (validator.IsComplete)
                {
                    CompleteWord();
                }
            }
            else if (!erroAtivo)
            {
                AppendColored(e.KeyChar.ToString(), Color.Red);
                erroAtivo = true;
            }
        }

        private void AppendColored(string text, Color color)
        {
            inputWord.SelectionStart = inputWord.TextLength;
            inputWord.SelectionLength = 0;
            inputWord.SelectionColor = color;
            inputWord.AppendText(text);
            inputWord.SelectionColor = inputWord.ForeColor;
        }

        private void CompleteWord()
        {
            palavrasCompletadas++;
            keyboardProgressBar.Value = palavrasCompletadas;

            if (palavrasCompletadas >= quotaPalavras)
            {
                inputWord.Refresh();
                MessageBox.Show("Você concluiu 10 palavras!");
                ResetGame();
                return;
            }

            NextWord();
        }

        private void ResetGame()
        {
            palavrasCompletadas = 0;
            keyboardProgressBar.Value = 0;
            NextWord();
        }
        private void NextWord()
        {
            randomizer.RandomizeIndex();
            Palavra.Text = randomizer.RandomWord;
            validator.StartWord(randomizer.RandomWord);
            inputWord.Clear();
            erroAtivo = false;
        }

       
    }
}
