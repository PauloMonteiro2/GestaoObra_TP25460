using GestaoObra_TP25460.Funcionario;
using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class LandPage : Form
    {
        private GestaoViaturas gestaoViaturas;

        public LandPage()
        {
            InitializeComponent();
            gestaoViaturas = new GestaoViaturas();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            var form = new AddFuncionario();
            form.Show();
        }

        private void btnAddObra_Click(object sender, EventArgs e)
        {
            var form = new AddObraForm();
            form.Show();
        }

        private void btnAddViatura_Click(object sender, EventArgs e)
        {
            var form = new AddViaturaForm();
            form.Show();
        }

        private void BtnAddFuncionario_Click(object sender, EventArgs e)
        {
            var form = new AddFuncionario();
            form.Show();
        }

       

       

 
    }
}
