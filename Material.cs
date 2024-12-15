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

    // Classe para gerir o Armazem e o stock de materiais
    public class Armazem
    {
        private List<Material> stock;

        public Armazem()
        {
            stock = new List<Material>();
        }

        // Função para adicionar material ao armazem
        public void AdicionarMaterial(string nome, int quantidade)
        {
            Material materialExistente = stock.Find(m => m.Nome == nome);

            if (materialExistente != null)
            {
                materialExistente.Quantidade += quantidade;
                Console.WriteLine($"{quantidade} unidades de {nome} adicionadas. Quantidade total: {materialExistente.Quantidade}");
            }
            else
            {
                stock.Add(new Material(nome, quantidade));
                Console.WriteLine($"{nome} adicionado ao armazem com {quantidade} unidades.");
            }
        }

        // Função para remover material do armazem
        public bool RemoverMaterial(string nome, int quantidade)
        {
            Material materialExistente = stock.Find(m => m.Nome == nome);

            if (materialExistente != null && materialExistente.Quantidade >= quantidade)
            {
                materialExistente.Quantidade -= quantidade;
                Console.WriteLine($"{quantidade} unidades de {nome} removidas. Quantidade restante: {materialExistente.Quantidade}");
                return true;
            }
            else
            {
                Console.WriteLine($"Material {nome} não encontrado ou quantidade insuficiente.");
                return false;
            }
        }

        // Função para consultar a quantidade de um material específico
        public int ConsultarMaterial(string nome)
        {
            Material materialExistente = stock.Find(m => m.Nome == nome);

            if (materialExistente != null)
            {
                Console.WriteLine($"Quantidade de {nome}: {materialExistente.Quantidade}");
                return materialExistente.Quantidade;
            }
            else
            {
                Console.WriteLine($"Material {nome} não encontrado.");
                return 0;
            }
        }

        // Função para exibir o stock atual
        public void ExibirEstoque()
        {
            Console.WriteLine("Stock Atual:");
            foreach (var material in stock)
            {
                Console.WriteLine($"{material.Nome}: {material.Quantidade} unidades");
            }
        }
    }
}