using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInclusionApp.Games
{
    internal class QuizQuestion
    {
        public string Text { get; set; } = "";
        public bool IsScam { get; set; }
        public string Explanation { get; set; } = "";
    }

    internal class ScamQuiz
    {
        List<QuizQuestion> questions = new List<QuizQuestion>
        {
           
            new QuizQuestion { Text = "WhatsApp de número novo: “Oi mãe, mudei de número, faz um PIX urgente?”", IsScam = true, Explanation = "Usuários mal intencionados podem se passar por pessoas próximas com a intenção de dar golpes utilizando a urgência como ferramenta, sempre confirme com seu familiar pelo número antigo confirmado pra ter certeza." },
            new QuizQuestion { Text = "Ligação de “funcionário do banco” pedindo seu cadastro no banco.", IsScam = true, Explanation = "É golpe. Banco nenhum liga para pedir dados de cadastro, senha ou o código que chegou por mensagem." },
            new QuizQuestion { Text = "Filho liga do número de sempre e combina um almoço no domingo", IsScam = false, Explanation = "Não é golpe. O número é o de sempre, a pessoa é conhecida e o assunto é um convite comum. Ninguém pediu dinheiro, senha ou código, e nada é urgente." },
            new QuizQuestion { Text = "Mensagem de “valores do INSS a receber” com um link pedindo CPF e dados do cartão", IsScam = true, Explanation = "É golpe. O INSS não manda link pedindo CPF ou dados do cartão. A promessa de dinheiro a receber serve para você clicar sem pensar. Não clique. Para conferir o seu benefício, use o aplicativo Meu INSS ou ligue para a Central 135." },
            new QuizQuestion { Text = "Neto manda mensagem no whatsapp em um número conhecido sem segundas intenções", IsScam = false, Explanation = "Não é golpe. A mensagem veio de um número que você conhece, de alguém da família, e não pede nada suspeito." },
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

            bool correct = saidScam == CurrentQuestion.IsScam;

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

