using System;
using System.Windows.Forms;
using GestaoObra;
using GestaoObra_TP25460.Classes;
using GestaoObra_TP25460.Forms;
using GestaoObra_TP25460.Funcionario;


namespace GestaoObra_TP25460
{
    public partial class LandPage : Form
    {
        public LandPage()
        {
            InitializeComponent();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            var form = new AddFuncionario();
            form.ShowDialog();
        }

        private void btnAddObra_Click(object sender, EventArgs e)
        {
            var form = new AddObraForm();
            form.ShowDialog();
        }

        private void btnAddViatura_Click(object sender, EventArgs e)
        {
            var form = new AddViaturaForm();
            form.ShowDialog();
        }

        private void btnEditFuncionario_Click(object sender, EventArgs e)
        {
            int funcionarioId = ObterFuncionarioId();
            if (funcionarioId > 0)
            {
                var form = new EditFuncionarioForm(funcionarioId);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário válido para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFormViaturas_Click(object sender, EventArgs e)
        {
            var form = new FormViaturas();
            form.ShowDialog();
        }

        private void btnConsultaStock_Click(object sender, EventArgs e)
        {
            var armazem = new Armazem();
            var form = new ConsultaStockForm(armazem);
            form.ShowDialog();
        }

        private void btnEditarObra_Click(object sender, EventArgs e)
        {
            var obra = new Obra("Obra Exemplo", "Descrição Exemplo", 50000, DateTime.Now);
            var form = new EditarObraForm(obra);
            form.ShowDialog();
        }

        private void btnEditRemoveStock_Click(object sender, EventArgs e)
        {
            var armazem = new Armazem();
            var form = new EditRemoveStockForm(armazem);
            form.ShowDialog();
        }

        private int ObterFuncionarioId()
        {
            return 1;
        }

        private void LandPage_Load(object sender, EventArgs e)
        {
            // Qualquer inicialização adicional
        }

        private void LandPage_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
