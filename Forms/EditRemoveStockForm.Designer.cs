using System;
using System.Windows.Forms;

namespace GestaoObra
{
    public partial class EditRemoveStockForm : Form
    {
        private ComboBox comboBoxMateriais;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelMateriais;
        private Label labelQuantidade;
        private Button botaoGuardar;
        private Button botaoRemover;

        private void InitializeComponent()
        {
            this.comboBoxMateriais = new ComboBox();
            this.numericUpDownQuantidade = new NumericUpDown();
            this.labelMateriais = new Label();
            this.labelQuantidade = new Label();
            this.botaoGuardar = new Button();
            this.botaoRemover = new Button();

            // ComboBox Materiais
            this.comboBoxMateriais.Location = new System.Drawing.Point(140, 20);
            this.comboBoxMateriais.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMateriais.Size = new System.Drawing.Size(180, 23);

            // Label Materiais
            this.labelMateriais.Text = "Material:";
            this.labelMateriais.Location = new System.Drawing.Point(20, 20);
            this.labelMateriais.Size = new System.Drawing.Size(100, 23);

            // NumericUpDown Quantidade
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(140, 60);
            this.numericUpDownQuantidade.Minimum = 0;
            this.numericUpDownQuantidade.Maximum = 1000;
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(100, 23);

            // Label Quantidade
            this.labelQuantidade.Text = "Quantidade:";
            this.labelQuantidade.Location = new System.Drawing.Point(20, 60);
            this.labelQuantidade.Size = new System.Drawing.Size(100, 23);

            // Botão Guardar
            this.botaoGuardar.Text = "Guardar Alterações";
            this.botaoGuardar.Location = new System.Drawing.Point(20, 120);
            this.botaoGuardar.Size = new System.Drawing.Size(140, 30);
            this.botaoGuardar.Click += new EventHandler(BotaoGuardar_Click);

            // Botão Remover
            this.botaoRemover.Text = "Remover Material";
            this.botaoRemover.Location = new System.Drawing.Point(180, 120);
            this.botaoRemover.Size = new System.Drawing.Size(140, 30);
            this.botaoRemover.Click += new EventHandler(BotaoRemover_Click);

            // Formulário
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.comboBoxMateriais);
            this.Controls.Add(this.labelMateriais);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.botaoGuardar);
            this.Controls.Add(this.botaoRemover);
            this.Text = "Editar/Remover Stock";
        }
    }
}
