
namespace GestaoObra_TP25460
{
    internal class EditarFuncionarioForm
    {
        private int funcionarioId;

        public EditarFuncionarioForm(int funcionarioId)
        {
            this.funcionarioId = funcionarioId;
        }

        internal void ShowDialog()
        {
            MessageBox.Show("Método ShowDialog chamado!");
        }
    }
}