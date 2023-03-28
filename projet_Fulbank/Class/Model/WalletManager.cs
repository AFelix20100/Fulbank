using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                command.CommandText = "UPDATE Wallet SET amount = " + '\'' + anAmount + '\''+" WHERE Wallet.idPerso = '"+oneUser.getId()+ '\''+" AND idCrypto = '"+ idCrypto + "'" +";";
                reader = command.ExecuteReader();
                pdo.Close();
            }
            catch(Exception e) {

                
                //command.CommandText = "INSERT INTO Wallet (idCrypto, idPerso, sold, amount, sellingRate, operationID) values(" + '\'' + idCrypto + '\''+,' )";
                
            
            }
            
            //reader = command.ExecuteReader();
        }

        public static void convertCryptoToMoney(string idCrypto, User oneUser, string anAmount, string amoutCrypto)
        {
            pdo.Open();
            command = pdo.CreateCommand();

            try
            {
                command.CommandText = "SELECT sold FROM Account WHERE id =" + oneUser.getId() + ";";
                reader = command.ExecuteReader();//On exécute la requête SQL
                if (reader.HasRows)
                {

                }// Si la requête présente a des enregistrements

            }
            catch (Exception e)
            {

            }
            pdo.Close();

        }

        public static int GetCurrentCurrencyCount(string idCrypto, User oneUser)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            int result = 0;
            
            try
            {
                command.CommandText = "SELECT SUM(sold) FROM Wallet WHERE idPerso = @idPerso AND idCrypto = @idCrypto";
                MySqlParameter paramIdCrypto = new MySqlParameter();
                paramIdCrypto.ParameterName = "@idCrypto";
                paramIdCrypto.DbType = DbType.Int64;
                paramIdCrypto.Value = idCrypto;

                MySqlParameter paramIdPerso = new MySqlParameter();
                paramIdPerso.ParameterName = "@idPerso";
                paramIdPerso.DbType = DbType.Int64;
                paramIdPerso.Value = oneUser.getId();

                command.Parameters.Add(paramIdCrypto);
                command.Parameters.Add(paramIdPerso);
                 
                reader = command.ExecuteReader();//On exécute la requête SQL
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        result = reader.GetInt32(0);

                    }// Si la requête présente a des enregistrements
                }

               

            }
            catch (Exception e)
            {

            }
            pdo.Close();
            return result;
        }

        public static void setOwnedCurrency(string idCrypto, User oneUser, string addedQuantity, string convertedValue)
        {

            pdo.Open();
            command = pdo.CreateCommand();
            try
            {
                command = pdo.CreateCommand();
                command.CommandText = "INSERT INTO `Wallet` (`idCrypto`, `idPerso`, `sold`, `amount`, `date`, `sellingRate`) VALUES ('@idCrypto', '@idUser', '@Sold', '@convertedValue', '@Date', '@Rate);";

                MySqlParameter paramIdCrypto = new MySqlParameter();
                paramIdCrypto.ParameterName = "@idCrypto";
                paramIdCrypto.DbType = DbType.Int64;
                paramIdCrypto.Value = idCrypto;

                MySqlParameter idUser = new MySqlParameter();
                idUser.ParameterName = "@idCrypto";
                idUser.DbType = DbType.Int64;
                idUser.Value = oneUser.getId();

                MySqlParameter Sold = new MySqlParameter();
                Sold.ParameterName = "@Sold";
                Sold.DbType = DbType.Int64;
                Sold.Value = addedQuantity;

                MySqlParameter Date = new MySqlParameter();
                Date.ParameterName = "@Date";
                Date.DbType = DbType.DateTime;
                string thisDay = DateTime.Today.ToString();
                Date.Value = thisDay;

                MySqlParameter moneyValue = new MySqlParameter();
                moneyValue.ParameterName = "@convertedValue";
                moneyValue.DbType = DbType.Double;
                Date.Value = convertedValue;

                MySqlParameter sellingRate = new MySqlParameter();
                sellingRate.ParameterName = "@Rate";
                sellingRate.DbType = DbType.Double;
                string theSellingRate = AppelsAPI.GetAmountCrypto(idCrypto, 1).ToString();

                command.Parameters.Add(paramIdCrypto);
                command.Parameters.Add(idUser);
                command.Parameters.Add(Sold);
                command.Parameters.Add(Date);
                command.Parameters.Add(moneyValue);
                command.Parameters.Add(sellingRate);

                pdo.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("Error! Please contact the administrator of this machine");


            }

        }
    }

}
