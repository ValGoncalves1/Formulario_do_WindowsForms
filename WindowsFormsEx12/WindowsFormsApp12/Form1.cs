using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtValor1.Text);
            int b = int.Parse(txtValor2.Text);
            int c = int.Parse(txtValor3.Text);

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Resultado.Text = "Equilatero";

                else if (a == b || a == c || b == c)
                    Resultado.Text = "Isosceles";

                else
                    Resultado.Text = "Escaleno";
            }
            else
            {
                Resultado.Text = "Não é triangulo";
            }
        }
    }
}
