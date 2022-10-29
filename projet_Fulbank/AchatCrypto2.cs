using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace projet_Fulbank
{
    public partial class Achat_de_cryptomonnaies2 : Form
    {
        public Achat_de_cryptomonnaies2()
        {
            InitializeComponent();
        }

        private void Achat_de_cryptomonnaies2_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();

            soldecompte.Text = AccountManager.getSoldeBDD(UserManager.getUser()).ToString();
            var listeCryptocrurrencies = AppelHTTPS.RequeteHTTPS();
            foreach (var currency in listeCryptocrurrencies.data)
            {
                comboBox1.Items.Add(currency.name.ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void soldecompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void montant_debiter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(montant_debiter.Text) > float.Parse(soldecompte.Text))
                {
                    montant_debiter.Text = "0";
                    MessageBox.Show("Solde insuffisant");
                }
                else
                {
                    soldecrypto.Text = (AppelHTTPS.GetAmountCrypto(comboBox1.SelectedItem.ToString(), float.Parse(montant_debiter.Text))).ToString();
                    solderetrait.Text = (float.Parse(soldecompte.Text) - float.Parse(montant_debiter.Text)).ToString();
                }
            }
            catch (FormatException exc)
            {
                montant_debiter.Text = "0";
                MessageBox.Show("Saissez une valeur valide");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //setter
            MessageBox.Show("Transaction éffectuée");
        }
    }
}
