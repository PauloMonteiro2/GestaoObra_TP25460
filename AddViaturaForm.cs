using System;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class AddViaturaForm : Form
    {
        public AddViaturaForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();

            // txtMatricula
            this.txtMatricula.Location = new System.Drawing.Point(30, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 22);
            this.txtMatricula.TabIndex = 0;

            // txtMarca
            this.txtMarca.Location = new System.Drawing.Point(30, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 22);
            this.txtMarca.TabIndex = 1;

            // txtModelo
            this.txtModelo.Location = new System.Drawing.Point(30, 110);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 22);
            this.txtModelo.TabIndex = 2;

            // numAno
            this.numAno.Location = new System.Drawing.Point(30, 150);
            this.numAno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(200, 22);
            this.numAno.TabIndex = 3;
            this.numAno.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});

            // cmbEstado
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponível",
            "Em Manutenção",
            "Indisponível"});
            this.cmbEstado.Location = new System.Drawing.Point(30, 190);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 4;

            // btnAdicionar
            this.btnAdicionar.Location = new System.Drawing.Point(30, 240);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 30);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar Viatura";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // AddViaturaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "AddViaturaForm";
            this.Text = "Adicionar Viatura";
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnAdicionar;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = txtMatricula.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int ano = (int)numAno.Value;
                string estado = cmbEstado.SelectedItem.ToString();

                if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var novaViatura = new Viatura(matricula, marca, modelo, ano, estado);
                Viatura.AdicionarViatura(novaViatura);

                MessageBox.Show("Viatura adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar a viatura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparFormulario()
        {
            txtMatricula.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            numAno.Value = numAno.Minimum;
            cmbEstado.SelectedIndex = -1;
        }
    }
}
