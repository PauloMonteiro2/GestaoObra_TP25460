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
            listViewViaturas = new ListView();
            colMatricula = new ColumnHeader();
            colMarca = new ColumnHeader();
            colModelo = new ColumnHeader();
            colAno = new ColumnHeader();
            colEstado = new ColumnHeader();
            btnExibirViaturas = new Button();
            btnListarDisponiveis = new Button();
            SuspendLayout();
            // 
            // listViewViaturas
            // 
            listViewViaturas.Columns.AddRange(new ColumnHeader[] { colMatricula, colMarca, colModelo, colAno, colEstado });
            listViewViaturas.FullRowSelect = true;
            listViewViaturas.GridLines = true;
            listViewViaturas.Location = new Point(12, 15);
            listViewViaturas.Margin = new Padding(3, 4, 3, 4);
            listViewViaturas.Name = "listViewViaturas";
            listViewViaturas.Size = new Size(560, 374);
            listViewViaturas.TabIndex = 0;
            listViewViaturas.UseCompatibleStateImageBehavior = false;
            listViewViaturas.View = View.Details;
            // 
            // colMatricula
            // 
            colMatricula.Text = "Matrícula";
            colMatricula.Width = 100;
            // 
            // colMarca
            // 
            colMarca.Text = "Marca";
            colMarca.Width = 120;
            // 
            // colModelo
            // 
            colModelo.Text = "Modelo";
            colModelo.Width = 120;
            // 
            // colAno
            // 
            colAno.Text = "Ano";
            colAno.Width = 80;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 100;
            // 
            // btnExibirViaturas
            // 
            btnExibirViaturas.Location = new Point(12, 412);
            btnExibirViaturas.Margin = new Padding(3, 4, 3, 4);
            btnExibirViaturas.Name = "btnExibirViaturas";
            btnExibirViaturas.Size = new Size(150, 38);
            btnExibirViaturas.TabIndex = 1;
            btnExibirViaturas.Text = "Exibir Todas";
            btnExibirViaturas.Click += btnExibirViaturas_Click;
            // 
            // btnListarDisponiveis
            // 
            btnListarDisponiveis.Location = new Point(180, 412);
            btnListarDisponiveis.Margin = new Padding(3, 4, 3, 4);
            btnListarDisponiveis.Name = "btnListarDisponiveis";
            btnListarDisponiveis.Size = new Size(150, 38);
            btnListarDisponiveis.TabIndex = 2;
            btnListarDisponiveis.Text = "Listar Disponíveis";
            btnListarDisponiveis.Click += btnListarDisponiveis_Click;
            // 
            // FormViaturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 476);
            Controls.Add(listViewViaturas);
            Controls.Add(btnExibirViaturas);
            Controls.Add(btnListarDisponiveis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormViaturas";
            Text = "Gestão de Viaturas";
            Load += FormViaturas_Load;
            ResumeLayout(false);
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
