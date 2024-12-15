using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoObra_TP25460
{
    public class Login
    {
        private static string CaminhoArquivoUsuarios => Path.Combine("C:\\GestaoObra_TP25460\\Data", "usuarios.txt");

        public string Email { get; set; }
        public string Password { get; set; }

        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }

        // Método para validar credenciais
        public bool ValidarCredenciais()
        {
            if (!File.Exists(CaminhoArquivoUsuarios))
            {
                throw new FileNotFoundException("O arquivo de usuários não foi encontrado.");
            }

            var linhas = File.ReadAllLines(CaminhoArquivoUsuarios);
            foreach (var linha in linhas)
            {
                var partes = linha.Split(';');
                if (partes.Length == 2)
                {
                    string emailArmazenado = partes[0];
                    string passwordArmazenada = partes[1];

                    if (Email.Equals(emailArmazenado, StringComparison.OrdinalIgnoreCase) &&
                        Password == passwordArmazenada)
                    {
                        return true; // Credenciais válidas
                    }
                }
            }

            return false; // Credenciais inválidas
        }

        // Método para registrar um novo usuário (opcional)
        public static void RegistrarUsuario(string email, string password)
        {
            if (!File.Exists(CaminhoArquivoUsuarios))
            {
                File.Create(CaminhoArquivoUsuarios).Close();
            }

            File.AppendAllText(CaminhoArquivoUsuarios, $"{email};{password}{Environment.NewLine}");
        }
    }
}
