using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txt1.Text);
            int valor2 = Convert.ToInt32(txt2.Text);

            int resultado = valor1 + valor2;
            MessageBox.Show(resultado.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt3.Text);
            int num2 = Convert.ToInt32(txt4.Text);

            int resultado = num1 - num2;
            MessageBox.Show(resultado.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt5.Text);
            int n2 = Convert.ToInt32(txt6.Text);

            int resultado = n1 * n2;
            MessageBox.Show(resultado.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txt7.Text);
            int number2 = Convert.ToInt32(txt8.Text);

            int resultado = number1 / number2;
            MessageBox.Show(resultado.ToString());

        }
    }
}
