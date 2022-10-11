using MySql.Data.MySqlClient;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace projet_Fulbank.Class.Model
{
    public class UserManager
    {
        private static User user = null;

        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;

        public static User getUser()
        {
            if (user == null)
            {
                Connexion connexion = new Connexion();
                connexion.Show();
            }
            return user;
        }

        public static void setUser(User user)
        {
            UserManager.user = user;
        }

        public static User FindByLogin(long unLogin)
        {
            //MySqlConnection pdo = DBConnexion.getConnexion();
            //MySqlCommand command = new MySqlCommand();
            pdo.Open();
            command = pdo.CreateCommand();
            int id = 0;
            string lastName = "";
            string firstName = "";
            string mail = "";
            double phone = 0;
            string adress = "";
            int pc = 0;
            string city = "";
            string country = "";
            long loginDB = 0;
            string passwordDB = "";
            int typeOfPerson = 0;
            command.CommandText = "SELECT * FROM Person WHERE login =" + unLogin; //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32(reader["id"]);
                    lastName = reader["lastName"].ToString();
                    firstName = reader["firstName"].ToString();
                    mail = reader["mail"].ToString();
                    phone = Convert.ToInt32(reader["phone"]);
                    adress = reader["adress"].ToString();
                    pc = Convert.ToInt32(reader["pc"]);
                    city = reader["city"].ToString();
                    country = reader["country"].ToString();
                    loginDB = long.Parse(reader["login"].ToString());//On récupère le champ login
                    passwordDB = reader["password"].ToString();//On récupère le champ password
                    typeOfPerson = Convert.ToInt32(reader["idTypeOfPerson"]);
                }
            }
            else
            {
                MessageBox.Show("Veuillez vérifier vos informations");
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return new User(id, lastName, firstName, mail, phone, adress, pc, city, country, loginDB, passwordDB, typeOfPerson);
        }

        public void save()
        {
            pdo.Open();
            command = pdo.CreateCommand();

            command.CommandText = "UPDATE Person SET type, "; //Requête SQL
            command.ExecuteNonQuery();//On exécute la requête SQL
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }
    }
}
