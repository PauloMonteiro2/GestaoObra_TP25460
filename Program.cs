using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    static class Program
    {
        #region Ponto de Entrada Principal
        /// <summary>
        /// Ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuais e configurações padrão de renderização de texto
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o formulário de login
            var loginForm = new LoginForm();

            // Verifica se o login foi bem-sucedido antes de abrir a página principal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new LandPage());
            }
        }
        #endregion
    }
}
