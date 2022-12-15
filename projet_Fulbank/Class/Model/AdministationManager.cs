using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public static void removeUserById(int unId)
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
        public static void modifyUserById(int unId, string lastName, string firstName, string mail, double phone, string address, int zipCode, string city, string country, int aType)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Person SET lastName = @lastName, firstName = @firstName, mail = @mail, phone = @phone, adress = @adress, pc=@pc, city = @city, country = @country, idTypeOfPerson = @idTypeOfPerson WHERE id = @id";
            //bindparam
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@firstName", lastName);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@adress", address);
            command.Parameters.AddWithValue("@pc", zipCode);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@country", country);
            command.Parameters.AddWithValue("@idTypeOfPerson", aType);
            command.Parameters.AddWithValue("@id", unId);
            

            reader = command.ExecuteReader();
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }

        public static void addUser(User aUser)
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
        public static void insertOne(string lastName, string firstName, string mail, double phone, string address, int zipCode, string city, string country, int aType)
        {
            string motDePasse = AdministationManager.generatePassword();
            pdo.Open();
            try
            {
                command = pdo.CreateCommand();
                command.CommandText = "INSERT INTO Person(lastName,firstName,mail,phone,adress,pc,city,country,login,password,idTypeOfPerson) VALUES(@lastName,@firstName,@mail,@phone,@address,@pc,@city,@country,@login,@password,@idTypeOfPerson)";
                command.Parameters.AddWithValue("@lastName", firstName);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@pc", zipCode);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@login", AdministationManager.generateId());
                command.Parameters.AddWithValue("@idTypeOfPerson", aType);
            }
            catch (MySqlException sql)
            {
                switch (sql.Number)
                {
                    case 1062:
                        MessageBox.Show("Un champ a été dupliqué : " + sql.Message);
                        reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
                        pdo.Close();
                        break;
                    case 0:
                        MessageBox.Show("Aucune connexion à la BDD");
                        reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
                        pdo.Close();
                        break;
                    default:
                        MessageBox.Show("Erreur");
                        reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
                        pdo.Close();
                        break;
                }
            }
            MessageBox.Show("L'utilisateur a été ajouté");
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, motDePasse);
                command.Parameters.AddWithValue("@password", hash);
                MessageBox.Show("Notez le mot de passe : " + motDePasse);
            }
            reader = command.ExecuteReader();
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

        }

        public static long generateId()
        {
            long anId = 0;
            Random random = new Random();
            anId = random.Next(100000000, 999999999);
            return anId;
        }

        public static string generatePassword()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789./*!?,&é'(-è_@)=<>;%$";

            for (int i = 0; i < 12; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            return sb.ToString();
            /*
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, sb.ToString());
                return hash;
            }*/

        }



        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
