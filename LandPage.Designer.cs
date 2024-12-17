
using GestaoObra_TP25460.Forms;

namespace GestaoObra_TP25460
{
    partial class LandPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.Button btnAddObra;
        private System.Windows.Forms.Button btnAddViatura;
        private System.Windows.Forms.Button btnEditarFuncionario;

        private void InitializeComponent()
        {
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.btnAddObra = new System.Windows.Forms.Button();
            this.btnAddViatura = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Configuração do botão Adicionar Funcionário
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Text = "Adicionar Funcionário";
            this.btnAddFuncionario.Location = new System.Drawing.Point(50, 50);
            this.btnAddFuncionario.Size = new System.Drawing.Size(200, 30);
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);

            // Configuração do botão Adicionar Obra
            this.btnAddObra.Name = "btnAddObra";
            this.btnAddObra.Text = "Adicionar Obra";
            this.btnAddObra.Location = new System.Drawing.Point(50, 100);
            this.btnAddObra.Size = new System.Drawing.Size(200, 30);
            this.btnAddObra.Click += new System.EventHandler(this.btnAddObra_Click);

            // Configuração do botão Adicionar Viatura
            this.btnAddViatura.Name = "btnAddViatura";
            this.btnAddViatura.Text = "Adicionar Viatura";
            this.btnAddViatura.Location = new System.Drawing.Point(50, 150);
            this.btnAddViatura.Size = new System.Drawing.Size(200, 30);
            this.btnAddViatura.Click += new System.EventHandler(this.btnAddViatura_Click);

            // Configuração do botão Editar Funcionário
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Text = "Editar Funcionário";
            this.btnEditarFuncionario.Location = new System.Drawing.Point(50, 200);
            this.btnEditarFuncionario.Size = new System.Drawing.Size(200, 30);
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);

            // Configuração do formulário
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFuncionario);
            this.Controls.Add(this.btnAddObra);
            this.Controls.Add(this.btnAddViatura);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Text = "Gestão de Obras";
            this.ResumeLayout(false);
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            int funcionarioId = GetFuncionarioID();
            if (funcionarioId >= 0)
            {
                var form = new EditarFuncionarioForm(funcionarioId);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione ou insira um ID válido para editar.");
            }
        }

        private int GetFuncionarioID()
        {
            return 1; // Retorna um ID fictício
        }
    }
}
