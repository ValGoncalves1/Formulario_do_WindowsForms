using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            if (valor1 > valor2)
            {
                Resultado.Text = "Maior valor = " + valor1;
            }

            else if (valor2 > valor1)
            {
                Resultado.Text = "Maior valor = " + valor2;
            }

            else
            {
                Resultado.Text = " Os numeros são identicos";
            }
        }
    }
}
