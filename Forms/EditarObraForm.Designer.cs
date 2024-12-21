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
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            numOrcamento = new NumericUpDown();
            numCustosTotais = new NumericUpDown();
            dtpDataInicio = new DateTimePicker();
            dtpDataConclusao = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numOrcamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCustosTotais).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 27);
            txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(20, 60);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(300, 60);
            txtDescricao.TabIndex = 1;
            // 
            // numOrcamento
            // 
            numOrcamento.DecimalPlaces = 2;
            numOrcamento.Location = new Point(20, 140);
            numOrcamento.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numOrcamento.Name = "numOrcamento";
            numOrcamento.Size = new Size(300, 27);
            numOrcamento.TabIndex = 2;
            // 
            // numCustosTotais
            // 
            numCustosTotais.DecimalPlaces = 2;
            numCustosTotais.Location = new Point(20, 180);
            numCustosTotais.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCustosTotais.Name = "numCustosTotais";
            numCustosTotais.Size = new Size(300, 27);
            numCustosTotais.TabIndex = 3;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(20, 220);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(300, 27);
            dtpDataInicio.TabIndex = 4;
            // 
            // dtpDataConclusao
            // 
            dtpDataConclusao.Location = new Point(20, 260);
            dtpDataConclusao.Name = "dtpDataConclusao";
            dtpDataConclusao.ShowCheckBox = true;
            dtpDataConclusao.Size = new Size(300, 27);
            dtpDataConclusao.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "Em andamento", "Concluída", "Cancelada" });
            cmbEstado.Location = new Point(20, 300);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(300, 28);
            cmbEstado.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(20, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 30);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(180, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // EditarObraForm
            // 
            ClientSize = new Size(350, 400);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(numOrcamento);
            Controls.Add(numCustosTotais);
            Controls.Add(dtpDataInicio);
            Controls.Add(dtpDataConclusao);
            Controls.Add(cmbEstado);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "EditarObraForm";
            Text = "Editar Obra";
            ((System.ComponentModel.ISupportInitialize)numOrcamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCustosTotais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}