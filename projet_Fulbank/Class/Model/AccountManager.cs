using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class.Model
{
    public class AccountManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;
        public static Account makeAccount(User unUser,int TypeOfAccount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            int id = 0;
            string iban = "";
            string bic = "";
            double solde = 0;
            int debt = 0;
            int limitSold = 0;
            int idPerson = 0;
            int idType = TypeOfAccount;
            command.CommandText = "SELECT * FROM Account WHERE idPerson =" + unUser.getId(); //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    id = Convert.ToInt32((reader["id"]));
                    iban = (reader["iban"]).ToString();
                    bic = (reader["bic"]).ToString();
                    solde = Convert.ToDouble(reader["sold"]);
                    debt = Convert.ToInt32(reader["debt"]);
                    limitSold = Convert.ToInt32(reader["limitSold"]);
                    idPerson = Convert.ToInt32(reader["idPerson"]);
                    idType = Convert.ToInt32(reader["idTypeOfPerson"]);

                    if(id == 0)
                    {
                        User.addAccount(new Current());
                    }
                    else if (id == 1)
                    {
                        User.addAccount(new Savings());
                    }
                    
                }
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return new Account(id, iban, bic, solde, debt, limitSold, unUser.getId(), unUser.getType());
        }

        public static double getSoldeBDD(User unUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            double solde = 0;
            command.CommandText = "SELECT sold FROM Account WHERE idPerson =" + unUser.getId() + "AND idTypeOfPerson=" + unUser.getType(); //Requête SQL
            reader = command.ExecuteReader();//On exécute la requête SQL
            if (reader.HasRows)// Si la requête présente a des enregistrements
            {
                while (reader.Read())//Tant qu'il ya des enregistrements
                {
                    
                    solde = Convert.ToDouble(reader["solde"]);
                }
            }
            reader.Close();//On ferme le Reader pour éviter d'avoir d'autres instance de reader
            pdo.Close();

            return solde;
        }
    }
}
