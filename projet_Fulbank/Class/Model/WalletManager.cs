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
            anAmount = anAmount.Replace(',', '.');
            amoutCrypto = amoutCrypto.Replace(',', '.'); //Mysql n'aime pas du tout les virgules
            try
            {
                command.CommandText = "UPDATE Wallet SET amount =" + '\'' + anAmount + '\''+"WHERE idPerson = '"+oneUser.getId()+ '\''+"AND idCrypto = '"+idCrypto+ '\''+ '\''+';';
                reader = command.ExecuteReader();
            }
            catch(Exception e) {

                command.CommandText = "INSERT INTO Wallet (idCrypto, idPerso, sold, amount, sellingRate, operationID) values()";
            
            
            }
            
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
