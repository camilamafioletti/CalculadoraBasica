using System.Globalization;

namespace CalculadoraBasica.WinFormsApp
{
    public partial class Form1 : Form
    {
        public double valor1 = 0;
        public double valor2 = 0;
        public string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtMostrarResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtMostrarResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtMostrarResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "DIV")
            {
                txtMostrarResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else
            {
                txtMostrarResultado.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtMostrarResultado.Text != "")
            {
                valor1 = double.Parse(txtMostrarResultado.Text, CultureInfo.InvariantCulture);
                txtMostrarResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtMostrarResultado.Text != "")
            {
                valor1 = double.Parse(txtMostrarResultado.Text, CultureInfo.InvariantCulture);
                txtMostrarResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtMostrarResultado.Text != "")
            {
                valor1 = double.Parse(txtMostrarResultado.Text, CultureInfo.InvariantCulture);
                txtMostrarResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMostrarResultado.Text != "")
            {
                valor1 = double.Parse(txtMostrarResultado.Text, CultureInfo.InvariantCulture);
                txtMostrarResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "÷";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMostrarResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}