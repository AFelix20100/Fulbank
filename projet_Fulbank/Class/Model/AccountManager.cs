﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
            command.CommandText = "SELECT * FROM Account WHERE idPerson = @idPerson";
            command.Parameters.AddWithValue("@idPerson", unUser.getId());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = reader["iban"].ToString();
                    bic = reader["bic"].ToString();
                    sold = Convert.ToDouble(reader["sold"]);
                    debt = Convert.ToInt32(reader["debt"]);
                    limitSold = Convert.ToInt32(reader["limitSold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idType = Convert.ToInt32(reader["idTypeOfAccount"]);


                    /*
                    if(reader["debt"] == null)
                    {
                        debt = 0;
                    }
                    else if (reader["limitSold"] == null)
                    {
                        limitSold = 0;
                    }
                    else
                    {
                        debt = Convert.ToInt32(reader["debt"]);
                        limitSold = Convert.ToInt32(reader["limitSold"]);
                    }
                    */
                    if(idType == 1)
                    {
                        User.allCurrents.Clear();
                        User.addCurrent(new Current(id,iban,bic,sold,idPerson,idType,debt));
                    }
                    else if (idType == 2)
                    {
                        User.allSavings.Clear();
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
        /*
        public static void removeCash(User oneUser, float anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account SET Sold = " + anAmount + " WHERE idPerson = " + oneUser.getId();
            reader = command.ExecuteReader();//On exécute la requête SQL
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
        }
        */
        public static Account getAccountById(int id)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            string iban = "";
            string bic = "";
            double sold = 0;
            int debt = 0;
            int limitSold = 0;
            int idPerson = 0;
            int idTypeOfAccount = 0;

            command.CommandText = "SELECT * FROM Account WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32(reader["id"]);
                    iban = reader["iban"].ToString();
                    bic = reader["bic"].ToString();
                    sold = Convert.ToInt32(reader["sold"]);
                    debt = Convert.ToInt32(reader["debt"]);

                    if (reader["limitSold"].ToString() != "NULL")
                    {
                        limitSold = 0;
                    }
                    else
                    {
                        limitSold = int.Parse(reader["limitSold"].ToString());
                    }

                    idPerson = int.Parse(reader["idPerson"].ToString());
                    idTypeOfAccount = int.Parse(reader["idTypeOfAccount"].ToString());
                    
                }
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();
            if (idTypeOfAccount == 1)
            {
                return new Current(id, iban, bic, sold, idPerson, idTypeOfAccount, debt);
            }
            else if (idTypeOfAccount == 2)
            {
                return new Savings(id, iban, bic, sold, idPerson, idTypeOfAccount, limitSold);
            }
            else
            {
                return null;
            }
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

        public static void deleteCurrent(int id)
        {
            string query = "DELETE FROM Account WHERE id = @idCurrent";
            command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public static List<Account> getCurrent()
        {
            return AccountManager.CurrentAccount;
        }
        public static List<Account> getSavings()
        {
            return AccountManager.SavingsAccount;
        }
    }
}
