namespace WindowsFormsApp3
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
            this.Diagonal = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDiagonal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Diagonal
            // 
            this.Diagonal.AutoSize = true;
            this.Diagonal.Location = new System.Drawing.Point(237, 111);
            this.Diagonal.Name = "Diagonal";
            this.Diagonal.Size = new System.Drawing.Size(49, 13);
            this.Diagonal.TabIndex = 0;
            this.Diagonal.Text = "Diagonal";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(371, 174);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(73, 13);
            this.Resultado.TabIndex = 1;
            this.Resultado.Text = "___________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiagonal
            // 
            this.txtDiagonal.Location = new System.Drawing.Point(374, 104);
            this.txtDiagonal.Name = "txtDiagonal";
            this.txtDiagonal.Size = new System.Drawing.Size(100, 20);
            this.txtDiagonal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiagonal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Diagonal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Diagonal;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiagonal;
    }
}

