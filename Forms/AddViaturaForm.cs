using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class AddViaturaForm : Form
    {
        public AddViaturaForm()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int ano = (int)numAno.Value;
            string estado = cmbEstado.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Implementar lógica para adicionar a viatura
            MessageBox.Show("Viatura adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
