using DigitalInclusionApp.Games;
using DigitalInclusionApp.Infrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalInclusionApp
{
    /// <summary>
    /// Formulário de prática (quiz) sobre conceitos básicos de informática.
    /// Testa conhecimento do usuário sobre componentes e conceitos fundamentais.
    /// </summary>
    public partial class BasicPractice : BaseForm
    {
        private BasicQuiz.Quiz quiz = new BasicQuiz.Quiz();

        /// <summary>
        /// Inicializa uma nova instância de BasicPractice.
        /// </summary>
        public BasicPractice()
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
            btnTrue.Enabled = true;
            btnFalse.Enabled = true;
        }
        private void ShowAnswer(bool saidScam)
        {
            bool correct = quiz.Answer(saidScam);

            lblExplanation.Text = (correct ? "Você acertou! " : "Não foi dessa vez. ")
                                  + quiz.CurrentQuestion.Explanation;
            lblExplanation.ForeColor = correct ? Color.Lime : Color.Red;
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
                btnNext.Text = "Próximo ➜";
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
            FormNavigator.NavigateAndClose<Informatics>(this);
        }
    }
}

