namespace GestaoObra_TP25460
{
    partial class LandPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            viaturasToolStripMenuItem = new ToolStripMenuItem();
            consultaObraToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionarioToolStripMenuItem, viaturasToolStripMenuItem, consultaObraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(653, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, editarToolStripMenuItem, eliminarToolStripMenuItem });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(100, 24);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(224, 26);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(224, 26);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(224, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 48);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 703);
            panel1.TabIndex = 1;
            // 
            // viaturasToolStripMenuItem
            // 
            viaturasToolStripMenuItem.Name = "viaturasToolStripMenuItem";
            viaturasToolStripMenuItem.Size = new Size(76, 24);
            viaturasToolStripMenuItem.Text = "Viaturas";
            // 
            // consultaObraToolStripMenuItem
            // 
            consultaObraToolStripMenuItem.Name = "consultaObraToolStripMenuItem";
            consultaObraToolStripMenuItem.Size = new Size(117, 24);
            consultaObraToolStripMenuItem.Text = "Consulta Obra";
            // 
            // LandPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 321);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LandPage";
            Text = "LandPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem viaturasToolStripMenuItem;
        private ToolStripMenuItem consultaObraToolStripMenuItem;
    }
}