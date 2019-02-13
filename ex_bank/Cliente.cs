namespace ex_bank
{
    public class Cliente
    {
        
        private string nome;
        private string sobrenome;
        private int idade;
        private string documento;
        private string cpf;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string sobrenome, int idade, string documento, string cpf)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Documento = documento;
            this.Cpf = cpf;
        }

    }
}