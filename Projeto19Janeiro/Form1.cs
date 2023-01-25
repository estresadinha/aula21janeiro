﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto18Janeiro
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



        private void botao7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }


        private void botao8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";

        }

        private void botao9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";

        }

        private void botao4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
        }



        private void botaoResult_Click(object sender, EventArgs e)

        {
            if (TxtResultado.Text != "")
            {

                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "soma")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                }

                if (operacao == "sub")
                {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                }

                if (operacao == "div")
                {
                    if (valor1 < valor2)
                    {
                        TxtResultado.ForeColor = Color.Red;
                        TxtResultado.Text = "Inválido";
                    }
                    else
                        TxtResultado.Text = Convert.ToString(valor1 / valor2);

                }


                if (operacao == "mult")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);

                }
               
            }
            else
                MessageBox.Show("digite um valor para efetuar uma operação");
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "") {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "soma";
                labelOperacao.Text = "+";
            }
            else
                MessageBox.Show("favor digitar um número");




        }


        private void botaoSub_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "sub";
                labelOperacao.Text = "-";

            }
            else
                MessageBox.Show("favor digitar um número");
        }
         
             



            private void botaoMult_Click(object sender, EventArgs e)
            {
            if (TxtResultado.Text != "")
            {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "mult";
                labelOperacao.Text = "*";

            }
            else
                MessageBox.Show("favor digitar um número");

        }



            private void botaoDiv_Click(object sender, EventArgs e)
            {
            if (TxtResultado.Text != "")
            {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "div";
                labelOperacao.Text = "/";

            }

            else
                MessageBox.Show("favor digitar um número");
        }


            private void botaoCE_Click(object sender, EventArgs e)
            {
                TxtResultado.Text = "";

            }

            private void botaoC_Click(object sender, EventArgs e)
            {
                TxtResultado.Text = "";
                valor1 = 0;
                valor2 = 0;
                labelOperacao.Text = "";
            }

            private void botaoPonto_Click(object sender, EventArgs e)
            {
            TxtResultado.Text = TxtResultado.Text + ".";
            }
        


    }
}
