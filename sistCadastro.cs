using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            comboec.Items.Add("Solteiro (a)");
            comboec.Items.Add("Casado (a)");
            comboec.Items.Add("Viúvo (a)");
            comboec.Items.Add("Separado (a)");

            comboec.SelectedIndex = 0;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtnome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if (txtnome.Text == " ")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtnome.Focus();
                return;
            }
            if (txttelefone.Text == "(  )       - ")
            {
                MessageBox.Show("Preencha o campo telefone.");
                txttelefone.Focus();
                return;
            }

            Char sexo;
            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = txtnome.Text;
            p.DataNascimento = txtdata.Text;
            p.EstadoCivil = comboec.SelectedItem.ToString();
            p.Telefone = txttelefone.Text;
            p.CasaPropria = checkcasa.Checked;
            p.Veiculo = checkveiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }


            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            listar();




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            listar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtdata.Text = "";
            comboec.SelectedIndex = 0;
            txttelefone.Text = "";
            checkcasa.Checked = false;
            checkveiculo.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            txtnome.Focus();

        }

        private void listar()
        {
            Lista.Items.Clear();

            foreach (Pessoa p in pessoas) 
            {
                Lista.Items.Add(p.Nome);
                
            }
        }
    }    

}
