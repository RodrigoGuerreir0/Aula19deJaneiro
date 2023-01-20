using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto19deJaneiro
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void botaoIgual_Click(object sender, EventArgs e)
      
        {
            valor2 = int.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "subtracao")
            {
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "mutiplicacao")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            if (operacao == "divisao")
            {
                textBox1.ForeColor= Color.Red;
                textBox1.Text = Convert.ToString(valor1 / valor2);
                
            if (valor1 < valor2)
            
                textBox1.Text = ("Divisão inválida");
            }
        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "soma";
            label1.Text = "+";
        }

        private void botaoSubtração_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "subtracao";
            label1.Text = "-";
        }

        private void botaoMutiplicação_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "mutiplicacao";
            label1.Text = "x";
        }

        private void botaoDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "divisao";
            label1.Text = "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
