using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lastNameLabel.Text = "Nom :" + Program.lastName;
            accountNumberLabel.Text ="Numéro de compte :" + Program.accountNumber;
        }

        private void achat_crypto_Click(object sender, EventArgs e)
        {
            var AchatCrypto1 = new Achat_de_cryptomonnaies1();
            AchatCrypto1.Show();
        }

        private void retrait_Click(object sender, EventArgs e)
        {
            this.Hide();
            var retrait = new Retrait();
            retrait.Show();
        }

        private void voir_crypto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prixcrypto = new PrixCrypto();
            prixcrypto.Show();

        }

        private void virement_Click(object sender, EventArgs e)
        {
            this.Hide();
            var virement = new Virement();
            virement.Show();
        }

        private void comptes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var choixcompte = new ChoixCompte();
            choixcompte.Show();
        }

        private void conversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var conversion = new Conversion();
            conversion.Show();
        }
    }
}
