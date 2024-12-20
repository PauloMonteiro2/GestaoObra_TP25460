namespace GestaoObra_TP25460
{
    partial class EditarObraForm
    {
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown numOrcamento;
        private System.Windows.Forms.NumericUpDown numCustosTotais;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataConclusao;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.numOrcamento = new System.Windows.Forms.NumericUpDown();
            this.numCustosTotais = new System.Windows.Forms.NumericUpDown();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataConclusao = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustosTotais)).BeginInit();
            this.SuspendLayout();

            this.txtNome.Location = new System.Drawing.Point(20, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 23);
            this.txtNome.TabIndex = 0;

            this.txtDescricao.Location = new System.Drawing.Point(20, 60);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(300, 60);
            this.txtDescricao.TabIndex = 1;

            this.numOrcamento.Location = new System.Drawing.Point(20, 140);
            this.numOrcamento.Maximum = 100000000;
            this.numOrcamento.DecimalPlaces = 2;
            this.numOrcamento.Name = "numOrcamento";
            this.numOrcamento.Size = new System.Drawing.Size(300, 23);
            this.numOrcamento.TabIndex = 2;

            this.numCustosTotais.Location = new System.Drawing.Point(20, 180);
            this.numCustosTotais.Maximum = 100000000;
            this.numCustosTotais.DecimalPlaces = 2;
            this.numCustosTotais.Name = "numCustosTotais";
            this.numCustosTotais.Size = new System.Drawing.Size(300, 23);
            this.numCustosTotais.TabIndex = 3;

            this.dtpDataInicio.Location = new System.Drawing.Point(20, 220);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(300, 23);
            this.dtpDataInicio.TabIndex = 4;

            this.dtpDataConclusao.Location = new System.Drawing.Point(20, 260);
            this.dtpDataConclusao.Name = "dtpDataConclusao";
            this.dtpDataConclusao.ShowCheckBox = true;
            this.dtpDataConclusao.Size = new System.Drawing.Size(300, 23);
            this.dtpDataConclusao.TabIndex = 5;

            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "Em andamento",
            "Concluída",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(20, 300);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(300, 23);
            this.cmbEstado.TabIndex = 6;

            this.btnSalvar.Location = new System.Drawing.Point(20, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 30);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;

            this.btnCancelar.Location = new System.Drawing.Point(180, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.numOrcamento);
            this.Controls.Add(this.numCustosTotais);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.dtpDataConclusao);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Text = "Editar Obra";
            ((System.ComponentModel.ISupportInitialize)(this.numOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustosTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}