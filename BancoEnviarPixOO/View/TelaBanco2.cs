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
    public partial class TelaBanco2 : Form
    {
        public TelaBanco2()
        {
            InitializeComponent();
        }
        ClienteB2 cliente = new ClienteB2();
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_saldob2.Text = cliente.saldo.ToString();
        }

        private void TelaBanco2_Load(object sender, EventArgs e)
        {
            lbl_nomeb2.Text = cliente.nome;
            lbl_cpfb2.Text = cliente.cpf;
        }

        private void lbl_saldob2_Click(object sender, EventArgs e)
        {
            lbl_saldob2.Text = cliente.saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPix pix = new TelaPix();
            pix.Show();
        }
    }
}
