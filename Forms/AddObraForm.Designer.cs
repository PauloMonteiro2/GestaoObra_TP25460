namespace GestaoObra_TP25460
{
    partial class AddObraForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Nome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.Text = "Nome:";
            this.txtNome.Location = new System.Drawing.Point(120, 20);
            this.txtNome.Size = new System.Drawing.Size(200, 20);

            // Descrição
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 60);
            this.lblDescricao.Text = "Descrição:";
            this.txtDescricao.Location = new System.Drawing.Point(120, 60);
            this.txtDescricao.Size = new System.Drawing.Size(200, 20);

            // Orçamento
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(20, 100);
            this.lblOrcamento.Text = "Orçamento:";
            this.txtOrcamento.Location = new System.Drawing.Point(120, 100);
            this.txtOrcamento.Size = new System.Drawing.Size(200, 20);

            // Data de Início
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(20, 140);
            this.lblDataInicio.Text = "Data de Início:";
            this.dtpDataInicio.Location = new System.Drawing.Point(120, 140);
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Botão Salvar
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(50, 180);
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // Botão Cancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(180, 180);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblOrcamento);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "AddObraForm";
            this.Text = "Adicionar Nova Obra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
