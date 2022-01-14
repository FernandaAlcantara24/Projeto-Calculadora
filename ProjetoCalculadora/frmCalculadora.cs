using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {
        string operacao = "";
        double valorAnterior = 0;
        bool primeiraOperacao = false;
        double valorVisor = 0;
        bool botaoIgual = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender; // O objeto botão que foi clicado será carregado no botaoAcionado.
            switch (botaoAcionado.Name)
            {
                case "btn1":                // Caso seja btn1
                    txbVisor.Text += "1";  // A propriedade Text do visor receberá o número 1
                    break;                // Parar a verificação.
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn2":
                    txbVisor.Text += "2";
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn3":
                    txbVisor.Text += "3";
                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn4":
                    txbVisor.Text += "4";
                    break;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn5":
                    txbVisor.Text += "5";
                    break;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn6":
                    txbVisor.Text += "6";
                    break;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn7":
                    txbVisor.Text += "7";
                    break;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn8":
                    txbVisor.Text += "8";
                    break;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn9":
                    txbVisor.Text += "9";
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btn0":
                    txbVisor.Text += "0";
                    break;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            Button botaoAcionado = (Button)sender;
            switch (botaoAcionado.Name)
            {
                case "btnVirgula":
                    txbVisor.Text += ",";
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
            txbHistorico.Clear();

            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text.Remove(txbVisor.Text.Length - 1);
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txbVisor.Text);

                if (botaoIgual == false)
                {
                    txbHistorico.Text += txbVisor.Text;
                }

                txbVisor.Clear();
                operacao = "+";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txbVisor.Text);
                txbHistorico.Text += operacao + txbVisor.Text;
                txbVisor.Text = Convert.ToString(valorAnterior + valorVisor);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorVisor = Convert.ToDouble(txbVisor.Text);

            txbHistorico.Text += operacao + txbVisor.Text;

            txbVisor.Text = Convert.ToString(Calculo());

            txbHistorico.Text += "=" + txbVisor.Text;

            valorAnterior = Convert.ToDouble(txbVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }

        public double Calculo()
        {
             switch(operacao)
             {
                case "+":
                    valorAnterior = valorAnterior + valorVisor;
                    break;

                case "-":
                    valorAnterior = valorAnterior - valorVisor;
                    break;

                case "*":
                    valorAnterior = valorAnterior * valorVisor;
                    break;

                case "/":
                    valorAnterior = valorAnterior / valorVisor;
                    break;

                default:
                    break;
            }
            return valorAnterior;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txbVisor.Text);

                if (botaoIgual == false)
                {
                    txbHistorico.Text += txbVisor.Text;
                }

                txbVisor.Clear();
                operacao = "-";
                primeiraOperacao = false;
            }

            else
            {
                valorVisor = Convert.ToDouble(txbVisor.Text);
                txbHistorico.Text += operacao + txbVisor.Text;
                txbVisor.Text = Convert.ToString(valorAnterior - valorVisor);
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txbVisor.Text);

                if (botaoIgual == false)
                {
                    txbHistorico.Text += txbVisor.Text;
                }

                txbVisor.Clear();
                operacao = "x";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txbVisor.Text);
                txbHistorico.Text += operacao + txbVisor.Text;
                txbVisor.Text = Convert.ToString(valorAnterior * valorVisor);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txbVisor.Text);

                if (botaoIgual == false)
                {
                    txbHistorico.Text += txbVisor.Text;
                }

                txbVisor.Clear();
                operacao = "/";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txbVisor.Text);
                txbHistorico.Text += operacao + txbVisor.Text;
                txbVisor.Text = Convert.ToString(valorAnterior / valorVisor);
            }
        }
    }
}