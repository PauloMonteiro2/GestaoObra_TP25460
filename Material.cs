using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObra_TP25460
{
    // Classe para representar um Material no Armazém
    public class Material
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Material(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }

}