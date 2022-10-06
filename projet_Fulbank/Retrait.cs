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
using projet_Fulbank.Class;

namespace projet_Fulbank
{
    public partial class Retrait : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
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
        }

        private void SoldText_TextChanged(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Sold FROM Account A INNER JOIN Person P ON A.idPerson = P.id WHERE P.Login = " + menu.accountNumber;
            reader = command.ExecuteReader();

            SoldText.Text = reader["Sold"].ToString();

        }

        private void Retrait_Load(object sender, EventArgs e)
        {
            pdo.Open();
            command = pdo.CreateCommand();
        }

        private void SoldAfterText_TextChanged(object sender, EventArgs e)
        {
             int retrait = int.Parse(DebiteSumText.Text);
         
            
          
        }

        
    }
}
