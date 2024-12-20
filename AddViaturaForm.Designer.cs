namespace GestaoObra_TP25460
{
    partial class AddViaturaForm
    {
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();

            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(20, 20);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(58, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";

            this.txtMatricula.Location = new System.Drawing.Point(120, 20);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 23);
            this.txtMatricula.TabIndex = 1;

            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(20, 60);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";

            this.txtMarca.Location = new System.Drawing.Point(120, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 23);
            this.txtMarca.TabIndex = 3;

            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(20, 100);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 15);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";

            this.txtModelo.Location = new System.Drawing.Point(120, 100);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 23);
            this.txtModelo.TabIndex = 5;

            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(20, 140);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 15);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano";

            this.numAno.Location = new System.Drawing.Point(120, 140);
            this.numAno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(200, 23);
            this.numAno.TabIndex = 7;
            this.numAno.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 180);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";

            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponível",
            "Em Manutenção",
            "Indisponível"});
            this.cmbEstado.Location = new System.Drawing.Point(120, 180);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 23);
            this.cmbEstado.TabIndex = 9;

            this.btnSalvar.Location = new System.Drawing.Point(120, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(230, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "AddViaturaForm";
            this.Text = "Adicionar Viatura";
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
