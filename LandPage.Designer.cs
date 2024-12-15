namespace GestaoObra_TP25460
{
    partial class LandPage
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.Button btnAddObra;
        private System.Windows.Forms.Button btnAddViatura;

        private void InitializeComponent()
        {
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.btnAddObra = new System.Windows.Forms.Button();
            this.btnAddViatura = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Botão Add Funcionario
            this.btnAddFuncionario.Text = "Adicionar Funcionário";
            this.btnAddFuncionario.Location = new System.Drawing.Point(50, 30);
            this.btnAddFuncionario.Size = new System.Drawing.Size(200, 40);
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);

            // Botão Add Obra
            this.btnAddObra.Text = "Adicionar Obra";
            this.btnAddObra.Location = new System.Drawing.Point(50, 80);
            this.btnAddObra.Size = new System.Drawing.Size(200, 40);
            this.btnAddObra.Click += new System.EventHandler(this.btnAddObra_Click);

            // Botão Add Viatura
            this.btnAddViatura.Text = "Adicionar Viatura";
            this.btnAddViatura.Location = new System.Drawing.Point(50, 130);
            this.btnAddViatura.Size = new System.Drawing.Size(200, 40);
            this.btnAddViatura.Click += new System.EventHandler(this.btnAddViatura_Click);

            // LandPage
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnAddFuncionario);
            this.Controls.Add(this.btnAddObra);
            this.Controls.Add(this.btnAddViatura);
            this.Name = "LandPage";
            this.Text = "Gestão de Obras - Menu Principal";
            this.ResumeLayout(false);
        }
    }
}
