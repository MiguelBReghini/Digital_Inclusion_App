using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Text.Json;
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
        Thread? t1;
        private WordRandomizer randomizer = new WordRandomizer();
        private TypingValidator validator = new TypingValidator();

        public KeyboardPractice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomizer.RandomizeIndex();
            Palavra.Text = randomizer.RandomWord;
            validator.StartWord(randomizer.RandomWord);
            keyboardProgressBar.Maximum = quotaPalavras;
            keyboardProgressBar.Value = 0;
        }

        private void backBtnKeyboardPractice_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openKeyboard);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }
        private void openKeyboard()
        {
            Application.Run(new Keyboard());
            return;
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



            e.Handled = true;
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

            if(palavrasCompletadas >= quotaPalavras)
            {
                inputWord.Refresh();
                MessageBox.Show("Você concluiu 10 palavras.");
                return;
            }

            randomizer.RandomizeIndex();
            Palavra.Text = randomizer.RandomWord;
            validator.StartWord(randomizer.RandomWord);
            inputWord.Clear();
        }

        private void keyboardProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
