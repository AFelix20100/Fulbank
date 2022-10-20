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
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Achat_de_cryptomonnaies1 crypto = new Achat_de_cryptomonnaies1();
            this.Hide();
            crypto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void soldecompte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
