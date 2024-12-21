using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GestaoObra_TP25460.Classes
{
    public static class RepositorioFuncionarios
    {
        // Caminho absoluto do arquivo TXT
        private static readonly string caminhoArquivo = @"C:\GestaoObra_TP25460\Data\funcionarios.txt";

        /// <summary>
        /// Atualiza ou adiciona um funcionário no arquivo TXT.
        /// </summary>
        public static void Atualizar(Funcionario funcionario)
        {
            var funcionarios = CarregarTodos();
            var index = funcionarios.FindIndex(f => f.Id == funcionario.Id);

            if (index >= 0)
            {
                funcionarios[index] = funcionario;
            }
            else
            {
                funcionarios.Add(funcionario);
            }

            SalvarTodos(funcionarios);
        }

        /// <summary>
        /// Carrega todos os funcionários do arquivo TXT.
        /// </summary>
        public static List<Funcionario> CarregarTodos()
        {
            var funcionarios = new List<Funcionario>();

            if (!File.Exists(caminhoArquivo))
                return funcionarios;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var dados = linha.Split(';');
                if (dados.Length == 4)
                {
                    funcionarios.Add(new Funcionario
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Cargo = dados[2],
                        Salario = (double)decimal.Parse(dados[3])
                    });
                }
            }

            return funcionarios;
        }

        /// <summary>
        /// Salva todos os funcionários no arquivo TXT.
        /// </summary>
        private static void SalvarTodos(List<Funcionario> funcionarios)
        {
            var linhas = funcionarios.Select(f =>
                $"{f.Id};{f.Nome};{f.Cargo};{f.Salario}");

            File.WriteAllLines(caminhoArquivo, linhas);
        }

        /// <summary>
        /// Gera um novo ID incremental baseado nos IDs existentes.
        /// </summary>
        public static int GerarNovoId()
        {
            var funcionarios = CarregarTodos();
            return funcionarios.Count > 0 ? funcionarios.Max(f => f.Id) + 1 : 1;
        }
    }
}
