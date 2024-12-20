
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
        private System.Windows.Forms.Button btnFormViaturas;

        private void InitializeComponent()
        {
            btnAddFuncionario = new Button();
            btnAddObra = new Button();
            btnAddViatura = new Button();
            btnEditarFuncionario = new Button();
            btnFormViaturas = new Button();
            SuspendLayout();
            // 
            // btnAddFuncionario
            // 
            btnAddFuncionario.Location = new Point(50, 50);
            btnAddFuncionario.Name = "btnAddFuncionario";
            btnAddFuncionario.Size = new Size(200, 30);
            btnAddFuncionario.TabIndex = 0;
            btnAddFuncionario.Text = "Adicionar Funcionário";
            btnAddFuncionario.Click += btnAddFuncionario_Click;
            // 
            // btnAddObra
            // 
            btnAddObra.Location = new Point(50, 100);
            btnAddObra.Name = "btnAddObra";
            btnAddObra.Size = new Size(200, 30);
            btnAddObra.TabIndex = 1;
            btnAddObra.Text = "Adicionar Obra";
            btnAddObra.Click += btnAddObra_Click;
            // 
            // btnAddViatura
            // 
            btnAddViatura.Location = new Point(50, 150);
            btnAddViatura.Name = "btnAddViatura";
            btnAddViatura.Size = new Size(200, 30);
            btnAddViatura.TabIndex = 2;
            btnAddViatura.Text = "Adicionar Viatura";
            btnAddViatura.Click += btnAddViatura_Click;
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.Location = new Point(50, 200);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(200, 30);
            btnEditarFuncionario.TabIndex = 3;
            btnEditarFuncionario.Text = "Editar Funcionário";
            // 
            // btnFormViaturas
            // 
            btnFormViaturas.Location = new Point(50, 250);
            btnFormViaturas.Name = "btnFormViaturas";
            btnFormViaturas.Size = new Size(200, 30);
            btnFormViaturas.TabIndex = 4;
            btnFormViaturas.Text = "Gerir Viaturas";
            btnFormViaturas.Click += btnFormViaturas_Click;
            // 
            // LandPage
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddFuncionario);
            Controls.Add(btnAddObra);
            Controls.Add(btnAddViatura);
            Controls.Add(btnEditarFuncionario);
            Controls.Add(btnFormViaturas);
            Name = "LandPage";
            Text = "Gestão de Obras";
            Load += LandPage_Load_2;
            ResumeLayout(false);
        }

        private void btnFormViaturas_Click(object sender, EventArgs e)
        {
            var form = new FormViaturas();
            form.ShowDialog();
        }
    }
}
