namespace WindowsFormsApp2
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
            this.Aresta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aresta
            // 
            this.Aresta.AutoSize = true;
            this.Aresta.Location = new System.Drawing.Point(225, 92);
            this.Aresta.Name = "Aresta";
            this.Aresta.Size = new System.Drawing.Size(37, 13);
            this.Aresta.TabIndex = 0;
            this.Aresta.Text = "Aresta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(370, 152);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(73, 13);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "___________";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(373, 85);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aresta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aresta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button button1;
    }
}

