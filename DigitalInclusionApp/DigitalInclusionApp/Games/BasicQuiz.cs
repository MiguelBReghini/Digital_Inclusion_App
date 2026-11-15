using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInclusionApp.Games
{
    internal class BasicQuiz
    {
        internal class QuizQuestion
        {
            public string Text { get; set; } = "";
            public bool IsCorrect { get; set; }
            public string Explanation { get; set; } = "";
        }

        internal class Quiz
        {
            List<QuizQuestion> questions = new List<QuizQuestion>
        {

             new QuizQuestion
            {
                Text = "Pendrives, HDs e SSDs servem para armazenar e transportar arquivos.",
                IsCorrect = true,
                Explanation = "A afirmação é verdadeira. Pendrives, HDs e SSDs guardam arquivos, como fotos e documentos, e permitem levá-los de um computador para outro."
            },
            new QuizQuestion
            {
                Text = "A impressora é o aparelho que capta a voz em chamadas e videochamadas.",
                IsCorrect = false,
                Explanation = "A afirmação é falsa. Quem capta a voz é o microfone, que muitas vezes vem junto dos fones de ouvido. A impressora serve para reproduzir documentos e imagens no papel."
            },
            new QuizQuestion
            {
                Text = "Monitor, teclado e mouse são componentes externos do computador que ajudam a visualizar informações, digitar e navegar.",
                IsCorrect = true,
                Explanation = "A afirmação é verdadeira. O monitor mostra as informações na tela, o teclado serve para digitar e o mouse para navegar. Eles ficam fora do computador e facilitam o seu uso."
            },
            new QuizQuestion
            {
                Text = "O roteador é o aparelho que recebe a conexão de internet da operadora.",
                IsCorrect = false,
                Explanation = "A afirmação é falsa. Quem recebe a conexão da operadora é o modem. O roteador pega essa conexão e a distribui entre os aparelhos, por Wi-Fi ou por cabo."
            },
            new QuizQuestion
            {
                Text = "Os cabos de conexão transmitem energia e dados entre os equipamentos.",
                IsCorrect = true,
                Explanation = "A afirmação é verdadeira. Os cabos levam energia para os aparelhos funcionarem e também transportam dados, como a internet, de um equipamento para outro."
            },
        };
            int currentIndex = 0;
            int score = 0;

            public QuizQuestion CurrentQuestion => questions[currentIndex];
            public bool IsFinished => currentIndex >= questions.Count;
            public int Score => score;
            public int Total => questions.Count;
            public int CurrentNumber => currentIndex + 1;

            public bool Answer(bool saidScam)
            {
                if (IsFinished)
                {
                    return false;
                }

                bool correct = saidScam == CurrentQuestion.IsCorrect;

                if (correct)
                {
                    score++;
                }

                return correct;
            }

            public void Next()
            {
                currentIndex++;
            }

            public void Restart()
            {
                currentIndex = 0;
                score = 0;
            }
        }
    }
}
