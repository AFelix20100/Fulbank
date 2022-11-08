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
    public partial class PrixCrypto : Form
    {
        public PrixCrypto()
        {
            InitializeComponent();
        }

        private void PrixCrypto_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            string location = "";
            /*for (int i=0; i<3; i++)
            {
                location = 
            }
            */
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }
    }
}
