using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cotacao = int.Parse(txtCotacao.Text);
            int dolares = int.Parse(txtDolares.Text);
            int reais = cotacao * dolares;
            Resultado.Text = "Valor em reais = R$ " + reais;
        }
    }
}
