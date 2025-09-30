using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int milhas = int.Parse(txtMilhas.Text);
            int km = (milhas * 1852) / 1000;
            Resultado.Text = "Equivale a " + km + "km";
        }
    }
}
