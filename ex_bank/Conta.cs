using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex_bank
{
    public class Conta
    {
        private int numero;
        private string nome;
        private string sobrenome;
        private double saldo;

        public int Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        public void Deposito(double valor, Conta destino)
        {
            destino.Saldo +=valor;
        }

        public bool Saque(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }

            return false;
        }

        public bool Transfere(double valor, Conta destino)
        {
            if(this.Saque(valor))
            {
                this.Deposito(valor, destino);
                return true;
            }

            return false;
        }
    }
}
