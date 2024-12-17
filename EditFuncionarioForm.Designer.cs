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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblId
            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(12, 15);

            // txtId
            this.txtId.Location = new System.Drawing.Point(100, 12);
            this.txtId.ReadOnly = true;

            // lblNome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(12, 45);

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(100, 42);

            // lblCargo
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.Location = new System.Drawing.Point(12, 75);

            // txtCargo
            this.txtCargo.Location = new System.Drawing.Point(100, 72);

            // lblSalario
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Location = new System.Drawing.Point(12, 105);

            // txtSalario
            this.txtSalario.Location = new System.Drawing.Point(100, 102);

            // btnSalvar
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(100, 140);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(200, 140);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // EditFuncionarioForm
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Text = "Editar Funcionário";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}