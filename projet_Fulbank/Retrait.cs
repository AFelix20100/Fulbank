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
    public partial class Retrait : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public Retrait()
        {
            InitializeComponent();
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
           menu= new Menu();
            menu.Show(this);
           
           
           
        }

        private void SoldText_TextChanged(object sender, EventArgs e)
        {
        }

        private void Retrait_Load(object sender, EventArgs e)
        {
            lastNameLabel.Text = "Nom : " + lastName;
            accountNumberLabel.Text = "Numéros de compte : " + accountNumber;
            pdo.Open();
            command = pdo.CreateCommand();

            command.CommandText = "SELECT Sold FROM Account A INNER JOIN Person P ON A.idPerson = P.id WHERE P.Login = " + accountNumber;
            reader = command.ExecuteReader();
            reader.Read();
            string solde = reader["Sold"].ToString() + " €";
            SoldText.Text = solde;
            
        }

        private void SoldAfterText_TextChanged(object sender, EventArgs e)
        {     
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void DebiteSumText_TextChanged(object sender, EventArgs e)
        {
            if (DebiteSumText.Text == "")
            {
                SoldAfterText.Text = reader["Sold"].ToString() + " €";
                MessageBox.Show("Entrez une valeur");
            }
            else
            {
                int retrait = int.Parse(DebiteSumText.Text);
                int sold = (int)Convert.ToInt64(reader["Sold"]);
                SoldAfterText.Text = (sold - retrait).ToString();
            }
            

            
        }

        private void retirer_Click(object sender, EventArgs e)
        {
            pdo.Close();
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account SET Sold = " + int.Parse(SoldAfterText.Text) + " WHERE idPerson = (SELECT id FROM Person WHERE login = " + accountNumber + ")";
            reader = command.ExecuteReader();
            reader.Read();
        }
        
    }
}
