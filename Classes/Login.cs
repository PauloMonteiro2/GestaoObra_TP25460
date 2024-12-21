using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoObra_TP25460.Classes
{
    public class Login
    {
        #region Propriedades
        // Caminho absoluto para o arquivo de usuários
        private static string CaminhoArquivoUsuarios => Path.Combine("C:\\GestaoObra_TP25460\\Data", "usuarios.txt");

        // Email do usuário
        public string Email { get; set; }

        // Senha do usuário
        public string Password { get; set; }
        #endregion

        #region Construtor
        // Construtor para inicializar as credenciais
        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }
        #endregion

        #region Métodos para Validação e Registro
        /// <summary>
        /// Valida as credenciais do usuário comparando com os dados armazenados.
        /// </summary>
        /// <returns>True se as credenciais forem válidas, caso contrário, False.</returns>
        public bool ValidarCredenciais()
        {
            // Verifica se o arquivo de usuários existe
            if (!File.Exists(CaminhoArquivoUsuarios))
            {
                throw new FileNotFoundException("O arquivo de usuários não foi encontrado.");
            }

            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(CaminhoArquivoUsuarios);
            foreach (var linha in linhas)
            {
                var partes = linha.Split(';'); // Divide a linha com base no separador ';'
                if (partes.Length == 2)
                {
                    string emailArmazenado = partes[0];
                    string passwordArmazenada = partes[1];

                    // Verifica se o email e a senha correspondem
                    if (Email.Equals(emailArmazenado, StringComparison.OrdinalIgnoreCase) &&
                        Password == passwordArmazenada)
                    {
                        return true; // Credenciais válidas
                    }
                }
            }

            return false; // Credenciais inválidas
        }

        /// <summary>
        /// Registra um novo usuário no arquivo de usuários.
        /// </summary>
        /// <param name="email">Email do novo usuário.</param>
        /// <param name="password">Senha do novo usuário.</param>
        public static void RegistrarUsuario(string email, string password)
        {
            // Cria o arquivo caso ele não exista
            if (!File.Exists(CaminhoArquivoUsuarios))
            {
                File.Create(CaminhoArquivoUsuarios).Close();
            }

            // Adiciona o novo usuário ao arquivo
            File.AppendAllText(CaminhoArquivoUsuarios, $"{email};{password}{Environment.NewLine}");
        }
        #endregion
    }
}