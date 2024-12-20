namespace GestaoObra_TP25460
{
    partial class ConsultaStockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNomeMaterial;
        private System.Windows.Forms.Label lblNomeMaterial;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListView lstEstoque;

        private void InitializeComponent()
        {
            this.txtNomeMaterial = new System.Windows.Forms.TextBox();
            this.lblNomeMaterial = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstEstoque = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // lblNomeMaterial
            this.lblNomeMaterial.AutoSize = true;
            this.lblNomeMaterial.Location = new System.Drawing.Point(20, 20);
            this.lblNomeMaterial.Name = "lblNomeMaterial";
            this.lblNomeMaterial.Size = new System.Drawing.Size(100, 15);
            this.lblNomeMaterial.Text = "Nome do Material";

            // txtNomeMaterial
            this.txtNomeMaterial.Location = new System.Drawing.Point(140, 20);
            this.txtNomeMaterial.Name = "txtNomeMaterial";
            this.txtNomeMaterial.Size = new System.Drawing.Size(200, 23);

            // btnConsultar
            this.btnConsultar.Location = new System.Drawing.Point(360, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);

            // lstEstoque
            this.lstEstoque.Location = new System.Drawing.Point(20, 60);
            this.lstEstoque.Name = "lstEstoque";
            this.lstEstoque.Size = new System.Drawing.Size(440, 300);
            this.lstEstoque.View = System.Windows.Forms.View.Details;
            this.lstEstoque.Columns.Add("Nome", 200);
            this.lstEstoque.Columns.Add("Quantidade", 100);

            // ConsultaStockForm
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblNomeMaterial);
            this.Controls.Add(this.txtNomeMaterial);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lstEstoque);
            this.Text = "Consulta de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
