namespace mybank
{
    internal class Poupanca : Conta
    {
        public override bool Saque(double valor, Conta conta)
        {
            if (base.Saldo >= valor)
            {
                base.Saque(valor, conta);
                return true;
            }
            return false;
        }

        public void CalculaRendimento()
        {
            // ...
        }
    }

}