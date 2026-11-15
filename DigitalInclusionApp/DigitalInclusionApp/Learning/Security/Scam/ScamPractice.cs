using DigitalInclusionApp.Games;
using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de prática (quiz) sobre scams.
    /// Testa conhecimento do usuário sobre golpes comuns na internet.
    /// </summary>
    public partial class ScamPractice : BaseForm
    {
        private ScamQuiz quiz = new ScamQuiz();

        /// <summary>
        /// Inicializa uma nova instância de ScamPractice.
        /// </summary>
        public ScamPractice()
        {
            InitializeComponent();
            ShowQuestion();
        }

        /// <summary>
        /// Método abstrato não utilizado neste formulário.
        /// </summary>
        protected override void CenterControls()
        {
            // Formulário de quiz não requer centralização dinâmica de controles
        }
        private void ShowQuestion()
        {
            lblProgress.Text = $"Pergunta {quiz.CurrentNumber} de {quiz.Total}";
            lblQuestion.Text = quiz.CurrentQuestion.Text;

            lblExplanation.Visible = false;
            btnNext.Visible = false;
            btnScam.Enabled = true;
            btnNotScam.Enabled = true;
        }
        private void ShowAnswer(bool saidScam)
        {
            bool correct = quiz.Answer(saidScam);

            lblExplanation.Text = (correct ? "Você acertou! " : "Não foi dessa vez. ")
                                  + quiz.CurrentQuestion.Explanation;
            lblExplanation.ForeColor = correct ? Color.Lime : Color.Red;
            lblExplanation.Visible = true;

            btnScam.Enabled = false;
            btnNotScam.Enabled = false;
            btnNext.Visible = true;
        }

        private void btnScam_Click(object sender, EventArgs e)
        {
            ShowAnswer(true);
        }

        private void btnNotScam_Click(object sender, EventArgs e)
        {
            ShowAnswer(false);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (quiz.IsFinished)            
            {
                quiz.Restart();
                btnScam.Visible = true;
                btnNotScam.Visible = true;
                btnNext.Text = "Próximo ➞";
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
            btnScam.Visible = false;
            btnNotScam.Visible = false;
            btnNext.Text = "Recomeçar";
            btnNext.Visible = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNavigator.NavigateAndClose<Security>(this);
        }
    }
}
