using GestaoObra_TP25460.Classes;
using System;
using System.Collections.Generic;

public class Armazem
{
    #region Atributos
    // Lista que armazena os materiais no armazém
    private List<Material> stock;
    #endregion

    #region Construtor
    // Construtor que inicializa a lista de materiais
    public Armazem()
    {
        stock = new List<Material>();
    }
    #endregion

    #region Métodos para Gestão de Materiais
    // Função para adicionar material ao armazém
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
            Console.WriteLine($"{nome} adicionado ao armazém com {quantidade} unidades.");
        }
    }

    // Função para remover material do armazém
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
    #endregion
}
