using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorBinarioDecimal
{
    public partial class FormConversorBinarioDecimal : Form
    {
        public FormConversorBinarioDecimal()
        {
            InitializeComponent();
        }
          
        private void btnCalcular_Click(object sender, EventArgs e)
            {

            // Declaração de Variáveis
            int valor = int.Parse(txtBoxValor.Text);
            int expoente = 0;
            int dec = 0;
            string binario = "";

            // Condições para conversão dos valores 

            //Conversão de decimal para binário
            if (rdBtnDecimalBinario.Checked == true)
            {
                while (valor > 0)
                {
                    binario = valor % 2 + binario;
                    valor = valor / 2;
                }

                // Imprime o valor em tela
                txtBoxConvertido.Text = binario;
            }

            //Conversão binário para decimal 
            if (rdBtnBinarioDecimal.Checked == true)
            {
                while (valor > 0)
                {
                    dec = dec + (int)Math.Pow(2, expoente) * (valor % 10);
                    valor = valor / 10;
                    expoente++;
                }
                // Imprime o valor em tela
                txtBoxConvertido.Text = Convert.ToString(dec);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar os dados do textBox
            txtBoxValor.Clear();
            txtBoxConvertido.Clear();
        }
    }

}
