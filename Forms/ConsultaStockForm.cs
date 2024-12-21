using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class ConsultaStockForm : Form
    {
        private Armazem armazem;

        public ConsultaStockForm(Armazem armazem)
        {
            InitializeComponent();
            this.armazem = armazem;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string nomeMaterial = txtNomeMaterial.Text.Trim();

            if (string.IsNullOrEmpty(nomeMaterial))
            {
                MessageBox.Show("Por favor, insira o nome do material.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var quantidade = armazem.ConsultarMaterial(nomeMaterial);

            lstEstoque.Items.Clear();

            if (quantidade > 0)
            {
                ListViewItem item = new ListViewItem(new[] { nomeMaterial, quantidade.ToString() });
                lstEstoque.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Material não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
