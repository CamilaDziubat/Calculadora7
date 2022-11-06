using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var botao = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += botao.Text;
        }

      
        

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            lbOperacao.Text = "";
            txtResultado.Text = "0";
            operador = '\0';

        }

      

        private void btnApagarUmPorUm_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else {
                txtResultado.Text = "0";
            }
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            valor1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(botao.Tag);
            lbOperacao.Text = operador.ToString();

            if (operador == '²')
            {
                lbOperacao.Text = valor1+ "²";
                valor1 = Math.Pow(valor1, 2);
                txtResultado.Text = valor1.ToString();
            }
            else if (operador == '√')
            {
                valor1 = Math.Sqrt(valor1);
                txtResultado.Text = valor1.ToString();
            } 
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void limparLabelOperacao() {
            lbOperacao.Text = "";
        }

        private void btnPositivoNegativo_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtResultado.Text);
            valor1 *= -1;
            txtResultado.Text = valor1.ToString();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (valor1 + valor2).ToString();
                limparLabelOperacao();
                valor1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (valor1 - valor2).ToString();
                limparLabelOperacao();
                valor1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == 'x')
            {
                txtResultado.Text = (valor1 * valor2).ToString();
                limparLabelOperacao();
                valor1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '÷')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (valor1 / valor2).ToString();
                    limparLabelOperacao();
                    valor1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    limparLabelOperacao();
                    MessageBox.Show("Não é possível dividir por zero!!");
                }
            }
        }

    }
}
