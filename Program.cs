using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    static class Program
    {
        #region Ponto de Entrada Principal
        /// <summary>
        /// Ponto de entrada principal para a aplica��o.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuais e configura��es padr�o de renderiza��o de texto
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o formul�rio de login
            var loginForm = new LoginForm();

            // Verifica se o login foi bem-sucedido antes de abrir a p�gina principal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new LandPage());
            }
        }
        #endregion
    }
}
