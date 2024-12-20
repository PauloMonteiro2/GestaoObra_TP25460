using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class EditarObraForm : Form
    {
        private Obra obra;

        public EditarObraForm(Obra obra)
        {
            InitializeComponent();
            this.obra = obra;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            txtNome.Text = obra.Nome;
            txtDescricao.Text = obra.Descricao;
            numOrcamento.Value = obra.Orcamento;
            numCustosTotais.Value = obra.CustosTotais;
            dtpDataInicio.Value = obra.DataInicio;

            if (obra.DataConclusao.HasValue)
            {
                dtpDataConclusao.Value = obra.DataConclusao.Value;
                dtpDataConclusao.Checked = true;
            }
            else
            {
                dtpDataConclusao.Checked = false;
            }

            cmbEstado.SelectedItem = obra.Estado;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            obra.Nome = txtNome.Text;
            obra.Descricao = txtDescricao.Text;
            obra.DataInicio = dtpDataInicio.Value;
            obra.DataConclusao = dtpDataConclusao.Checked ? dtpDataConclusao.Value : (DateTime?)null;
            obra.AtualizarEstado(cmbEstado.SelectedItem.ToString());

            MessageBox.Show("Obra atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
