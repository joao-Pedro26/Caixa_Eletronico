using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btSacar_Click(object sender, EventArgs e)
        {
            double valor, saldo = 0;
            valor = (double)numOper_valor.Value;

            saldo -= valor;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            double valor;
           
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            double valor, saldo = 0;
            valor =(double)numOper_valor.Value;

            saldo += valor;
            
            lblSaldo.Text = saldo.ToString("c");
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
