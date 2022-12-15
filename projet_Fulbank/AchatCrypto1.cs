using projet_Fulbank.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_Fulbank
{
    public partial class Achat_de_cryptomonnaies1 : Form
    {
        public Achat_de_cryptomonnaies1()
        {
            InitializeComponent();
        }

        private void Achat_de_cryptomonnaies1_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            var listeCryptocrurrencies = AppelsAPI.RequeteAPI(); 
            foreach (var currency in listeCryptocrurrencies.data) //une boucle pour ajouter 3 cryptomonnaies qu'on va gerer dans la liste 
            {
                typecrypto.Items.Add(currency.name);
            }
            typecrypto.SelectedIndex = 0; //nous y mettons une valeur par default 
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void continuer_Click(object sender, EventArgs e)
        {
            Achat_de_cryptomonnaies2 AchatCrypto2 = new Achat_de_cryptomonnaies2();
            this.Hide();
            AchatCrypto2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (AppelsAPI.GetAmountCrypto(typecrypto.SelectedItem.ToString(), float.Parse(textBox1.Text))).ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "0"; //le cas ou l'utilisateur essaye de convertir plus d'argeant qu'il a 
                MessageBox.Show("Saisisez une valeur valide");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
