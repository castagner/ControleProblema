namespace ControleProblemasView
{
    partial class FrmNivel
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
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgNivel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(9, 21);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descricao";
            this.lbDescricao.Click += new System.EventHandler(this.lbDescricao_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(70, 18);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 20);
            this.tbDescricao.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(70, 59);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgNivel
            // 
            this.dgNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNivel.Location = new System.Drawing.Point(12, 99);
            this.dgNivel.Name = "dgNivel";
            this.dgNivel.Size = new System.Drawing.Size(240, 150);
            this.dgNivel.TabIndex = 5;
            // 
            // FrmNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgNivel);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Name = "FrmNivel";
            this.Text = "FrmNivel";
            this.Load += new System.EventHandler(this.FrmNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgNivel;
    }
}