using System;
using System.Collections;
using System.Windows.Forms;

namespace ex_bank
{
    public partial class FrmConta : Form
    {
        public FrmConta()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ExBank";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxSaldo.Text = "0,00";
            cboBoxTitular.DataSource = PreencheCboBoxTitularFavorecido();
            cboBoxFavorecido.DataSource = PreencheCboBoxTitularFavorecido();
        }

        Conta titular = new Conta { };
        Conta favorecido = new Conta { };

        Conta fernando = new Conta
        {
            Nome = "Fernando",
            Sobrenome = "M. Oliveira",
            Numero = 1,
            Saldo = 0.00
        };

        Conta fulano = new Conta
        {
            Nome = "Fulano",
            Sobrenome = "da Silva",
            Numero = 2,
            Saldo = 0.00
        };

        Conta sicrano = new Conta
        {
            Nome = "Sicrano",
            Sobrenome = "Dias",
            Numero = 3,
            Saldo = 0.00
        };

        public ArrayList PreencheCboBoxTitularFavorecido()
        {
            ArrayList contas = new ArrayList
            {
                "Selecione...",
                (fernando.Nome + " " + fernando.Sobrenome),
                (fulano.Nome + " " + fulano.Sobrenome),
                (sicrano.Nome + " " + sicrano.Sobrenome)
            };
            return contas;
        }

        public Boolean Verifica_Selecao_Titular()
        {
            if (cboBoxTitular.SelectedItem.Equals("Selecione..."))
            {
                MessageBox.Show("Selecione o TITULAR.");
                return false;
            }
            return true;
        }

        public void Habilita_Botoes()
        {
            if (cboBoxTitular.SelectedIndex != 0)
            {
                Definir_Titular();
                Atualizar_Info(titular);
                if (cboBoxFavorecido.SelectedIndex != 0)
                {
                    Definir_Favorecido();
                    if (cboBoxTitular.SelectedIndex.Equals(cboBoxFavorecido.SelectedIndex))
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

        public Boolean Valor_vazio()
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

        public Conta Definir_Titular()
        {
            switch (cboBoxTitular.SelectedIndex)
            {
                case 1:
                    titular = fernando;
                    break;
                case 2:
                    titular = fulano;
                    break;
                case 3:
                    titular = sicrano;
                    break;
                default:
                    MessageBox.Show("Ocorreu um erro ao selecionar o Titular!");
                    break;
            }

            return titular;
        }

        public Conta Definir_Favorecido()
        {
            switch (cboBoxFavorecido.SelectedIndex)
            {
                case 1:
                    favorecido = fernando;
                    break;
                case 2:
                    favorecido = fulano;
                    break;
                case 3:
                    favorecido = sicrano;
                    break;
                default:
                    MessageBox.Show("Ocorreu um erro ao selecionar o Favorecido!");
                    break;
            }

            return favorecido;
        }

        public void Atualizar_Info(Conta titular)
        {
            txtValor.Text = null;
            txtBoxInfoTitular.Text = titular.Nome;
            txtBoxSaldo.Text = String.Format("{0:0.00}", titular.Saldo);
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            if (Valor_vazio() && Verifica_Selecao_Titular())
            {
                titular.Deposito(Recupera_Valor(), favorecido);
                Atualizar_Info(titular);
            }
        }

        private void BtnSaque_Click(object sender, EventArgs e)
        {
            if (Valor_vazio() && Verifica_Selecao_Titular())
            {
                if (titular.Saque(Recupera_Valor(), favorecido))
                {
                    Atualizar_Info(titular);
                }
                else
                {
                    MessageBox.Show("Não existe saldo suficiente (" 
                        + String.Format("{0:0.00}", titular.Saldo) 
                        + ") para realizar a transferência!");
                    txtValor.Text = null;
                }
            }
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            if (Valor_vazio() && Verifica_Selecao_Titular())
            {
                if (titular.Transfere(Recupera_Valor(), titular, favorecido))
                {
                    Atualizar_Info(titular);
                }
                else
                {
                    MessageBox.Show("Não existe saldo suficiente (" 
                        + String.Format("{0:0.00}", titular.Saldo) 
                        + ") para realizar a transferência!");
                    txtValor.Text = null;
                }
            }
        }

        private void CboBoxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxFavorecido.SelectedIndex != -1)
            {
                Habilita_Botoes();
                cboBoxFavorecido.SelectedIndex = 0;
            }
        }

        private void cboBoxFavorecido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilita_Botoes();
        }
    }
}
