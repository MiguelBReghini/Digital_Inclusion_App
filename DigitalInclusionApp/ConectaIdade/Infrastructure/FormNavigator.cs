using System;
using System.Threading;
using System.Windows.Forms;

namespace DigitalInclusionApp.Infrastructure
{
    /// <summary>
    /// Gerenciador centralizado de navegação entre formulários.
    /// Fornece métodos estáticos para abrir formulários em threads separadas.
    /// </summary>
    public static class FormNavigator
    {
        /// <summary>
        /// Abre um formulário em uma nova thread com configurações ApartmentState.
        /// </summary>
        /// <typeparam name="TForm">O tipo do formulário a ser aberto.</typeparam>
        public static void OpenForm<TForm>() where TForm : Form, new()
        {
            Thread thread = new Thread(() => Application.Run(new TForm()))
            {
                Name = typeof(TForm).Name
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        /// <summary>
        /// Abre um formulário em uma nova thread com configurações ApartmentState.
        /// </summary>
        /// <param name="formFactory">Função factory para criar a instância do formulário.</param>
        /// <typeparam name="TForm">O tipo do formulário a ser aberto.</typeparam>
        public static void OpenForm<TForm>(Func<TForm> formFactory) where TForm : Form
        {
            Thread thread = new Thread(() => Application.Run(formFactory()))
            {
                Name = typeof(TForm).Name
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        /// <summary>
        /// Fecha o formulário atual e abre um novo em uma thread separada.
        /// </summary>
        /// <param name="currentForm">O formulário atual a ser fechado.</param>
        /// <typeparam name="TForm">O tipo do formulário a ser aberto.</typeparam>
        public static void NavigateAndClose<TForm>(Form currentForm) where TForm : Form, new()
        {
            currentForm?.Close();
            OpenForm<TForm>();
        }

        /// <summary>
        /// Fecha o formulário atual e abre um novo em uma thread separada.
        /// </summary>
        /// <param name="currentForm">O formulário atual a ser fechado.</param>
        /// <param name="formFactory">Função factory para criar a instância do formulário.</param>
        /// <typeparam name="TForm">O tipo do formulário a ser aberto.</typeparam>
        public static void NavigateAndClose<TForm>(Form currentForm, Func<TForm> formFactory) where TForm : Form
        {
            currentForm?.Close();
            OpenForm(formFactory);
        }
    }
}
