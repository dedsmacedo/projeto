using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verificacao_caracter

{
    public partial class Form1 : Form
    {
        char entrada;
        int valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVarifica_Click(object sender, EventArgs e)
        {
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);

            if(valor >= 65 && valor <= 90)
            {
                lblresultado.Text = "Letra Maiúscula";

            }
            if (valor >= 97 && valor <= 122)
            {
                lblresultado.Text = "Letra Minúscula";
            }
            if (valor >= 48 && valor <= 57)
            {
                lblresultado.Text = "Dígito";
            }
            if(valor == 0 && valor <= 47 || valor >= 58 && valor <= 64 || valor >= 91 && valor <= 96 || valor >= 123 &&valor <= 127)
            {
                lblresultado.Text = "Símbolo Especial";
            }
            if (valor >= 127)
            {
                lblresultado.Text = "Caractere Especial";
            }


        }
    }
}
