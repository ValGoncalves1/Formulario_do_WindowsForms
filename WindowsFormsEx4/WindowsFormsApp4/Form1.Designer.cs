namespace WindowsFormsApp4
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
            this.Base = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.AutoSize = true;
            this.Base.Location = new System.Drawing.Point(154, 127);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(31, 13);
            this.Base.TabIndex = 0;
            this.Base.Text = "Base";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(154, 198);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(34, 13);
            this.Altura.TabIndex = 1;
            this.Altura.Text = "Altura";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(286, 268);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(73, 13);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "___________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(289, 120);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(289, 178);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Base;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

