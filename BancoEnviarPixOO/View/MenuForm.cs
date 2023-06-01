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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_banco1_Click(object sender, EventArgs e)
        {
            TelaBanco1 banco1 = new TelaBanco1();
            banco1.Show();
            //this.Hide();
            //banco1.Closed += (s, args) => this.Close();
        }

        private void btn_banco2_Click(object sender, EventArgs e)
        {
            TelaBanco2 banco2 = new TelaBanco2();
            banco2.Show();
            //this.Hide();
            //banco2.Closed += (s, args) => this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
