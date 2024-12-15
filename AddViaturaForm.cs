using System;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class AddViaturaForm : Form
    {
        private GestaoViaturas gestaoViaturas;

        public AddViaturaForm(GestaoViaturas gestao)
        {
            InitializeComponent();
            gestaoViaturas = gestao;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = txtMatricula.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int ano = (int)numAno.Value;
                string estado = cmbEstado.SelectedItem.ToString();

                if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var novaViatura = new Viatura(matricula, marca, modelo, ano, estado);
                gestaoViaturas.AdicionarViatura(novaViatura);

                MessageBox.Show("Viatura adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar a viatura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparFormulario()
        {
            txtMatricula.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            numAno.Value = DateTime.Now.Year;
            cmbEstado.SelectedIndex = 0;
        }
    }
}
