namespace GestaoObra_TP25460.Funcionario
{ 
 partial class AddFuncionario
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label lblMorada;
    private System.Windows.Forms.TextBox txtMorada;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblSalario;
    private System.Windows.Forms.TextBox txtSalario;
    private System.Windows.Forms.Label lblTipoCargo;
    private System.Windows.Forms.ComboBox cmbTipoCargo;
    private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblMorada = new Label();
            txtMorada = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblTipoCargo = new Label();
            cmbTipoCargo = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            txtNome.Text = "wdsdsds";
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblMorada
            // 
            lblMorada.Location = new Point(20, 60);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(100, 23);
            lblMorada.TabIndex = 2;
            lblMorada.Text = "Morada:";
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(150, 60);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(200, 27);
            txtMorada.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblSalario
            // 
            lblSalario.Location = new Point(20, 180);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(100, 23);
            lblSalario.TabIndex = 8;
            lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(150, 180);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(200, 27);
            txtSalario.TabIndex = 9;
            // 
            // lblTipoCargo
            // 
            lblTipoCargo.Location = new Point(20, 220);
            lblTipoCargo.Name = "lblTipoCargo";
            lblTipoCargo.Size = new Size(100, 23);
            lblTipoCargo.TabIndex = 10;
            lblTipoCargo.Text = "Tipo de Cargo:";
            // 
            // cmbTipoCargo
            // 
            cmbTipoCargo.Location = new Point(150, 220);
            cmbTipoCargo.Name = "cmbTipoCargo";
            cmbTipoCargo.Size = new Size(200, 28);
            cmbTipoCargo.TabIndex = 11;
            cmbTipoCargo.SelectedIndexChanged += cmbTipoCargo_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            // 
            // AddFuncionario
            // 
            ClientSize = new Size(400, 320);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblMorada);
            Controls.Add(txtMorada);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSalario);
            Controls.Add(txtSalario);
            Controls.Add(lblTipoCargo);
            Controls.Add(cmbTipoCargo);
            Controls.Add(btnGuardar);
            Name = "AddFuncionario";
            Text = "Adicionar Funcionário";
            Load += AddFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}