using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class FormViaturas : Form
    {
        private GestaoViaturas gestaoViaturas;

        public FormViaturas(GestaoViaturas gestao)
        {
            InitializeComponent();
            gestaoViaturas = gestao;
            AtualizarListaViaturas();
        }

        private void AtualizarListaViaturas()
        {
            listViewViaturas.Items.Clear();

            foreach (var viatura in gestaoViaturas.Viaturas)
            {
                AdicionarViaturaNaLista(viatura);
            }
        }

        private void AdicionarViaturaNaLista(Viatura viatura)
        {
            ListViewItem item = new ListViewItem(viatura.Matricula);
            item.SubItems.Add(viatura.Marca);
            item.SubItems.Add(viatura.Modelo);
            item.SubItems.Add(viatura.Ano.ToString());
            item.SubItems.Add(viatura.Estado);
            listViewViaturas.Items.Add(item);
        }

        private void btnExibirViaturas_Click(object sender, EventArgs e)
        {
            AtualizarListaViaturas();
        }

        private void btnListarDisponiveis_Click(object sender, EventArgs e)
        {
            listViewViaturas.Items.Clear();

            var viaturasDisponiveis = gestaoViaturas.Viaturas.FindAll(v => v.Estado == "Disponível");
            foreach (var viatura in viaturasDisponiveis)
            {
                AdicionarViaturaNaLista(viatura);
            }
        }
    }
}