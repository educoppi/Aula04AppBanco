using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {

        static double saldo;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnDepositar.ForeColor = Color.RoyalBlue;
            btnDepositar.BackColor = Color.LightSteelBlue;

            btnSacar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.White;

            lblDeposito.Text = "DEPÓSITO";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnSacar.ForeColor = Color.RoyalBlue;
            btnSacar.BackColor = Color.LightSteelBlue;

            btnDepositar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.White;

            lblDeposito.Text = "SACAR";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor;
           
            valor = double.Parse(txtValor.Text);

            if (lblDeposito.Text == "SACAR")
            {

                if (saldo < valor)
                {
                    MessageBox.Show("Valor excede o saldo");
                    txtValor.Clear();
                    return;
                }
                lblSaldo.Text = $"R$ {saldo - valor}";

                saldo = saldo - valor;
            }
            else
            {
                lblSaldo.Text = $"R$ {saldo + valor}";

                saldo = saldo + valor;
            }

            txtValor.Clear();
        }
    }
}
