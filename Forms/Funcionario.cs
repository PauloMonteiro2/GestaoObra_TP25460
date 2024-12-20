using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoObra_TP25460.Models
{
    public class Funcionario
    {
        #region Propriedades
        public int Id { get; set; } // Identificador único do funcionário
        public string Nome { get; set; } // Nome completo do funcionário
        public string Morada { get; set; } // Endereço residencial do funcionário
        public string Password { get; set; } // Senha de acesso do funcionário
        public string Email { get; set; } // Email de contato do funcionário
        public double Salario { get; set; } // Salário mensal do funcionário
        public Tipo TipoCargo { get; set; } // Tipo de cargo associado ao funcionário
        public string Cargo { get; set; } // Descrição do cargo

        // Caminho absoluto para o arquivo que armazena os funcionários
        private static string CaminhoArquivo => Path.Combine("C:\\GestaoObra_TP25460\\Data\\Funcionarios.txt");
        #endregion

        #region Métodos de Persistência
        /// <summary>
        /// Carrega todos os funcionários a partir do arquivo de texto.
        /// </summary>
        /// <returns>Lista de funcionários carregados.</returns>
        public static List<Funcionario> CarregarFuncionarios()
        {
            var funcionarios = new List<Funcionario>();

            if (File.Exists(CaminhoArquivo))
            {
                foreach (var linha in File.ReadAllLines(CaminhoArquivo))
                {
                    var partes = linha.Split(';');
                    if (partes.Length == 7)
                    {
                        funcionarios.Add(new Funcionario
                        {
                            Id = int.Parse(partes[0]),
                            Nome = partes[1],
                            Morada = partes[2],
                            Password = partes[3],
                            Email = partes[4],
                            Salario = double.Parse(partes[5]),
                            TipoCargo = new Tipo { Id = int.Parse(partes[6]) }
                        });
                    }
                }
            }

            return funcionarios;
        }
        #endregion

        #region Métodos de Representação
        /// <summary>
        /// Representação em formato de texto do funcionário.
        /// </summary>
        /// <returns>String formatada para armazenamento.</returns>
        public override string ToString()
        {
            return $"{Id};{Nome};{Morada};{Password};{Email};{Salario};{TipoCargo.Id}";
        }
        #endregion
    }
}
