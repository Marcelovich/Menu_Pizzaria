using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPizzaria : Form
    {
        string cliente;

        double pizza = 0;
        string pizzaSelecionada;
        bool pizzaSelecionadaComSucesso = false;

        double borda = 0;
        string bordaSelecionada;

        double bebida = 0;
        string bebidaSelecionada;

        double suco = 0;
        string sucoSelecionado;

        public static frmPizzaria instance;

        public frmPizzaria()
        {
            InitializeComponent();
            instance = this;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            cliente = txtCliente.Text;

            //Pizzas inicio
            if (rbtnModaDaCasa.Checked)
            {
                pizza = 17.50;
                pizzaSelecionada = "A Moda da Casa";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnAtum.Checked)
            {
                pizza = 17.85;
                pizzaSelecionada = "Atum";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnBaiana.Checked)
            {
                pizza = 16.10;
                pizzaSelecionada = "Baiana";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnBrocolis.Checked)
            {
                pizza = 12.00;
                pizzaSelecionada = "Brocolis";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnCalabresa.Checked)
            {
                pizza = 20.50;
                pizzaSelecionada = "Calabresa";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnMussarela.Checked)
            {
                pizza = 16.70;
                pizzaSelecionada = "Mussarela";
                pizzaSelecionadaComSucesso = true;
            }
            else if (rbtnQuatroQueijos.Checked)
            {
                pizza = 15.50;
                pizzaSelecionada = "Quatro Queijos";
                pizzaSelecionadaComSucesso = true;
            }
            else if(rbtnStrogonoff.Checked)
            {
                pizza = 22.75;
                pizzaSelecionada = "Strogonoff";
                pizzaSelecionadaComSucesso = true;
            }
            else
            {
                if (!pizzaSelecionadaComSucesso)
                {
                    MessageBox.Show("Escolha um sabor de pizza!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //Pizzas final



            //Bordas inicio
            if (rbtnCatupiry.Checked)
            {
                borda = 3.45;
                bordaSelecionada = "Catupiry";
            }
            else if (rbtnCheddar.Checked)
            {
                borda = 4.65;
                bordaSelecionada = "Cheddar";
            }
            else
            {
                borda = 0.00;
                bordaSelecionada = "Sem";
            }
            //Bordas final



            //Refri inicio
            if (chkCervejaGarrafa.Checked) 
            {
                bebida = 5.50;
                bebidaSelecionada = "Cerveja (Garrafa)";
            }
            else if(chkCervejaLata.Checked)
            {
                bebida = 4.00;
                bebidaSelecionada = "Cerveja (Lata)";
            }
            else if (chkCocaLata.Checked)
            {
                bebida = 3.50;
                bebidaSelecionada = "Coca-Cola (Lata)";
            }
            else if (chkCocaLitro.Checked)
            {
                bebida = 5.10;
                bebidaSelecionada = "Coca-Cola (Litro)";
            }
            else if (chkGuaranaLata.Checked)
            {
                bebida = 2.85;
                bebidaSelecionada = "Guarana (Lata)";
            }
            else if (chkGuaranaLitro.Checked)
            {
                bebida = 3.50;
                bebidaSelecionada = "Guarana (Litro)";
            }
            else
            {
                bebida = 0;
                bebidaSelecionada = "Nenhum";
            }
            //Refri final



            //Sucos inicio
            if (chkAbacaxiCopo.Checked)
            {
                suco = 4.20;
                sucoSelecionado = "Abacaxi (Copo)";
            }
            else if (chkAbacaxiJarra.Checked)
            {
                suco = 6.05;
                sucoSelecionado = "Abacaxi (Jarra)";
            }
            else if (chkLaranjaCopo.Checked)
            {
                suco = 4.25;
                sucoSelecionado = "Laranja (Copo)";
            }
            else if (chkLaranjaJarra.Checked)
            {
                suco = 6.30;
                sucoSelecionado = "Laranja (Jarra)";
            }
            else if (chkMaracujaCopo.Checked)
            {
                suco = 4.10;
                sucoSelecionado = "Maracuja (Copo)";
            }
            else if (chkMaracujaJarra.Checked)
            {
                suco = 6.50;
                sucoSelecionado = "Maracuja (Jarra)";
            }
            else
            {
                suco = 0;
                sucoSelecionado = "Nenhum";
            }
            //Sucos final



            frmFatura faturaForm = new frmFatura(
                cliente,
                pizza,
                pizzaSelecionada,
                borda,
                bordaSelecionada,
                bebida,
                bebidaSelecionada,
                suco,
                sucoSelecionado
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";


            //pizzas 
            foreach (Control selecionado in grbPizzas.Controls)
            {
                if (selecionado is RadioButton)
                {
                    ((RadioButton)selecionado).Checked = false;
                }
            }


            //bordas
            foreach (Control selecionada in grbBordas.Controls)
            {
                if (selecionada is RadioButton)
                {
                    ((RadioButton)selecionada).Checked = false;
                }
            }


            //bebidas
            foreach (Control marcadas in grbBebidas.Controls)
            {
                if (marcadas is CheckBox)
                {
                    ((CheckBox)marcadas).Checked = false;
                }
            }



            //sucos
            foreach (Control marcados in grbSucos.Controls)
            {
                if (marcados is CheckBox)
                {
                    ((CheckBox)marcados).Checked = false;
                }
            }
        }
    }
}
