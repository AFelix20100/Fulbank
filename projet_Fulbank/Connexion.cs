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
        public static string lastName;
        public static long accountNumber;
        Menu menu;
        Administration admin;
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
                
                lastName = user.getLastName();
                accountNumber = user.getLogin();
                if (login == user.getLogin() && User.VerifyHash(sha256Hash, password, user.getPassword()) && user.getType() == 1)
                {
                    UserManager.setUser(user);
                    menu = new Menu();
                    this.Hide();
                    menu.lastName = user.getLastName();
                    menu.accountNumber = user.getLogin();
                    menu.Show();
                }
                else if (login == user.getLogin() && User.VerifyHash(sha256Hash, password, user.getPassword()) && user.getType() == 2)
                {
                    
                    admin = new Administration();
                    this.Hide();
                    admin.lastName = user.getLastName();
                    admin.accountNumber = user.getLogin().ToString();
                    admin.Show();
                    
                }
                else if (login == user.getLogin() && !User.VerifyHash(sha256Hash, password, user.getPassword()))
                {
                    MessageBox.Show("Votre mot de passe est incorrect");
                    password_textbox.Clear();
                }
                
                //On ferme le Reader pour éviter d'avoir d'autres instance de reader
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
