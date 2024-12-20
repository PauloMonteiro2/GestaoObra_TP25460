using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoObra_TP25460
{
    public class Viatura
    {
        #region Propriedades da Viatura
        // Propriedades da viatura
        public string Matricula { get; set; } // Matrícula da viatura
        public string Marca { get; set; } // Marca da viatura
        public string Modelo { get; set; } // Modelo da viatura
        public int Ano { get; set; } // Ano de fabricação da viatura
        public string Estado { get; private set; } // Estado atual da viatura (ex: "Disponível")
        #endregion

        #region Caminho do Arquivo
        private static readonly string CaminhoArquivo = Path.Combine("C:\\GestaoObra_TP25460\\Data\\Viaturas.txt");
        #endregion

        #region Lista de Viaturas
        // Lista de viaturas gerenciada pela classe
        private static List<Viatura> Viaturas = new List<Viatura>();
        #endregion

        #region Construtor
        // Construtor com parâmetros obrigatórios
        public Viatura(string matricula, string marca, string modelo, int ano, string estadoInicial = "Disponível")
        {
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            Ano = ano;
            Estado = estadoInicial ?? "Disponível";
        }
        #endregion

        #region Métodos para Manipulação do Estado
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
        #endregion

        #region Métodos para Gerenciar a Lista de Viaturas
        // Método para adicionar uma viatura à lista e salvar no arquivo
        public static void AdicionarViatura(Viatura viatura)
        {
            Viaturas.Add(viatura);
            SalvarViatura(viatura);
            Console.WriteLine($"Viatura {viatura.Matricula} adicionada com sucesso.");
        }

        // Método para remover uma viatura pela matrícula
        public static bool RemoverViatura(string matricula)
        {
            Viatura viatura = Viaturas.Find(v => v.Matricula == matricula);
            if (viatura != null)
            {
                Viaturas.Remove(viatura);
                SalvarTodasViaturas();
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
        #endregion

        #region Métodos de Persistência em Arquivo
        // Método para salvar uma única viatura no arquivo
        private static void SalvarViatura(Viatura viatura)
        {
            string linha = $"{viatura.Matricula}|{viatura.Marca}|{viatura.Modelo}|{viatura.Ano}|{viatura.Estado}";
            File.AppendAllText(CaminhoArquivo, linha + Environment.NewLine);
        }

        // Método para salvar todas as viaturas no arquivo
        private static void SalvarTodasViaturas()
        {
            List<string> linhas = new List<string>();
            foreach (var viatura in Viaturas)
            {
                linhas.Add($"{viatura.Matricula}|{viatura.Marca}|{viatura.Modelo}|{viatura.Ano}|{viatura.Estado}");
            }
            File.WriteAllLines(CaminhoArquivo, linhas);
        }

        // Método para carregar todas as viaturas do arquivo
        public static void CarregarViaturas()
        {
            Viaturas.Clear();

            if (File.Exists(CaminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split('|');
                    if (partes.Length == 5)
                    {
                        Viatura viatura = new Viatura(partes[0], partes[1], partes[2], int.Parse(partes[3]), partes[4]);
                        Viaturas.Add(viatura);
                    }
                }
            }
        }
        #endregion
    }
}
