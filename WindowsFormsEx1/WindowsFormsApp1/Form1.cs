using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int baseRet = int.Parse(txtBase.Text);
                int alturaRet = int.Parse(txtAltura.Text);
                int area = baseRet * alturaRet;
                Resultado.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores interiro valido");
            }
        }
    }
}
