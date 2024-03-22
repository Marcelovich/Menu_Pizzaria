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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class frmFatura : Form
    {
        public string cliente;

        public double pizza;
        public string pizzaSelecionada;

        public double borda;
        public string bordaSelecionada;

        public double bebida;
        public string bebidaSelecionada;

        public double suco;
        public string sucoSelecionado;

        public double totalFatura;

        public static frmFatura instance;
        public frmFatura(
            string clienteValue,

            double pizzaValue,
            string pizzaSelecionadaValue,

            double bordaValue,
            string bordaSelecionadaValue,

            double bebidaValue,
            string bebidaSelecionadaValue,

            double sucoValue,
            string sucoSelecionadaValue

            )
        {
            InitializeComponent();



            Program.cliente = cliente = clienteValue;
            Program.pizza = pizza = pizzaValue;
            Program.pizzaSelecionada = pizzaSelecionada = pizzaSelecionadaValue;
            Program.borda = borda = bordaValue;
            Program.bordaSelecionada = bordaSelecionada = bordaSelecionadaValue;
            Program.bebida = bebida = bebidaValue;
            Program.bebidaSelecionada = bebidaSelecionada = bebidaSelecionadaValue;
            Program.suco = suco = sucoValue;
            Program.sucoSelecionado = sucoSelecionado = sucoSelecionadaValue;
            AtualizarValores();
            
        }

        public frmFatura(string clienteValue, double pizzaValue, string pizzaSelecionadaValue, double bordaValue, string bordaSelecionadaValue, double bebidaValue, string bebidaSelecionadaValue, double sucoValue, string sucoSelecionadaValue, double totalFatura) : this(clienteValue, pizzaValue, pizzaSelecionadaValue, bordaValue, bordaSelecionadaValue, bebidaValue, bebidaSelecionadaValue, sucoValue, sucoSelecionadaValue)
        {
        }

        private void AtualizarValores()
        {

            lblCliente.Text = "Cliente: " + cliente;

            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

            lblPizzaEscolhida.Text = "Pizza: " + pizzaSelecionada;
            lblValorPizza.Text = pizza.ToString("C", culturaBrasileira);

            lblBordaEscolhida.Text = "Borda: " + bordaSelecionada;
            lblValorBorda.Text = borda.ToString("C", culturaBrasileira);

            lblBebidaEscolhida.Text = "Bebida: " + bebidaSelecionada;
            lblValorBebida.Text = bebida.ToString("C", culturaBrasileira);

            lblSucoEscolhido.Text = "Suco: " + sucoSelecionado;
            lblValorSuco.Text = suco.ToString("C", culturaBrasileira);

            Program.totalFatura = totalFatura = pizza + borda + bebida + suco;

            lblTotalFatura.Text = totalFatura.ToString("C", culturaBrasileira);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmFatura_Load(object sender, EventArgs e)
        {

        }
    }
}
