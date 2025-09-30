using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diagonal = int.Parse(txtDiagonal.Text);
            int area = (diagonal * diagonal) / 2;
            Resultado.Text = "Área do quadrado = " + area;
        }
    }
}
