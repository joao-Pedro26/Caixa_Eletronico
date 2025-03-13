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
        double saldo = 0;
        private void btSacar_Click(object sender, EventArgs e)
        {
            double valor;
            valor = (double)numOper_valor.Value;
            btSacar.Enabled =
                !((double)numOper_limite.Value > valor);
            saldo -= valor;
            lblSaldo.Text = saldo.ToString("c");

            numOper_valor.Value = 0;

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            double valor;
            valor =(double)numOper_valor.Value;

            saldo += valor;
            
            lblSaldo.Text = saldo.ToString("c");

            numOper_valor.Value = 0;
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        double taxa = 0.001;
        private void tmrJuros_Tick(object sender, EventArgs e)
        {   
            saldo += saldo * taxa;
            lblSaldo.Text = saldo.ToString("c");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text = $"* Taxa: {taxa * 100}% a.c {tmrJuros.Interval / 1000} s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?", 
                "Atenção!!!", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) 
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau, fudido!", "SEU BOSTA");
        }
    }
}
