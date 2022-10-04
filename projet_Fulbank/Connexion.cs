using MySql.Data.MySqlClient;
using projet_Fulbank.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_Fulbank
{

    public partial class Connexion : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        SHA256 sha256Hash;

        public Connexion()
        {
            InitializeComponent();
            identifiant_textbox.Text =

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void identifiant_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///     Button de connexion
        /// </summary>
        /// <param name="sender" type="object"></param>
        /// <param name="e" type="EventArgs"></param>
        private void connexion_button_Click(object sender, EventArgs e)
        {

            long login = long.Parse(identifiant_textbox.Text.ToString());//On récupère le champ identifiant
            string password = password_textbox.Text; //On récupère le champ mot de passe
            string hash = User.GetHash(sha256Hash, password);

            command.CommandText = "SELECT * FROM Person WHERE login =" + identifiant_textbox.Text; //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL


            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    long loginDB = long.Parse(reader["login"].ToString());//On récupère le champ login
                    string passwordDB = reader["password"].ToString();//On récupère le champ password

                    if (login == loginDB && User.VerifyHash(sha256Hash, hash, passwordDB))
                    {
                        menu = new Menu();
                        this.Hide();
                        menu.lastName = reader["lastName"].ToString();
                        menu.accountNumber = reader["login"].ToString();
                        menu.Show();
                    }
                    else if (login == loginDB && !User.VerifyHash(sha256Hash, hash, passwordDB))
                    {
                        MessageBox.Show("Votre mot de passe est incorrect");
                        password_textbox.Clear();
                    }

                }
            }
            else
            {
                MessageBox.Show("Veuillez vérifier vos informations");
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            // Lecture des résultats 
            
        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
