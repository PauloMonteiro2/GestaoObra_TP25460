using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoObra_TP25460.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
        public Tipo TipoCargo { get; set; }

        private static string CaminhoArquivo => Path.Combine("C:\\GestaoObra_TP25460\\Funcionarios.txt");

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

        public override string ToString()
        {
            return $"{Id};{Nome};{Morada};{Password};{Email};{Salario};{TipoCargo.Id}";
        }
    }
}
