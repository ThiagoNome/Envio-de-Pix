using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPixOO.Controller
{
    internal class BancoCentral
    {
        //atributos
        string cpforigin;
        string cpfdestino;
        string bancoorigin;
        string bancodestino;
        float valor;


        //metodos
        public int Transferir(string cpforigin, string cpfdestino, string bancoorigin,string bancodestino, float valor)
        {
            //if (bancodestino == "banco1")
            //{
                ClienteB2 banco2 = new ClienteB2();
                banco2.saldo += valor;
            //}else
            //{

            //}

            return 0;
        }
    }
}
