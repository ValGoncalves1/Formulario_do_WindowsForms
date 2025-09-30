namespace WindowsFormsApp7
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cotação = new System.Windows.Forms.Label();
            this.Dolares = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cotação
            // 
            this.Cotação.AutoSize = true;
            this.Cotação.Location = new System.Drawing.Point(273, 123);
            this.Cotação.Name = "Cotação";
            this.Cotação.Size = new System.Drawing.Size(47, 13);
            this.Cotação.TabIndex = 1;
            this.Cotação.Text = "Cotacao";
            // 
            // Dolares
            // 
            this.Dolares.AutoSize = true;
            this.Dolares.Location = new System.Drawing.Point(273, 197);
            this.Dolares.Name = "Dolares";
            this.Dolares.Size = new System.Drawing.Size(43, 13);
            this.Dolares.TabIndex = 2;
            this.Dolares.Text = "Dolares";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(409, 245);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(67, 13);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "__________";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(412, 120);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(100, 20);
            this.txtCotacao.TabIndex = 4;
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(412, 194);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Dolares);
            this.Controls.Add(this.Cotação);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cotação;
        private System.Windows.Forms.Label Dolares;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtDolares;
    }
}

