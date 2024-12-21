using System;
using System.Collections.Generic;

namespace GestaoObra_TP25460.Classes
{
   

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
