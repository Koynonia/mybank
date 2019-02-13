namespace ex_bank
{
    internal class Corrente : Conta
    {
        public override bool Saque(double valor, Conta conta)
        {
            if (base.Saldo >= valor)
            {
                base.Saque(valor +=0.10, conta);
                return true;
            }
            return false;
        }
    }
}