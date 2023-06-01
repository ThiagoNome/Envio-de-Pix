using BancoEnviarPixOO.Controller;
using BancoEnviarPixOO.Model;
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
    public partial class TelaBanco1 : Form
    {
        public TelaBanco1()
        {
            InitializeComponent();
        }

        ClienteB1 cliente = new ClienteB1();
        
        private void TelaBanco1_Load(object sender, EventArgs e)
        {
                
            lbl_nomeb1.Text = cliente.nome;
            lbl_cpfb1.Text = cliente.cpf;
        }

        private void lbl_saldob1_Click(object sender, EventArgs e)
        {
            lbl_saldob1.Text = cliente.saldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_saldob1.Text = cliente.saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPix pix = new TelaPix();
            pix.Show();
            
            

        }
    }
}
