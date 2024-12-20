using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObra_TP25460
{
    public class Obra
    {
        #region Propriedades da Obra
        // Propriedades da obra
        public string Nome { get; set; } // Nome da obra
        public string Descricao { get; set; } // Descrição detalhada da obra
        public decimal Orcamento { get; private set; } // Orçamento inicial da obra
        public decimal CustosTotais { get; private set; } // Custos totais acumulados
        public DateTime DataInicio { get; set; } // Data de início da obra
        public DateTime? DataConclusao { get; set; } // Data de conclusão da obra (opcional)
        public string Estado { get; private set; } // Estado atual da obra (ex: "Em andamento")
        #endregion

        #region Caminho do Arquivo
        private static readonly string CaminhoArquivo = Path.Combine("C:\\GestaoObra_TP25460\\Data\\Obra.txt");
        #endregion

        #region Construtor
        // Construtor para inicializar a obra
        public Obra(string nome, string descricao, decimal orcamento, DateTime dataInicio)
        {
            Nome = nome;
            Descricao = descricao;
            Orcamento = orcamento;
            DataInicio = dataInicio;
            CustosTotais = 0;
            Estado = "Em andamento";
        }
        #endregion

        #region Métodos para Manipulação de Custos e Estado
        // Método para adicionar um custo à obra
        public void AdicionarCusto(decimal custo)
        {
            if (custo < 0)
            {
                Console.WriteLine("Custo inválido. Insira um valor positivo.");
                return;
            }

            CustosTotais += custo;
            Console.WriteLine($"Custo de {custo:C} adicionado. Custos totais agora: {CustosTotais:C}");
        }

        // Método para atualizar o estado da obra
        public void AtualizarEstado(string novoEstado)
        {
            Estado = novoEstado;
            Console.WriteLine($"Estado da obra atualizado para: {novoEstado}");
        }

        // Método para verificar o orçamento restante
        public decimal VerificarOrcamentoRestante()
        {
            decimal orcamentoRestante = Orcamento - CustosTotais;
            Console.WriteLine($"Orçamento restante: {orcamentoRestante:C}");
            return orcamentoRestante;
        }
        #endregion

        #region Métodos para Exibição de Informações
        // Método para exibir todas as informações da obra
        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações da Obra:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Orçamento: {Orcamento:C}");
            Console.WriteLine($"Custos Totais: {CustosTotais:C}");
            Console.WriteLine($"Orçamento Restante: {VerificarOrcamentoRestante():C}");
            Console.WriteLine($"Data de Início: {DataInicio.ToShortDateString()}");
            Console.WriteLine($"Data de Conclusão: {(DataConclusao.HasValue ? DataConclusao.Value.ToShortDateString() : "Não definida")}");
            Console.WriteLine($"Estado: {Estado}");
        }
        #endregion

        #region Métodos de Persistência em Arquivo
        // Método para salvar a obra no arquivo TXT
        public void SalvarObra()
        {
            string linha = $"{Nome}|{Descricao}|{Orcamento}|{CustosTotais}|{DataInicio:yyyy-MM-dd}|{(DataConclusao.HasValue ? DataConclusao.Value.ToString("yyyy-MM-dd") : "null")}|{Estado}";
            File.AppendAllText(CaminhoArquivo, linha + Environment.NewLine);
            Console.WriteLine("Obra salva com sucesso no arquivo TXT.");
        }

        // Método para carregar todas as obras do arquivo TXT
        public static List<Obra> CarregarObras()
        {
            List<Obra> obras = new List<Obra>();

            if (File.Exists(CaminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split('|');
                    if (partes.Length == 7)
                    {
                        string nome = partes[0];
                        string descricao = partes[1];
                        decimal orcamento = decimal.Parse(partes[2]);
                        decimal custosTotais = decimal.Parse(partes[3]);
                        DateTime dataInicio = DateTime.Parse(partes[4]);
                        DateTime? dataConclusao = partes[5] != "null" ? DateTime.Parse(partes[5]) : null;
                        string estado = partes[6];

                        Obra obra = new Obra(nome, descricao, orcamento, dataInicio)
                        {
                            CustosTotais = custosTotais,
                            DataConclusao = dataConclusao,
                            Estado = estado
                        };

                        obras.Add(obra);
                    }
                }
            }

            return obras;
        }
        #endregion
    }
}