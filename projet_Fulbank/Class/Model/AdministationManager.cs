using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank.Class.Model
{
    public class AdministationManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;

        public static List<User> getAllUsers()
        {
            List<User> Allusers = new List<User>();

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
            command.CommandText = "SELECT * FROM Person"; //Requête SQL
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
                    passwordDB = reader["password"].ToString(); 
                    typeOfPerson = Convert.ToInt32(reader["idTypeOfPerson"]);

                    Allusers.Add(new User(id, lastName, firstName, mail, phone, adress, pc, city, country, loginDB, passwordDB,typeOfPerson));
                }
            }
            else
            {
                MessageBox.Show("ERREUR !");
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return Allusers;
        }

        public static void removeUserById(string unId)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "DELETE FROM Person WHERE id = @id";
            //bindparam
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@id";
            param.DbType = DbType.Int64;
            param.Value = unId;
            command.Parameters.Add(param);

            reader = command.ExecuteReader();
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }

        public static void AddUser(User aUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Person values (@aUser)";
            MySqlParameter paramUser = new MySqlParameter();
            paramUser.ParameterName = "@aUser";
            paramUser.DbType = DbType.Object;
            paramUser.Value = aUser;  
            command.Parameters.Add(paramUser);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();  
        }

        public static void UpdateUser(User aUser)
        {

        }
    }
}
