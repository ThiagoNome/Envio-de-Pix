using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPixOO.Controller
{
    internal class ClienteB2
    {
        //Atributos
        public string nome = "Bianca";
        public string cpf = "293.123.543-91";
        public float saldo = 5000;


        //Metodos
        public float VerSaldo()
        {

            return saldo;
        }

        public string EnviarPix(string cpf, float valor)
        {
            string msg = "";

            if (saldo >= valor)
            {
                this.saldo = valor - saldo;
                //BANCO CENTRAL AQUI
                msg = "Pix enviado com sucesso.";

            }
            else
            {
                msg = "Saldo insuficiente.";
            }

            return msg;
        }
    }
}
