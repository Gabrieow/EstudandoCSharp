namespace CalculadoraBásica
{
    public partial class Form1 : Form
    {
        private string soma, soma2, operacao;
        public Form1()
        {
            InitializeComponent();
            soma = "";
            soma2 = "";
            operacao = "";
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            int conta = int.Parse(soma);
            int conta2 = int.Parse(soma2);
            int final = 0;
            string final2 = "";

            if (operacao == "+")
            {
                final = conta2 + conta;
                final2 = final.ToString();
                resultadoCalculadora.Text = final2;
                soma = final2;

            }
            else if (operacao == "-")
            {
                final = conta2 - conta;
                final2 = final.ToString();
                resultadoCalculadora.Text = final2;
                soma = final2;

            }
            else if (operacao == "*")
            {
                final = conta2 * conta;
                final2 = final.ToString();
                resultadoCalculadora.Text = final2;
                soma = final2;
            }
            else if (operacao == "/")
            {
                final = conta2 / conta;
                final2 = final.ToString();
                resultadoCalculadora.Text = final2;
                soma = final2;
            }
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "1";
            resultadoCalculadora.Text += soma;

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "2";
            resultadoCalculadora.Text += soma;
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "3";
            resultadoCalculadora.Text += soma;
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "4";
            resultadoCalculadora.Text += soma;
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "5";
            resultadoCalculadora.Text += soma;
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "6";
            resultadoCalculadora.Text += soma;
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "7";
            resultadoCalculadora.Text += soma;
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "8";
            resultadoCalculadora.Text += soma;
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "9";
            resultadoCalculadora.Text += soma;
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            resultadoCalculadora.Text = "";
            soma += "0";
            resultadoCalculadora.Text += soma;
        }

        private void botaoAdicao_Click(object sender, EventArgs e)
        {
            soma2 = soma;
            soma = "";
            operacao = "+";

        }

        private void botaoSubtracao_Click(object sender, EventArgs e)
        {
            soma2 = soma;
            soma = "";
            operacao = "-";
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {
            soma2 = soma;
            soma = "";
            operacao = "*";
        }

        private void botaoDivisao_Click(object sender, EventArgs e)
        {
            soma2 = soma;
            soma = "";
            operacao = "/";
        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            soma = "";
            soma2 = "";
            resultadoCalculadora.Text = "";
        }
    }
}
