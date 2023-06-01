using BancoEnviarPixOO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoEnviarPixOO.View
{
    public partial class FormUnica : Form
    {
        ClienteB1 cliente1 = new ClienteB1();
        ClienteB2 cliente2 = new ClienteB2();
        public FormUnica()
        {
            InitializeComponent();
            lbl_nomeb1.Text = cliente1.nome;
            lbl_cpfb1.Text = cliente1.cpf;
            lb_nomedestinob1.Text = cliente2.nome;
            lb_cpfdestinob1.Text = cliente2.cpf;

            lbl_nomeb2.Text = cliente2.nome;
            lbl_cpfb2.Text = cliente2.cpf;
            lb_nomedestinob2.Text = cliente1.nome;
            lb_cpfdestinob2.Text= cliente1.cpf;
        }

        private void bnt_saldob1_Click(object sender, EventArgs e)
        {
            lbl_saldob1.Text = Convert.ToString(cliente1.saldo);
        }

        private void bnt_saldob2_Click(object sender, EventArgs e)
        {
            lbl_saldob2.Text = Convert.ToString(cliente2.saldo);
        }

        private void btn_transferirb1_Click(object sender, EventArgs e)
        {
            if ( cliente2.saldo >= Convert.ToInt16(txtvalorb1.Text))
            {
                cliente2.saldo += Convert.ToInt16(txtvalorb1.Text);
                cliente1.saldo -= Convert.ToInt16(txtvalorb1.Text);
            }
            else
            {
                MessageBox.Show("Sinto muito...");
            }
            
            
            
        }

        private void btn_transferirb2_Click(object sender, EventArgs e)
        {
            cliente1.saldo += Convert.ToInt16(txtvalorb2.Text);
            cliente2.saldo -= Convert.ToInt16(txtvalorb2.Text);

        }
    }
}
