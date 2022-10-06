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
        public string lastName;
        public string accountNumber;
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
            lastNameLabel.Text = "Nom :" + lastName;
            accountNumberLabel.Text ="Numéro de compte :" + accountNumber;
        }

        private void achat_crypto_Click(object sender, EventArgs e)
        {
            var AchatCrypto1 = new Achat_de_cryptomonnaies1();
            AchatCrypto1.Show();
        }
    }
}
