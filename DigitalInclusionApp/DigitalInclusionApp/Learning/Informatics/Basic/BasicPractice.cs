using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DigitalInclusionApp.Games;


namespace DigitalInclusionApp
{
    public partial class BasicPractice : Form
    {
        Thread? t1;
        private BasicQuiz.Quiz quiz = new BasicQuiz.Quiz();
        public BasicPractice()
        {
            InitializeComponent();
            ShowQuestion();
        }
        private void ShowQuestion()
        {
            lblProgress.Text = $"Pergunta {quiz.CurrentNumber} de {quiz.Total}";
            lblQuestion.Text = quiz.CurrentQuestion.Text;

            lblExplanation.Visible = false;
            btnNext.Visible = false;
            btnTrue.Enabled = true;
            btnFalse.Enabled = true;
        }
        private void ShowAnswer(bool saidScam)
        {
            bool correct = quiz.Answer(saidScam);

            lblExplanation.Text = (correct ? "Você acertou! " : "Não foi dessa vez. ")
                                  + quiz.CurrentQuestion.Explanation;
            lblExplanation.ForeColor = correct ? Color.DarkGreen : Color.DarkRed;
            lblExplanation.Visible = true;

            btnTrue.Enabled = false;
            btnFalse.Enabled = false;
            btnNext.Visible = true;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            ShowAnswer(true);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            ShowAnswer(false);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (quiz.IsFinished)
            {
                quiz.Restart();
                btnTrue.Visible = true;
                btnFalse.Visible = true;
                btnNext.Text = "Próximo";
                ShowQuestion();
                return;
            }

            quiz.Next();

            if (quiz.IsFinished)
            {
                ShowResult();
            }
            else
            {
                ShowQuestion();
            }
        }

        private void ShowResult()
        {
            lblProgress.Text = "";
            lblQuestion.Text = $"Você acertou {quiz.Score} de {quiz.Total} perguntas.";
            lblExplanation.Visible = false;
            btnTrue.Visible = false;
            btnFalse.Visible = false;
            btnNext.Text = "Recomeçar";
            btnNext.Visible = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
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
    }
}

