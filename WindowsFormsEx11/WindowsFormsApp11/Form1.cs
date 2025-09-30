using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int peso = int.Parse(txtPeso.Text);
            int altura = int.Parse(txtAltura.Text);
            int imc = (peso * 10000) / (altura * altura);

            if (imc < 20)
                Resultado.Text = "Abaixo do Peso";

            else if (imc < 25)
                Resultado.Text = "Peso Ideal";

            else
                Resultado.Text = "Acima do Peso";

        }
    }
}
