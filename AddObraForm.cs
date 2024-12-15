using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class AddObraForm : Form
    {
        private Obra obra;

        public AddObraForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string descricao = txtDescricao.Text;
                decimal orcamento = Convert.ToDecimal(txtOrcamento.Text);
                DateTime dataInicio = dtpDataInicio.Value;

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                obra = new Obra(nome, descricao, orcamento, dataInicio);
                MessageBox.Show("Obra salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a obra: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtOrcamento.Clear();
            dtpDataInicio.Value = DateTime.Now;
        }
    }
}
