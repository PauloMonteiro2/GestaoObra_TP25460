namespace GestaoObra_TP25460
{
    partial class AddTipo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Configuração dos Controles
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.Location = new System.Drawing.Point(20, 20);
            this.txtDescricao.Location = new System.Drawing.Point(150, 20);
            this.txtDescricao.Width = 200;

            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(150, 60);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Adicionando Controles ao Formulário
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnGuardar);

            // Configuração do Formulário
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Text = "Adicionar Tipo de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}