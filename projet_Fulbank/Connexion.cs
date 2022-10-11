using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BigInteger = System.Numerics.BigInteger;

namespace projet_Fulbank
{

    public partial class Connexion : Form
    {
        Menu menu;
        //Admin admin;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;


        public Connexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Set to no text.
            // The password character is an asterisk.
            password_textbox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            password_textbox.MaxLength = 14;
        }

        /// <summary>
        ///     Button de connexion
        /// </summary>
        /// <param name="sender" type="object"></param>
        /// <param name="e" type="EventArgs"></param>
        private void connexion_button_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                long login = long.Parse(identifiant_textbox.Text.ToString());//On récupère le champ identifiant
                string password = password_textbox.Text; //On récupère le champ mot de passe
                //string hash = User.GetHash(sha256Hash, password);

                User user = UserManager.FindByLogin(login);

                if (login == user.getLogin() && User.VerifyHash(sha256Hash, password, passwordDB) && typeOfPerson == 1)
                {
                    menu = new Menu();
                    this.Hide();
                    menu.lastName = reader["lastName"].ToString();
                    menu.accountNumber = reader["login"].ToString();
                    menu.Show();
                }
                else if (login == loginDB && User.VerifyHash(sha256Hash, password, passwordDB) && typeOfPerson == 2)
                {
                    admin = new Admin();
                    this.Hide();
                    admin.lastName = reader["lastName"].ToString();
                    admin.accountNumber = reader["login"].ToString();
                    admin.show();

                }
                else if (login == loginDB && !User.VerifyHash(sha256Hash, password, passwordDB))
                {
                    MessageBox.Show("Votre mot de passe est incorrect");
                    password_textbox.Clear();
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier vos informations");
                }
                reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
