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
    public partial class TelaPix : Form
    {
        public TelaPix()
        {
            InitializeComponent();
        }
        ClienteB1 cliente1 = new ClienteB1();
        ClienteB2 cliente2 = new ClienteB2();
        private void lb_nomeOrigin_Click(object sender, EventArgs e)
        {
            
        }

        public void TelaPix_Load(object sender, EventArgs e)
        {
            
            lb_nomeOrigin.Text = cliente1.nome;
            lb_cpforigin.Text = cliente1.cpf;
            lb_saldoorigin.Text = cliente1.saldo.ToString();

            lb_nomedestino.Text = cliente2.nome;
            lb_cpfdestino.Text = cliente2.cpf;
                
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            string bancoorigin = "banco1";
            string bancodestino = "banco2";
            float valor = Convert.ToInt16(textBox1.Text);

            BancoCentral banco = new BancoCentral();
            banco.Transferir(cliente1.cpf, cliente2.cpf, bancoorigin, bancodestino, valor);

            cliente2.saldo += valor;

            MessageBox.Show("Dados Transferiros com sucesso. " + cliente2.saldo);

        }
    }
}
