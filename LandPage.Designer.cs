using GestaoObra_TP25460.Forms;

namespace GestaoObra_TP25460
{
    partial class LandPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddObra;
        private System.Windows.Forms.Button btnAddTipo;
        private System.Windows.Forms.Button btnAddViatura;
        private System.Windows.Forms.Button btnEditFuncionario;
        private System.Windows.Forms.Button btnFormViaturas;
        private System.Windows.Forms.Button btnConsultaStock;
        private System.Windows.Forms.Button btnEditarObra;
        private System.Windows.Forms.Button btnEditarFuncionario;

        private void InitializeComponent()
        {
            btnAddObra = new System.Windows.Forms.Button();
            btnAddTipo = new System.Windows.Forms.Button();
            btnAddViatura = new System.Windows.Forms.Button();
            btnEditFuncionario = new System.Windows.Forms.Button();
            btnFormViaturas = new System.Windows.Forms.Button();
            btnConsultaStock = new System.Windows.Forms.Button();
            btnEditarObra = new System.Windows.Forms.Button();
            btnEditarFuncionario = new System.Windows.Forms.Button();

            SuspendLayout();

            // btnAddObra
            btnAddObra.Location = new System.Drawing.Point(50, 50);
            btnAddObra.Name = "btnAddObra";
            btnAddObra.Size = new System.Drawing.Size(200, 30);
            btnAddObra.Text = "Adicionar Obra";
            btnAddObra.Click += btnAddObra_Click;

            // btnAddTipo
            btnAddTipo.Location = new System.Drawing.Point(50, 90);
            btnAddTipo.Name = "btnAddTipo";
            btnAddTipo.Size = new System.Drawing.Size(200, 30);
            btnAddTipo.Text = "Adicionar Tipo";
           

            // btnAddViatura
            btnAddViatura.Location = new System.Drawing.Point(50, 130);
            btnAddViatura.Name = "btnAddViatura";
            btnAddViatura.Size = new System.Drawing.Size(200, 30);
            btnAddViatura.Text = "Adicionar Viatura";
            btnAddViatura.Click += btnAddViatura_Click;

            // btnEditFuncionario
            btnEditFuncionario.Location = new System.Drawing.Point(50, 170);
            btnEditFuncionario.Name = "btnEditFuncionario";
            btnEditFuncionario.Size = new System.Drawing.Size(200, 30);
            btnEditFuncionario.Text = "Editar Funcionário";
            btnEditFuncionario.Click += btnEditFuncionario_Click;

            // btnFormViaturas
            btnFormViaturas.Location = new System.Drawing.Point(50, 210);
            btnFormViaturas.Name = "btnFormViaturas";
            btnFormViaturas.Size = new System.Drawing.Size(200, 30);
            btnFormViaturas.Text = "Gerir Viaturas";
            btnFormViaturas.Click += btnFormViaturas_Click;

            // btnConsultaStock
            btnConsultaStock.Location = new System.Drawing.Point(50, 250);
            btnConsultaStock.Name = "btnConsultaStock";
            btnConsultaStock.Size = new System.Drawing.Size(200, 30);
            btnConsultaStock.Text = "Consultar Stock";
            btnConsultaStock.Click += btnConsultaStock_Click;

            // btnEditarObra
            btnEditarObra.Location = new System.Drawing.Point(50, 290);
            btnEditarObra.Name = "btnEditarObra";
            btnEditarObra.Size = new System.Drawing.Size(200, 30);
            btnEditarObra.Text = "Editar Obra";
            btnEditarObra.Click += btnEditarObra_Click;

            // btnEditarFuncionario
            btnEditarFuncionario.Location = new System.Drawing.Point(50, 330);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new System.Drawing.Size(200, 30);
            btnEditarFuncionario.Text = "Editar Funcionário";
            

            // LandPage
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAddObra);
            Controls.Add(btnAddTipo);
            Controls.Add(btnAddViatura);
            Controls.Add(btnEditFuncionario);
            Controls.Add(btnFormViaturas);
            Controls.Add(btnConsultaStock);
            Controls.Add(btnEditarObra);
            Controls.Add(btnEditarFuncionario);
            Name = "LandPage";
            Text = "Gestão de Obras";
            ResumeLayout(false);
        }
    }
}