using GestaoObra_TP25460.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    partial class LandPage
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddObra;
        private Button btnAddTipo;
        private Button btnAddViatura;
        private Button btnEditFuncionario;
        private Button btnFormViaturas;
        private Button btnConsultaStock;
        private Button btnEditarObra;
        private Button btnEditarFuncionario;
        private Button btnEditRemoveStock;
        private Label titleLabel;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            titleLabel = new Label();
            btnAddObra = new Button();
            btnAddTipo = new Button();
            btnAddViatura = new Button();
            btnEditFuncionario = new Button();
            btnFormViaturas = new Button();
            btnConsultaStock = new Button();
            btnEditarObra = new Button();
            btnEditarFuncionario = new Button();
            btnEditRemoveStock = new Button();

            SuspendLayout();

            // 
            // titleLabel
            // 
            titleLabel.Text = "Gestão de Obras";
            titleLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Location = new Point(50, 10);
            titleLabel.Size = new Size(700, 40);

            // 
            // btnAddObra
            // 
            btnAddObra.Location = new Point(50, 70);
            btnAddObra.Name = "btnAddObra";
            btnAddObra.Size = new Size(300, 40);
            btnAddObra.TabIndex = 0;
            btnAddObra.Text = "Adicionar Obra";
            btnAddObra.Click += btnAddObra_Click;

            // 
            // btnAddTipo
            // 
            btnAddTipo.Location = new Point(50, 120);
            btnAddTipo.Name = "btnAddTipo";
            btnAddTipo.Size = new Size(300, 40);
            btnAddTipo.TabIndex = 1;
            btnAddTipo.Text = "Adicionar Funcionario";
            btnAddTipo.Click += btnAddTipo_Click;

            // 
            // btnAddViatura
            // 
            btnAddViatura.Location = new Point(50, 170);
            btnAddViatura.Name = "btnAddViatura";
            btnAddViatura.Size = new Size(300, 40);
            btnAddViatura.TabIndex = 2;
            btnAddViatura.Text = "Adicionar Viatura";
            btnAddViatura.Click += btnAddViatura_Click;

            // 
            // btnEditFuncionario
            // 
            btnEditFuncionario.Location = new Point(50, 220);
            btnEditFuncionario.Name = "btnEditFuncionario";
            btnEditFuncionario.Size = new Size(300, 40);
            btnEditFuncionario.TabIndex = 3;
            btnEditFuncionario.Text = "Editar Funcionário";
            btnEditFuncionario.Click += btnEditFuncionario_Click;

            // 
            // btnFormViaturas
            // 
            btnFormViaturas.Location = new Point(50, 270);
            btnFormViaturas.Name = "btnFormViaturas";
            btnFormViaturas.Size = new Size(300, 40);
            btnFormViaturas.TabIndex = 4;
            btnFormViaturas.Text = "Gerir Viaturas";
            btnFormViaturas.Click += btnFormViaturas_Click;

            // 
            // btnConsultaStock
            // 
            btnConsultaStock.Location = new Point(50, 320);
            btnConsultaStock.Name = "btnConsultaStock";
            btnConsultaStock.Size = new Size(300, 40);
            btnConsultaStock.TabIndex = 5;
            btnConsultaStock.Text = "Consultar Stock";
            btnConsultaStock.Click += btnConsultaStock_Click;

            // 
            // btnEditarObra
            // 
            btnEditarObra.Location = new Point(50, 370);
            btnEditarObra.Name = "btnEditarObra";
            btnEditarObra.Size = new Size(300, 40);
            btnEditarObra.TabIndex = 6;
            btnEditarObra.Text = "Editar Obra";
            btnEditarObra.Click += btnEditarObra_Click;

            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.Location = new Point(400, 70);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(300, 40);
            btnEditarFuncionario.TabIndex = 7;
            btnEditarFuncionario.Text = "Editar Funcionário";

            // 
            // btnEditRemoveStock
            // 
            btnEditRemoveStock.Location = new Point(400, 120);
            btnEditRemoveStock.Name = "btnEditRemoveStock";
            btnEditRemoveStock.Size = new Size(300, 40);
            btnEditRemoveStock.TabIndex = 8;
            btnEditRemoveStock.Text = "Editar/Remover Stock";
            btnEditRemoveStock.Click += btnEditRemoveStock_Click;

            // 
            // LandPage
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(btnAddObra);
            Controls.Add(btnAddTipo);
            Controls.Add(btnAddViatura);
            Controls.Add(btnEditFuncionario);
            Controls.Add(btnFormViaturas);
            Controls.Add(btnConsultaStock);
            Controls.Add(btnEditarObra);
            Controls.Add(btnEditarFuncionario);
            Controls.Add(btnEditRemoveStock);
            Name = "LandPage";
            Text = "Gestão de Obras";
            Load += LandPage_Load_1;
            ResumeLayout(false);
        }
    }
}
