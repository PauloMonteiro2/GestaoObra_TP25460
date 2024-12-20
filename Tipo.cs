using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObra_TP25460
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        private static string CaminhoArquivo => Path.Combine("C:\\GestaoObra_TP25460\\Data\\Tipos.txt");

        public static List<Tipo> CarregarTipos()
        {
            var tipos = new List<Tipo>();
            if (File.Exists(CaminhoArquivo))
            {
                var linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (var linha in linhas)
                {
                    var partes = linha.Split(';');
                    tipos.Add(new Tipo { Id = int.Parse(partes[0]), Descricao = partes[1] });
                }
            }
            return tipos;
        }
    }
}
