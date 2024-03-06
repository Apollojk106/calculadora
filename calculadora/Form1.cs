using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; }

        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao 
        { 
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void bt1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            btoperacao.Text = "";
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            btoperacao.Text = "+";
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            btoperacao.Text = "-";
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            btoperacao.Text = "X";
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            btoperacao.Text = "/";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Convert.ToDecimal(textResultado.Text) + Valor;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Convert.ToDecimal(textResultado.Text) * Valor;
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textResultado.Text);
                    break;
            }
            textResultado.Text = Convert.ToString(Resultado);
            btoperacao.Text = "=";
        }

        private void btvirgula_Click(object sender, EventArgs e)
        {
            if(!textResultado.Text.Contains(","))
                textResultado.Text += ",";
        }
    }
}
