namespace Adapter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ligar_btn = new System.Windows.Forms.Button();
            this.Aparelho_cbb = new System.Windows.Forms.ComboBox();
            this.acao_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ligar_btn
            // 
            this.Ligar_btn.Location = new System.Drawing.Point(162, 62);
            this.Ligar_btn.Name = "Ligar_btn";
            this.Ligar_btn.Size = new System.Drawing.Size(141, 21);
            this.Ligar_btn.TabIndex = 0;
            this.Ligar_btn.Text = "Ligar";
            this.Ligar_btn.UseVisualStyleBackColor = true;
            this.Ligar_btn.Click += new System.EventHandler(this.Ligar_btn_Click);
            // 
            // Aparelho_cbb
            // 
            this.Aparelho_cbb.FormattingEnabled = true;
            this.Aparelho_cbb.Location = new System.Drawing.Point(12, 62);
            this.Aparelho_cbb.Name = "Aparelho_cbb";
            this.Aparelho_cbb.Size = new System.Drawing.Size(121, 21);
            this.Aparelho_cbb.TabIndex = 1;
            // 
            // acao_lbl
            // 
            this.acao_lbl.AutoSize = true;
            this.acao_lbl.Location = new System.Drawing.Point(12, 111);
            this.acao_lbl.Name = "acao_lbl";
            this.acao_lbl.Size = new System.Drawing.Size(0, 13);
            this.acao_lbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 155);
            this.Controls.Add(this.acao_lbl);
            this.Controls.Add(this.Aparelho_cbb);
            this.Controls.Add(this.Ligar_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ligar_btn;
        private System.Windows.Forms.ComboBox Aparelho_cbb;
        private System.Windows.Forms.Label acao_lbl;
    }
}

