using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObra_TP25460
{
    public class Tipo
    {
        #region Propriedades
        // Identificador único do tipo
        public int Id { get; set; }

        // Descrição do tipo
        public string Descricao { get; set; }

        // Caminho absoluto para o arquivo que armazena os tipos
        private static string CaminhoArquivo => Path.Combine("C:\\GestaoObra_TP25460\\Data\\Tipos.txt");
        #endregion

        #region Métodos de Persistência
        // Método para carregar os tipos a partir de um arquivo
        public static List<Tipo> CarregarTipos()
        {
            var tipos = new List<Tipo>();

            // Verifica se o arquivo existe antes de tentar ler
            if (File.Exists(CaminhoArquivo))
            {
                var linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (var linha in linhas)
                {
                    var partes = linha.Split(';'); // Divide a linha em partes com base no separador ';'
                    tipos.Add(new Tipo
                    {
                        Id = int.Parse(partes[0]), // Conversão do ID para inteiro
                        Descricao = partes[1] // Descrição do tipo
                    });
                }
            }

            return tipos;
        }
        #endregion
    }
}
