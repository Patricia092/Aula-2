using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class DiaSemana : Form
    {
        public DiaSemana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            switch (n)
            {
                case 1:
                    textBox2.Text = "Segunda-Feira";
                    break;
                case 2:
                    textBox2.Text = "Terça-Feira";
                    break;
                case 3:
                    textBox2.Text = "Quarta-Feira";
                    break;
                case 4:
                    textBox2.Text = "Quinta-Feira";
                    break;
                case 5:
                    textBox2.Text = "Sexta-Feira";
                    break;
                case 6:
                    textBox2.Text = "Sábado";
                    break;
                case 7:
                    textBox2.Text = "Domingo";
                    break;
                default:
                    textBox2.Text = "Número inválido";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
