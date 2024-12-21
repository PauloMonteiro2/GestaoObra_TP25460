using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoObra_TP25460.Classes
{
    // Classe para gerenciar as viaturas
    public class GestaoViaturas
    {
        #region Atributos
        // Lista de viaturas gerenciada pela classe
        private List<Viatura> viaturas;
        #endregion

        #region Construtor
        // Construtor que inicializa a lista de viaturas
        public GestaoViaturas()
        {
            viaturas = new List<Viatura>();
        }
        #endregion

        #region Propriedades
        // Propriedade para acessar as viaturas (apenas leitura)
        public IReadOnlyList<Viatura> Viaturas => viaturas.AsReadOnly();
        #endregion

        #region Métodos para Gestão de Viaturas
        // Método para adicionar uma viatura
        public void AdicionarViatura(Viatura viatura)
        {
            if (viatura == null)
                throw new ArgumentNullException(nameof(viatura));

            if (viaturas.Any(v => v.Matricula == viatura.Matricula))
            {
                Console.WriteLine($"Uma viatura com a matrícula {viatura.Matricula} já existe.");
                return;
            }

            viaturas.Add(viatura);
            Console.WriteLine($"Viatura {viatura.Matricula} adicionada com sucesso.");
        }

        // Método para remover uma viatura pela matrícula
        public bool RemoverViatura(string matricula)
        {
            Viatura viatura = viaturas.FirstOrDefault(v => v.Matricula == matricula);
            if (viatura != null)
            {
                viaturas.Remove(viatura);
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
        public Viatura ConsultarViatura(string matricula)
        {
            Viatura viatura = viaturas.FirstOrDefault(v => v.Matricula == matricula);
            if (viatura != null)
            {
                Console.WriteLine("Informações da Viatura:");
                viatura.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine($"Viatura com matrícula {matricula} não encontrada.");
            }
            return viatura;
        }

        // Método para exibir todas as viaturas
        public void ExibirViaturas()
        {
            if (!viaturas.Any())
            {
                Console.WriteLine("Não há viaturas cadastradas.");
                return;
            }

            Console.WriteLine("Lista de Viaturas:");
            foreach (var viatura in viaturas)
            {
                viatura.ExibirInformacoes();
                Console.WriteLine("------------------------");
            }
        }

        // Método para atualizar o estado de uma viatura pela matrícula
        public bool AtualizarEstadoViatura(string matricula, string novoEstado)
        {
            Viatura viatura = viaturas.FirstOrDefault(v => v.Matricula == matricula);
            if (viatura != null)
            {
                viatura.AtualizarEstado(novoEstado);
                return true;
            }
            else
            {
                Console.WriteLine($"Viatura com matrícula {matricula} não encontrada.");
                return false;
            }
        }
        #endregion
    }
}
