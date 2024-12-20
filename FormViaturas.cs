using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


namespace GestaoObra_TP25460
{
    public partial class FormViaturas : Form
    {
        public GestaoViaturas gestaoViaturas;

        public object viaturas { get; private set; }

        public FormViaturas(GestaoViaturas gestao)
        {
            InitializeComponent();
            gestaoViaturas = gestao;
            AtualizarListaViaturas();
        }

        public FormViaturas()
        {
        }

        public void AtualizarListaViaturas()
        {
            listViewViaturas.Items.Clear();

            foreach (var viatura in gestaoViaturas.Viaturas)
            {
                AdicionarViaturaNaLista(viatura);
            }
        }

        public void AdicionarViaturaNaLista(Viatura viatura)
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

        public void btnListarDisponiveis_Click(object sender, EventArgs e)
        {
            btnListarDisponiveis_Click(sender, e, viaturas);
        }

        public void btnListarDisponiveis_Click(object sender, EventArgs e, object viaturas)
        {
            listViewViaturas.Items.Clear();

            // Certifique-se de que viaturas está corretamente tipada
            var listaViaturas = ((IEnumerable<Viatura>)viaturas).ToList();

            var resultado = listaViaturas.FindAll(v => v.Estado == "Disponível");

            foreach (var viatura in resultado)
            {
                AdicionarViaturaNaLista(viatura);
            }
        }

        private void FormViaturas_Load(object sender, EventArgs e)
        {

        }
    }
}