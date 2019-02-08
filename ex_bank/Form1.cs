using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_bank
{
    public partial class FrmConta : Form
    {
        Conta ct = new Conta();

        string[,] dataBase = new string[3, 4] {
            { "1", "Fernando", "M. Oliveira", "0" },
            { "2", "Fulano", "da Silva", "0" },
            { "3", "Sicrano", "Dias", "0" }
        };

        public ArrayList PreencheCboBoxTitularFavorecido()
        {
            for (int x = 0; x < dataBase.GetLength(0); x++)
            {
                for (int y = 0; y < dataBase.GetLength(1); y++)
                {
                    //Console.WriteLine(Convert.ToString (dataBase[x, y]));
                }
            }


            int i = 0, j =0;

            foreach (PropertyInfo inf in typeof(Conta).GetProperties())
            {
                inf.SetValue(ct, Convert.ChangeType(dataBase[i,j], inf.PropertyType));
                i++;
                j++;
            }
            Console.WriteLine("Conta: {0}", ct.Numero);
            Console.WriteLine("Nome: {0}", ct.Nome + " " + ct.Sobrenome);
            Console.WriteLine("Saldo: {0}", ct.Saldo);






            ArrayList contas = new ArrayList
            {
                (ct.Nome = "Fernando M. Oliveira"),
                (ct.Nome = "Fulano da Silva"),
                (ct.Nome = "Sicrano Dias")
            };

            return contas;
        }

        Conta fernando = new Conta
        {
            Nome = "Fernando M. Oliveira",
            Numero = 1,
            Saldo = 0.00
        };

        Conta fulano = new Conta
        {
            Nome = "Fulano",
            Numero = 2,
            Saldo = 0.00
        };

        public FrmConta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxSaldo.Text = "0,00";

            cboBoxTitular.DataSource = PreencheCboBoxTitularFavorecido();
            cboBoxTitular.DisplayMember = "Nome";
            //cboBoxTitular.ValueMember = "Número";
            
            //cboBoxFavorecido.DataSource = PreencheCboBoxTitularFavorecido();
            //cboBoxFavorecido.DisplayMember = "Nome";
            //cboBoxFavorecido.ValueMember = "Número";
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(txtValor.Text))
            {
                double valor = Convert.ToDouble(txtValor.Text);

                fernando.Deposito(valor, fernando);
                MessageBox.Show("Cliente: " + fernando.Nome + "\nSaldo: R$ " + fernando.Saldo);
            }


            //MessageBox.Show("Cliente: " + fernando.titular + "\nSaldo Inicial: R$ " + fernando.saldo);
            //MessageBox.Show("Cliente: " + fulano.titular + "\nSaldo Inicial: R$ " + fulano.saldo);
             
            //fernando.Transfere(vlrTransferencia, fulano);
            //MessageBox.Show("Cliente: " + fernando.titular + "\nSaldo: R$ " + fernando.saldo);
            //MessageBox.Show("Cliente: " + fulano.titular + "\nSaldo: R$ " + fulano.saldo);

        }

        private void BtnSaque_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValor.Text))
            {
                double valor = Convert.ToDouble(txtValor.Text);

                fernando.Saque(50);
                MessageBox.Show("Cliente: " + fernando.Nome + "\nSaldo: R$ " + fernando.Saldo);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {

        }
    }
}
