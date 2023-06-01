using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPixOO.Controller
{
    internal class ClienteB1
    {
        //Atributos
        public string nome = "Lucas";
        public string cpf = "133.234.156-70";
        public float saldo = 1000;


        //Metodos
        public float VerSaldo()
        {
            
            return saldo;
        }

        public string EnviarPix(string cpf, float valor)
        {
            string msg = "";

            if(saldo >= valor)
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
