using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank.Class.Model
{
    public class AccountManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;
        public static List<Account> CurrentAccount = new List<Account>();
        public static List<Account> SavingsAccount = new List<Account>();
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
            command.CommandText = "SELECT * FROM Account WHERE idPerson = @idPerson";
            command.Parameters.AddWithValue("@idPerson", unUser.getId());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idType = Convert.ToInt32(reader["idTypeOfAccount"]);
                    if (reader["debt"] == null)
                    {
                        debt = 0;
                    }
                    else if (reader["limitSold"] == null)
                    {
                        limitSold = 0;
                    }

                    if (id == 0)
                    {
                        User.addAccount(new Current(id, iban, bic, sold, idPerson, idType, debt));
                    }
                    else if (idType == 2)
                    {
                        User.addSavings(new Savings(id, iban, bic, sold, idPerson, idType, limitSold));
                    }

                }
            }

            else
            {
                try
                {
                    
                    reader.Close();
                    command = pdo.CreateCommand();
                    iban = AccountManager.createIBAN(unUser.getId());
                    command.CommandText = "INSERT INTO Account(iban,bic,sold,debt,limitSold,idPerson,idTypeOfAccount) VALUES(@iban,@bic,@sold,@debt,@limitSold,@idPerson,@idTypeOfAccount)";
                    command.Parameters.AddWithValue("@iban", iban);
                    command.Parameters.AddWithValue("@bic", bic);
                    command.Parameters.AddWithValue("@sold", sold);
                    command.Parameters.AddWithValue("@debt", debt);
                    command.Parameters.AddWithValue("@limitSold", limitSold);
                    command.Parameters.AddWithValue("@idPerson", unUser.getId());
                    command.Parameters.AddWithValue("@idTypeOfAccount", 1);
                    command.ExecuteNonQuery();
                    
                }
                catch(MySqlException sql)
                {
                    switch (sql.Number)
                    {
                        case 0:
                            MessageBox.Show(sql.Message);
                            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
                            pdo.Close();
                            break;

                        default:
                            MessageBox.Show(sql.Message);
                            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
                            pdo.Close();
                            break;
                    }
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

        //public static void createAccounts()
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

        public static string createIBAN(int id)
        {
            reader.Close();
            string login = "";
            command = pdo.CreateCommand();
            command.CommandText = "SELECT login FROM Person WHERE id =" + id;
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    login = reader[0].ToString();
                }
            }
            string iban = "FR33478928000";
            string key = "25";
            iban = iban + login + key;
            reader.Close();
            return iban;
        }

        public static List<Account> getCurrent()
        {
            return AccountManager.CurrentAccount;
        }
        public static List<Account> getSavings()
        {
            return AccountManager.SavingsAccount;
        }


        public static Account GetCurrentById(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int debt = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;
            command.CommandText = "SELECT * FROM Account WHERE idPerson = @idUser AND idTypeOfAccount = 1 ";
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

                    if (reader["debt"] == null)
                    {
                        debt = 0;
                    }

                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);
                }
            }

            reader.Close();
            pdo.Close();
            return new Current(id, iban, bic, sold, debt, idPerson, idTypeOfAccount);

        }
 
        public static Account GetSavingsById(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int limitSold = 0;
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

                    if (reader["limitSold"] == null)
                    {
                        limitSold = 0;
                    }

                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);

                }
            }

            reader.Close();
            pdo.Close();
            return new Savings(id, iban, bic, sold, limitSold, idPerson, idTypeOfAccount);

        }

        public static Account GetExternalBeneficiary(string anIban)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            int id = 0;
            string iban = "";
            string bic = "";
            double sold = 0;
            int debt = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;

            command.CommandText = "SELECT * FROM Account WHERE iban = @anIban AND idTypeOfAccount = 1 ";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@anIban";
            param.DbType = DbType.String;
            param.Value = anIban;
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

                    if (reader["debt"] == null)
                    {
                        debt = 0;
                    }

                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idTypeOfAccount = Convert.ToInt32(reader["idTypeOfAccount"]);
                }
            }

            reader.Close();
            pdo.Close();
            return new Current(id, iban, bic, sold, debt, idPerson, idTypeOfAccount);

        }
    }

}
