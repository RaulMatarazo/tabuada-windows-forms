namespace tabuada
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
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnProcessar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.listBoxTabuada = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Location = new System.Drawing.Point(70, 123);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(85, 16);
			this.lblSubtitulo.TabIndex = 0;
			this.lblSubtitulo.Text = "Tabuada do ";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(161, 121);
			this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(89, 22);
			this.txtNumero.TabIndex = 1;
			// 
			// btnProcessar
			// 
			this.btnProcessar.Location = new System.Drawing.Point(74, 157);
			this.btnProcessar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(176, 30);
			this.btnProcessar.TabIndex = 2;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.UseVisualStyleBackColor = true;
			this.btnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(74, 199);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(176, 30);
			this.btnLimpar.TabIndex = 3;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(74, 241);
			this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(176, 30);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
			// 
			// listBoxTabuada
			// 
			this.listBoxTabuada.FormattingEnabled = true;
			this.listBoxTabuada.ItemHeight = 16;
			this.listBoxTabuada.Location = new System.Drawing.Point(329, 75);
			this.listBoxTabuada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBoxTabuada.Name = "listBoxTabuada";
			this.listBoxTabuada.Size = new System.Drawing.Size(173, 276);
			this.listBoxTabuada.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(385, 47);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tabuada";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 384);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxTabuada);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnProcessar);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblSubtitulo);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tabuada";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox listBoxTabuada;
        private System.Windows.Forms.Label label1;
    }
}

