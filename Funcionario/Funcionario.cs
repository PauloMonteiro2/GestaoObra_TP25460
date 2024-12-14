using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObra_TP25460.Funcionario
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

        private static string CaminhoArquivo => Path.Combine("C:\\GO_A25460_TP\\Funcionarios.txt");

        public static int ProximoId()
        {
            if (!File.Exists(CaminhoArquivo)) return 1;
            var linhas = File.ReadAllLines(CaminhoArquivo);
            return linhas.Length + 1;
        }

        public static void SalvarFuncionario(Funcionario funcionario)
        {
            var linha = $"{funcionario.Id};{funcionario.Nome};{funcionario.Morada};{funcionario.Password};{funcionario.Email};{funcionario.Salario};{funcionario.TipoCargo.Id}";
            File.AppendAllText(CaminhoArquivo, linha + Environment.NewLine);
        }
    }
}
