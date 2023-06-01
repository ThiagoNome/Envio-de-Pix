using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPixOO.Model
{
     class Banco1
    {
        private string nome;
        private string cpf;
        private float saldo;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public float Saldo { get => saldo; set => saldo = value; }
    }
}
