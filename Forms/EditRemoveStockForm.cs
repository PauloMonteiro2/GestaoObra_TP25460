using System;
using System.Windows.Forms;
using GestaoObra_TP25460;


namespace GestaoObra
{
    public partial class EditRemoveStockForm : Form
    {
        private Armazem armazem;

        public EditRemoveStockForm(Armazem armazem)
        {
            InitializeComponent();
            this.armazem = armazem;
            AtualizarListaMateriais();
        }

        private void AtualizarListaMateriais()
        {
            comboBoxMateriais.Items.Clear();
            foreach (var material in armazem.Stock)
            {
                int v = comboBoxMateriais.Items.Add(material.Nome);
            }
        }

        private void BotaoGuardar_Click(object sender, EventArgs e)
        {
            string nomeMaterial = comboBoxMateriais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nomeMaterial))
            {
                MessageBox.Show("Selecione um material.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantidadeNova = (int)numericUpDownQuantidade.Value;
            armazem.AdicionarMaterial(nomeMaterial, quantidadeNova);
            MessageBox.Show("Quantidade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BotaoRemover_Click(object sender, EventArgs e)
        {
            string nomeMaterial = comboBoxMateriais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nomeMaterial))
            {
                MessageBox.Show("Selecione um material.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantidadeRemover = (int)numericUpDownQuantidade.Value;
            bool sucesso = armazem.RemoverMaterial(nomeMaterial, quantidadeRemover);

            if (sucesso)
            {
                MessageBox.Show("Material removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao remover material. Verifique a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
