namespace GestaoObra_TP25460
{
    partial class DeleteFuncionario
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbFuncionarios;
        private System.Windows.Forms.Label lblSelecionarFuncionario;
        private System.Windows.Forms.Button btnDeletar;

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
            cmbFuncionarios = new ComboBox();
            lblSelecionarFuncionario = new Label();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(50, 50);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(300, 28);
            cmbFuncionarios.TabIndex = 0;
            cmbFuncionarios.SelectedIndexChanged += cmbFuncionarios_SelectedIndexChanged;
            // 
            // lblSelecionarFuncionario
            // 
            lblSelecionarFuncionario.AutoSize = true;
            lblSelecionarFuncionario.Location = new Point(50, 30);
            lblSelecionarFuncionario.Name = "lblSelecionarFuncionario";
            lblSelecionarFuncionario.Size = new Size(233, 20);
            lblSelecionarFuncionario.TabIndex = 1;
            lblSelecionarFuncionario.Text = "Selecione o Funcionário a apagar:";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(150, 100);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(100, 30);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // DeleteFuncionario
            // 
            ClientSize = new Size(400, 160);
            Controls.Add(cmbFuncionarios);
            Controls.Add(lblSelecionarFuncionario);
            Controls.Add(btnDeletar);
            Name = "DeleteFuncionario";
            Text = "Deletar Funcionário";
            Load += DeleteFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
