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
using projet_Fulbank.Class;

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
            var listeCryptocrurrencies = AppelsAPI.RequeteAPI(); 
            foreach (var currency in listeCryptocrurrencies.data) //une boucle pour ajouter 3 cryptomonnaies qu'on va gerer dans la liste 
            {
                comboBox1.Items.Add(currency.name.ToString());
            }
            comboBox1.SelectedIndex = 0; //nous y mettons une valeur par default 
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
                    montant_debiter.Text = "0"; //le cas ou l'utilisateur essaye de convertir plus d'argeant qu'il a 
                    MessageBox.Show("Solde insuffisant");
                }
                else
                {
                    soldecrypto.Text = (AppelsAPI.GetAmountCrypto(comboBox1.SelectedItem.ToString(), float.Parse(montant_debiter.Text))).ToString();
                    solderetrait.Text = (float.Parse(soldecompte.Text) - float.Parse(montant_debiter.Text)).ToString();
                }
            }
            catch (FormatException exc)
            {
                montant_debiter.Text = "0"; //si l'utilisateur met un character autre qu'une chiffre on remplace le texte qu'il a asaisi avec un 0 
                MessageBox.Show("Saissez une valeur valide");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
            MessageBox.Show("Transaction effectuée");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AccountManager.removeCash(UserManager.getUser(),float.Parse(solderetrait.Text));
            User user = UserManager.getUser();
            double soldeBDD = AccountManager.getSoldeBDD(user);
            OperationManager.withdrawal(Convert.ToDouble(Double.Parse(solderetrait.Text)));
            OperationManager.PurchaseCrypto(comboBox1.SelectedItem.ToString(), Convert.ToDouble(soldecrypto.Text), soldeBDD - Convert.ToDouble(solderetrait.Text));
            Root root = AppelsAPI.RequeteAPI();
            WalletManager.addCryptotoAccount(comboBox1.SelectedIndex.ToString(), UserManager.getUser(), soldecrypto.Text, root.data[comboBox1.SelectedIndex].priceUsd.ToString());
        }

        private void soldecrypto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
