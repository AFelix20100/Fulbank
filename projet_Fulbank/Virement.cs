using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using projet_Fulbank.Class;

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
            else
            {
                int retrait = int.Parse(TransfertSum.Text);
                int sold = (int)Convert.ToInt64(reader["sold"]);
            }
        }

        private void Virement_Load(object sender, EventArgs e)
        {
            VirementLastName.Text = "Nom : " + lastName; 
            VirementAccountNumber.Text = "Numéro de compte : " + accountNumber;
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "SELECT Sold FROM Account A INNER JOIN Person P ON A.idPerson = P.id WHERE P.Login = " + Connexion.accountNumber;
            reader = command.ExecuteReader();
            reader.Read();
            string solde_deb = reader["Sold"].ToString();
            test.Text = solde_deb;

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

        private void deb_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deb_booklet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void transfert_Click(object sender, EventArgs e)
        {   
            pdo.Open();
            command = pdo.CreateCommand();
            if (deb_current.Checked)
            {
                command.CommandText = "SELECT Sold FROM Account WHERE idTypeOfAccount = 1 ";
                reader = command.ExecuteReader();
                string solde_deb = reader["Sold"].ToString();          
                test.Text = solde_deb;
            }

        }

        private void cred_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
