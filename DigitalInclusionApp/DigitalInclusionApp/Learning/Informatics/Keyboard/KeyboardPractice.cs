using DigitalInclusionApp.Games;
using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de prática do teclado com validação de digitação.
    /// Utiliza mecanismos de gamificação para incentivar o aprendizado.
    /// </summary>
    public partial class KeyboardPractice : BaseForm
    {
        private bool placeholderAtivo = true;
        private bool erroAtivo = false;
        private int palavrasCompletadas = 0;
        private const int quotaPalavras = 10;
        private readonly WordRandomizer randomizer = new();
        private readonly TypingValidator validator = new();

        /// <summary>
        /// Inicializa uma nova instância de KeyboardPractice.
        /// </summary>
        public KeyboardPractice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Centraliza os controles do formulário quando redimensionado.
        /// </summary>
        protected override void CenterControls()
        {
            if (panel2 == null)
                return;

            var centerX = panel2.ClientSize.Width / 2;
            var centerY = panel2.ClientSize.Height / 2;
            keyboardProgressBar.Left = centerX - (keyboardProgressBar.Width / 2);
            backBtnKeyboardPractice.Left = centerX - (backBtnKeyboardPractice.Width / 2);
            Palavra.Left = centerX - (Palavra.Width / 2);

            instructionsKeyboardPractice.Left = centerX - (instructionsKeyboardPractice.Width / 2);
            instructionsKeyboardPractice.Top = centerY;

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
            FormNavigator.NavigateAndClose<KeyboardPage3>(this);
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

            if (e.KeyChar == '\b')
            {
                HandleBackspace();
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
            Palavra.Left = panel2.ClientSize.Width / 2 - (Palavra.Width / 2);
        }
        private void HandleBackspace()
        {
            if (placeholderAtivo)
            {
                return;
            }
            if (erroAtivo)
            {
                RemoveLastChar();
                erroAtivo = false;
            }
            else if (validator.ProgressIndex > 0)
            {
                RemoveLastChar();
                validator.StepBack();
            }
        }
        private void RemoveLastChar()
        {
            inputWord.Text = inputWord.Text.Substring(0, inputWord.Text.Length - 1);
        }

       
    }
}
