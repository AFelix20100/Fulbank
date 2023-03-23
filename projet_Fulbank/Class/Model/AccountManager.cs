using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace projet_Fulbank.Class.Model
{
    public class AccountManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;
        public static  List<Account> CurrentAccount = new List<Account>();
        public static  List<Account> SavingsAccount = new List<Account>();
        public static void makeAccount(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int debt = 0;
            int limitSold = 0;
            int idPerson = 0;
            int idType = 0;
            command.CommandText = "SELECT * FROM Account WHERE idPerson =" + unUser.getId(); //Requête SQL T'AS PAS FAIT DE BINDPARAM
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idType = Convert.ToInt32(reader["idTypeOfAccount"]);
                    if(reader["debt"] == null)
                    {
                        debt = 0;
                    }
                    else if (reader["limitSold"] == null)
                    {
                        limitSold = 0;
                    }

                    if(idType == 1)
                    {
                        User.addCurrent(new Current(id,iban,bic,sold,idPerson,idType,debt));
                    }
                    else if (idType == 2)
                    {
                        User.addSavings(new Savings(id, iban, bic, sold, idPerson, idType, limitSold));
                    }
                    
                }
            }

            /*
            foreach (Account aAccount in User.getAllAccount())
            {
                if (aAccount.GetType() == typeof(Current))
                {
                    CurrentAccount.Add(aAccount);
                }
                else if (aAccount.GetType() == typeof(Savings))
                {
                    SavingsAccount.Add(aAccount);
                }
            }
            */
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }

        public static double getSoldeBDD(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            double solde = 0;
            command.CommandText = "SELECT sold FROM Account WHERE idPerson =" + unUser.getId() + " AND idTypeOfAccount=" + 1; //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    
                    solde = Convert.ToDouble(reader["sold"]);
                }
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return solde;
        }

        public static double getSoldSavings(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            double solde = 0;
            command.CommandText = "SELECT sold FROM Account WHERE idPerson =" + unUser.getId() + " AND idTypeOfAccount= 2"; //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {

                    solde = Convert.ToDouble(reader["sold"]);
                }
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return solde;
        }


        public static void setPassword(int id)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            string password = AdministationManager.generatePassword();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = AdministationManager.GetHash(sha256Hash, password);
                command.CommandText = "UPDATE Person SET password = @password WHERE id = @id"; //Requête SQL
                command.Parameters.AddWithValue("@password", hash);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();//On exécute la requête SQL
                MessageBox.Show("Notez le mot de passe : " + password);
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }
        public static List<Account> getCurrent()
        {
            return AccountManager.CurrentAccount;
        }
        public static List<Account> getSavings()
        {
            return AccountManager.SavingsAccount;
        }

        public static Account getCurrentById(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int debt = 0;
            int limitSold = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;

            command.CommandText = "SELECT * FROM Account WHERE idPerson = @idUser AND idTypeOfAccount= 1 ";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@idUser";
            param.DbType = DbType.Int64;
            param.Value = unUser.getId();
            command.Parameters.Add(param);
            reader = command.ExecuteReader();
          
             
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                   
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);
                }
            }

            reader.Close();
            pdo.Close();
            return new Current(id, iban, bic, sold, debt, idPerson, idTypeOfAccount); 
        }

        public static Account getSavingsById(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int limitSold = 0;
            int debt = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;

            command.CommandText = "SELECT * FROM Account WHERE idPerson = @idUser AND idTypeOfAccount= 2 ";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@idUser";
            param.DbType = DbType.Int64;
            param.Value = unUser.getId();
            command.Parameters.Add(param);
            reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);

                    if (reader["limitSold"] == null)
                    {
                        limitSold = 0;
                    }

                    else if (reader["debt"] == null)
                    {
                        debt= 0;
                    }
                }
            }

            reader.Close();
            pdo.Close();
            return new Savings(id, iban, bic, sold,limitSold, idPerson, idTypeOfAccount);

        }

       

        

        public static Account getOtherAccount(string anIban)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int limitSold = 0;
            int debt = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;

            command.CommandText = "SELECT * FROM Account WHERE iban = @aniban AND idTypeOfAccount= 1 ";
            MySqlParameter theIban = new MySqlParameter();
            theIban.ParameterName = "@anIban";
            theIban.DbType = DbType.String;
            theIban.Value = anIban;
            command.Parameters.Add(theIban);
            reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);

                    if (reader["debt"] == null)
                    {
                        debt = 0;
                    }
                }
            }

            reader.Close();
            pdo.Close();
            return new Current(id, iban, bic, sold,debt, idPerson, idTypeOfAccount);
        }

        

      

        
    }
}
