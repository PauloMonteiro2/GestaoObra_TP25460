using GestaoObra_TP25460.Models;

namespace GestaoObra_TP25460.Forms
{
    public partial class EditFuncionarioForm : Form
    {
        private GestaoObra_TP25460.Models.Funcionario funcionarioAtual;

        public EditFuncionarioForm(GestaoObra_TP25460.Models.Funcionario funcionario)
        {
            InitializeComponent();
            funcionarioAtual = funcionario;
            PreencherDados(funcionario);
        }

        private void PreencherDados(GestaoObra_TP25460.Models.Funcionario funcionario)
        {
            txtId.Text = funcionario.Id.ToString();
            txtNome.Text = funcionario.Nome;
            txtCargo.Text = funcionario.Cargo;
            txtSalario.Text = funcionario.Salario.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionarioAtual.Nome = txtNome.Text;
                funcionarioAtual.Cargo = txtCargo.Text;
                funcionarioAtual.Salario = (double)decimal.Parse(txtSalario.Text);

                RepositorioFuncionarios.Atualizar(funcionarioAtual);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
