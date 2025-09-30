using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Base = int.Parse(txtBase.Text);
            int altura = int.Parse(txtAltura.Text);
            int area = (Base * altura) / 2;
            Resultado.Text = "Área do triângulo = " + area;

        }
    }
}
