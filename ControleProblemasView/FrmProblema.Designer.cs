namespace ControleProblemasView
{
    partial class FrmProblema
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.datacriacao = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(38, 29);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 1;
            this.descricao.Text = "Descrição";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(32, 93);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataCriacao.TabIndex = 2;
            // 
            // datacriacao
            // 
            this.datacriacao.AutoSize = true;
            this.datacriacao.Location = new System.Drawing.Point(29, 77);
            this.datacriacao.Name = "datacriacao";
            this.datacriacao.Size = new System.Drawing.Size(68, 13);
            this.datacriacao.TabIndex = 3;
            this.datacriacao.Text = "Data criação";
            this.datacriacao.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(32, 141);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(121, 21);
            this.cboNivel.TabIndex = 4;
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(32, 186);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 6;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(98, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.datacriacao);
            this.Controls.Add(this.txtDataCriacao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.txtDescricao);
            this.Name = "FrmProblema";
            this.Text = "Cadastro de Problemas";
            this.Load += new System.EventHandler(this.FrmProblema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label datacriacao;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnSalvar;
    }
}