namespace WindowsFormsApp13
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
            this.valor1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.valor3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(225, 107);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(40, 13);
            this.valor1.TabIndex = 1;
            this.valor1.Text = "Valor 1";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Location = new System.Drawing.Point(225, 165);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(40, 13);
            this.valor2.TabIndex = 2;
            this.valor2.Text = "Valor 2";
            // 
            // valor3
            // 
            this.valor3.AutoSize = true;
            this.valor3.Location = new System.Drawing.Point(225, 217);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(40, 13);
            this.valor3.TabIndex = 3;
            this.valor3.Text = "Valor 3";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(379, 287);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(73, 13);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "___________";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(382, 104);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 5;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(382, 162);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 6;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(382, 214);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(100, 20);
            this.txtValor3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.valor3);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label valor2;
        private System.Windows.Forms.Label valor3;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
    }
}

