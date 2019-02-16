using System;
using System.Collections;
using System.Windows.Forms;

namespace mybank
{
    public partial class FrmConta : Form
    {
        //private Cliente cliente;
        private Conta[] contas;
        private TotalizadorDeContas contaTotal;

        public FrmConta()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MyBank";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSaldo.Text = "0,00";
            cboTitular.DataSource = Preenche_Combos();
            cboFavorecido.DataSource = Preenche_Combos();

            // criando o array para guardar as contas
            contas = new Conta[3];

            // Inicializando algumas instâncias de Conta.
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Fernando", "M. Oliveira", 48, "emancipacao", "11122233344");
            this.contas[0].Numero = 1;

            this.contas[1] = new Poupanca();
            this.contas[1].Titular = new Cliente("Fulano", "da Silva", 32, "emancipacao", "22211133344");
            this.contas[1].Numero = 2;

            this.contas[2] = new Corrente();
            this.contas[2].Titular = new Cliente("Sicrano", "Dias", 16, "", "11133322244");
            this.contas[2].Numero = 3;
        }

        public ArrayList Preenche_Combos()
        {
            ArrayList listaNomes = new ArrayList
            {
                "Selecione...",
                "Fernando M. Oliveira",
                "Fulano da Silva",
                "Sicrano Dias"
            };
            return listaNomes;
        }

        public Boolean Verifica_Selecao_Titular()
        {
            if (cboTitular.SelectedItem.Equals("Selecione..."))
            {
                MessageBox.Show("Selecione o TITULAR.");
                return false;
            }
            return true;
        }

        public void Habilita_Botoes()
        {
            int indice = cboTitular.SelectedIndex - 1;

            if (cboTitular.SelectedIndex != 0)
            {
                Atualizar_Info(this.contas[indice]);

                if (cboFavorecido.SelectedIndex != 0)
                {
                    Atualizar_Info(this.contas[indice]);

                    if (cboTitular.SelectedIndex.Equals(cboFavorecido.SelectedIndex))
                    {
                        btnDeposito.Enabled = true;
                        btnSaque.Enabled = true;
                        btnTransferir.Enabled = false;
                    }
                    else
                    {
                        btnDeposito.Enabled = true;
                        btnSaque.Enabled = false;
                        btnTransferir.Enabled = true;
                    }
                }
                else
                {
                    btnDeposito.Enabled = false;
                    btnSaque.Enabled = false;
                    btnTransferir.Enabled = false;
                }
            }
        }

        public Boolean Valor_Vazio()
        {
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Entre com o VALOR.");
                return false;
            }
            return true;
        }

        public Double Recupera_Valor()
        {
            double valor = Convert.ToDouble(txtValor.Text);
            return valor;
        }

        public void Atualizar_Info(Conta titular)
        {
            txtValor.Text = null;
            txtInfoTitular.Text = contas[0].Titular.Nome;
            txtConta.Text = Convert.ToString(titular.Numero);
            txtSaldo.Text = String.Format("{0:0.00}", titular.Saldo);
        }
        public bool Validar_Conta
        {
            get
            {
                var maiorDeIdade = this.contas[0].Titular.Idade >= 18;
                var emancipado = this.contas[0].Titular.Documento.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.contas[0].Titular.Cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            if (Valor_Vazio() && Verifica_Selecao_Titular())
            {
                this.contas[0].Deposito(Recupera_Valor(), contas[0]);
                Atualizar_Info(contas[0]);
            }
        }

        private void BtnSaque_Click(object sender, EventArgs e)
        {
            if (Valor_Vazio() && Verifica_Selecao_Titular())
            {
                if (this.contas[0].Saque(Recupera_Valor(), contas[0]))
                {
                    Atualizar_Info(contas[0]);
                }
                else
                {
                    MessageBox.Show("Não existe saldo suficiente ("
                        + String.Format("{0:0.00}", contas[0].Saldo)
                        + ") para realizar a transferência!");
                    txtValor.Text = null;
                }
            }
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            if (Valor_Vazio() && Verifica_Selecao_Titular())
            {
                if (this.contas[0].Transfere(Recupera_Valor(), contas[0], contas[0]))
                {
                    Atualizar_Info(contas[0]);
                }
                else
                {
                    MessageBox.Show("Não existe saldo suficiente ("
                        + String.Format("{0:0.00}", contas[0].Saldo)
                        + ") para realizar a transferência!");
                    txtValor.Text = null;
                }
            }
        }

        private void CboTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFavorecido.SelectedIndex != -1)
            {
                Habilita_Botoes();
                cboFavorecido.SelectedIndex = 0;
            }
        }

        private void CboFavorecido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilita_Botoes();
        }
    }
}
