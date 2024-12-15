namespace GestaoObra_TP25460
{
    partial class AddViaturaForm
    {
        private System.ComponentModel.IContainer components = null;

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
        private System.Windows.Forms.Button btnAdicionar;
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();

            // Matrícula
            this.lblMatricula.Text = "Matrícula:";
            this.lblMatricula.Location = new System.Drawing.Point(20, 20);
            this.txtMatricula.Location = new System.Drawing.Point(120, 20);
            this.txtMatricula.Size = new System.Drawing.Size(200, 20);

            // Marca
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Location = new System.Drawing.Point(20, 60);
            this.txtMarca.Location = new System.Drawing.Point(120, 60);
            this.txtMarca.Size = new System.Drawing.Size(200, 20);

            // Modelo
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Location = new System.Drawing.Point(20, 100);
            this.txtModelo.Location = new System.Drawing.Point(120, 100);
            this.txtModelo.Size = new System.Drawing.Size(200, 20);

            // Ano
            this.lblAno.Text = "Ano:";
            this.lblAno.Location = new System.Drawing.Point(20, 140);
            this.numAno.Location = new System.Drawing.Point(120, 140);
            this.numAno.Maximum = 2050;
            this.numAno.Minimum = 1980;
            this.numAno.Value = DateTime.Now.Year;

            // Estado
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Location = new System.Drawing.Point(20, 180);
            this.cmbEstado.Location = new System.Drawing.Point(120, 180);
            this.cmbEstado.Items.AddRange(new string[] { "Disponível", "Em Manutenção", "Indisponível" });
            this.cmbEstado.SelectedIndex = 0;

            // Botão Adicionar
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Location = new System.Drawing.Point(50, 220);
            this.btnAdicionar.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // Botão Cancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(180, 220);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "AddViaturaForm";
            this.Text = "Adicionar Viatura";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
