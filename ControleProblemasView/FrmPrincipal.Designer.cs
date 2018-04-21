namespace ControleProblemasView
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.problemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroTipoToolStripMenuItem,
            this.cadastroNivelToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // cadastroTipoToolStripMenuItem
            // 
            this.cadastroTipoToolStripMenuItem.Name = "cadastroTipoToolStripMenuItem";
            this.cadastroTipoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cadastroTipoToolStripMenuItem.Text = "Cadastro Tipo";
            this.cadastroTipoToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoToolStripMenuItem_Click);
            // 
            // cadastroNivelToolStripMenuItem
            // 
            this.cadastroNivelToolStripMenuItem.Name = "cadastroNivelToolStripMenuItem";
            this.cadastroNivelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cadastroNivelToolStripMenuItem.Text = "Cadastro Nivel";
            this.cadastroNivelToolStripMenuItem.Click += new System.EventHandler(this.cadastroNivelToolStripMenuItem_Click);
            // 
            // problemaToolStripMenuItem
            // 
            this.problemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProblemaToolStripMenuItem});
            this.problemaToolStripMenuItem.Name = "problemaToolStripMenuItem";
            this.problemaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.problemaToolStripMenuItem.Text = "Problema";
            // 
            // cadastroDeProblemaToolStripMenuItem
            // 
            this.cadastroDeProblemaToolStripMenuItem.Name = "cadastroDeProblemaToolStripMenuItem";
            this.cadastroDeProblemaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeProblemaToolStripMenuItem.Text = "Cadastro de Problema";
            this.cadastroDeProblemaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProblemaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroNivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProblemaToolStripMenuItem;
    }
}