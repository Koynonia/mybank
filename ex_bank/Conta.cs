namespace ex_bank
{
    public class Conta
    {
        private int numero;
        private double saldo;
        private Cliente titular;

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposito(double valor, Conta conta)
        {
            conta.Saldo += valor;
        }

        public virtual bool Saque(double valor, Conta conta)
        {
            if (conta.Saldo >= valor)
            {
                conta.Saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transfere(double valor, Conta conta, Conta favorecido)
        {
            if (conta.Saque(valor, conta))
            {
                conta.Deposito(valor, favorecido);
                return true;
            }
            return false;
        }
    }
}
