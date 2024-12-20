namespace GestaoObra_TP25460
{
    partial class FormViaturas
    {
        private System.ComponentModel.IContainer components = null;

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
            this.listViewViaturas = new System.Windows.Forms.ListView();
            this.colMatricula = new System.Windows.Forms.ColumnHeader();
            this.colMarca = new System.Windows.Forms.ColumnHeader();
            this.colModelo = new System.Windows.Forms.ColumnHeader();
            this.colAno = new System.Windows.Forms.ColumnHeader();
            this.colEstado = new System.Windows.Forms.ColumnHeader();
            this.btnExibirViaturas = new System.Windows.Forms.Button();
            this.btnListarDisponiveis = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listViewViaturas
            this.listViewViaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMatricula,
                this.colMarca,
                this.colModelo,
                this.colAno,
                this.colEstado});
            this.listViewViaturas.FullRowSelect = true;
            this.listViewViaturas.GridLines = true;
            this.listViewViaturas.Location = new System.Drawing.Point(12, 12);
            this.listViewViaturas.Name = "listViewViaturas";
            this.listViewViaturas.Size = new System.Drawing.Size(560, 300);
            this.listViewViaturas.View = System.Windows.Forms.View.Details;

            // Column Headers
            this.colMatricula.Text = "Matrícula";
            this.colMatricula.Width = 100;
            this.colMarca.Text = "Marca";
            this.colMarca.Width = 120;
            this.colModelo.Text = "Modelo";
            this.colModelo.Width = 120;
            this.colAno.Text = "Ano";
            this.colAno.Width = 80;
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 100;

            // btnExibirViaturas
            this.btnExibirViaturas.Location = new System.Drawing.Point(12, 330);
            this.btnExibirViaturas.Name = "btnExibirViaturas";
            this.btnExibirViaturas.Size = new System.Drawing.Size(150, 30);
            this.btnExibirViaturas.Text = "Exibir Todas";
            this.btnExibirViaturas.Click += new System.EventHandler(this.btnExibirViaturas_Click);

            // btnListarDisponiveis
            this.btnListarDisponiveis.Location = new System.Drawing.Point(180, 330);
            this.btnListarDisponiveis.Name = "btnListarDisponiveis";
            this.btnListarDisponiveis.Size = new System.Drawing.Size(150, 30);
            this.btnListarDisponiveis.Text = "Listar Disponíveis";
            this.btnListarDisponiveis.Click += new System.EventHandler(this.btnListarDisponiveis_Click);

            // FormViaturas
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.listViewViaturas);
            this.Controls.Add(this.btnExibirViaturas);
            this.Controls.Add(this.btnListarDisponiveis);
            this.Name = "FormViaturas";
            this.Text = "Gestão de Viaturas";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewViaturas;
        private System.Windows.Forms.ColumnHeader colMatricula;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colModelo;
        private System.Windows.Forms.ColumnHeader colAno;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.Button btnExibirViaturas;
        private System.Windows.Forms.Button btnListarDisponiveis;
    }
}
