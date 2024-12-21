namespace GestaoObra_TP25460.Forms
{
    partial class EditFuncionarioForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Location = new Point(12, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(12, 45);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 27);
            txtNome.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.Location = new Point(12, 75);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(100, 23);
            lblCargo.TabIndex = 4;
            lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(100, 72);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 27);
            txtCargo.TabIndex = 5;
            // 
            // lblSalario
            // 
            lblSalario.Location = new Point(12, 105);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(100, 23);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(100, 102);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 27);
            txtSalario.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(100, 140);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EditFuncionarioForm
            // 
            ClientSize = new Size(320, 200);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCargo);
            Controls.Add(txtCargo);
            Controls.Add(lblSalario);
            Controls.Add(txtSalario);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "EditFuncionarioForm";
            Text = "Editar Funcionário";
            Load += EditFuncionarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}