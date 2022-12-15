using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class.Model
{
    internal class WalletManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;

        public static void addCryptotoAccount(string idCrypto, User oneUser, string anAmount, string amoutCrypto)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy-MM-dd HH:mm:ss"); //le format de l'objet DateTime qu'on a ne correspond pas au format accepté par SQL alors on le formate 
            anAmount = anAmount.Replace(',', '.');
            amoutCrypto = amoutCrypto.Replace(',', '.'); //Mysql n'aime pas du tout les virgules
            command.CommandText = "INSERT INTO Wallet (idCrypto, idPerso, sold, amount , date, sellingRate) values(" + "\'" + idCrypto + "\'," + "\'" + oneUser.getId() + "\'," + "\'0\'," + "\'" + anAmount + "\'" + ",\'" + date + "\'" + ",\'" + amoutCrypto + "\'" + ");";
            reader = command.ExecuteReader();
        }

        public static void convertCryptoToMoney(string idCrypto, User oneUser, string anAmount, string amoutCrypto)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            try
            {
                command.CommandText = "SELECT sold FROM Account WHERE id =" + oneUser.getId() + ";";
                reader = command.ExecuteReader();//On exécute la requête SQL
                if (reader.HasRows) {
                    
                }// Si la requête présente a des enregistrements
                 
            }
            catch(Exception e)
            {

            }
        }

    }
}
