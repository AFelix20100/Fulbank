using MySql.Data.MySqlClient;
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

namespace projet_Fulbank
{
    public partial class Virement : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public Virement()
        {
            InitializeComponent();

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void somme_virement_TextChanged(object sender, EventArgs e)
        {
            if (TransfertSum.Text == "")
            {
                MessageBox.Show("Veuillez saisir une valeur");
            }
        }

        private void Virement_Load(object sender, EventArgs e)
        {
            VirementLastName.Text = "Nom : " + lastName; 
            VirementAccountNumber.Text = "Numéro de compte : " + accountNumber;
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "SELECT Sold FROM Account A INNER JOIN Person P ON A.idPerson = P.id WHERE P.Login = " + accountNumber;

        }

        private void beneficiary_Click(object sender, EventArgs e)
        {
            this.Hide();
            var beneficiaire = new Beneficiare();
            beneficiaire.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void deb_courant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deb_livret_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void transfert_Click(object sender, EventArgs e)
        {
            pdo.Close();
            pdo.Open();
            command = pdo.CreateCommand();


        }
    }
}
