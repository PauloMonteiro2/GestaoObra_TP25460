using System;
using System.Collections.Generic;

namespace GestaoObra_TP25460
{
    // Classe para representar uma viatura e gerenciar a lista de viaturas
    public class Viatura
    {
        // Propriedades da viatura
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Estado { get; private set; }

        // Lista de viaturas gerenciada pela classe
        private static List<Viatura> Viaturas = new List<Viatura>();

        // Construtor com parâmetros obrigatórios
        public Viatura(string matricula, string marca, string modelo, int ano, string estadoInicial = "Disponível")
        {
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            Ano = ano;
            Estado = estadoInicial ?? "Disponível";
        }

        // Método para atualizar o estado da viatura
        public void AtualizarEstado(string novoEstado)
        {
            Estado = novoEstado;
            Console.WriteLine($"Estado da viatura {Matricula} atualizado para: {novoEstado}");
        }

        // Método para exibir as informações da viatura
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Estado: {Estado}");
        }

        // Método para adicionar uma viatura à lista
        public static void AdicionarViatura(Viatura viatura)
        {
            Viaturas.Add(viatura);
            Console.WriteLine($"Viatura {viatura.Matricula} adicionada com sucesso.");
        }

        // Método para remover uma viatura pela matrícula
        public static bool RemoverViatura(string matricula)
        {
            Viatura viatura = Viaturas.Find(v => v.Matricula == matricula);
            if (viatura != null)
            {
                Viaturas.Remove(viatura);
                Console.WriteLine($"Viatura {matricula} removida com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine($"Viatura com matrícula {matricula} não encontrada.");
                return false;
            }
        }

        // Método para consultar uma viatura específica pela matrícula
        public static void ConsultarViatura(string matricula)
        {
            Viatura viatura = Viaturas.Find(v => v.Matricula == matricula);
            if (viatura != null)
            {
                Console.WriteLine("Informações da Viatura:");
                viatura.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine($"Viatura com matrícula {matricula} não encontrada.");
            }
        }

        // Método para exibir todas as viaturas
        public static void ExibirViaturas()
        {
            Console.WriteLine("Lista de Viaturas:");
            foreach (var viatura in Viaturas)
            {
                viatura.ExibirInformacoes();
                Console.WriteLine("------------------------");
            }
        }
    }
}
