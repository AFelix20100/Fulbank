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
                command.CommandText = "UPDATE Wallet SET amount = @Amount WHERE Wallet.idPerso = @oneUser AND idCrypto = '@idCrypto;";
                MySqlParameter Amount = new MySqlParameter();
                Amount.ParameterName = "@Amount";
                Amount.DbType = DbType.Int64;
                Amount.Value = anAmount;

                MySqlParameter UserId = new MySqlParameter();
                UserId.ParameterName = "@UserId";
                UserId.DbType = DbType.Int64;
                UserId.Value = oneUser.getId();

                MySqlParameter anIdCrypto = new MySqlParameter();
                anIdCrypto.ParameterName = "@UserId";
                anIdCrypto.DbType = DbType.Int64;
                anIdCrypto.Value = idCrypto;

                command.Parameters.Add(Amount);
                command.Parameters.Add(UserId);
                command.Parameters.Add(anIdCrypto);

                reader = command.ExecuteReader();
                pdo.Close();
            }
            catch(Exception e) {

                
                //command.CommandText = "INSERT INTO Wallet (idCrypto, idPerso, sold, amount, sellingRate, operationID) values(" + '\'' + idCrypto + '\''+,' )";
                
            
            }
            
            //reader = command.ExecuteReader();
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
                command.CommandText = "INSERT INTO `Wallet` (idCrypto, idPerso, sold, amount, date, sellingRate) VALUES (@idCrypto, @idUser, @Sold, @convertedValue, @Date, @Rate);";

                MySqlParameter paramIdCrypto = new MySqlParameter();
                paramIdCrypto.ParameterName = "@idCrypto";
                paramIdCrypto.DbType = DbType.Int32;
                paramIdCrypto.Value = int.Parse(idCrypto);

                MySqlParameter idUser = new MySqlParameter();
                idUser.ParameterName = "@idUser";
                idUser.DbType = DbType.Int64;
                idUser.Value = oneUser.getId();

                MySqlParameter Sold = new MySqlParameter();
                Sold.ParameterName = "@Sold";
                Sold.DbType = DbType.Double;
                string[] tmpValue = addedQuantity.Split(',');
                Sold.Value = tmpValue[0];

                MySqlParameter Date = new MySqlParameter();
                Date.ParameterName = "@Date";
                Date.DbType = DbType.DateTime;
                string thisDay = DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss");
                Date.Value = thisDay;

                MySqlParameter moneyValue = new MySqlParameter();
                moneyValue.ParameterName = "@convertedValue";
                moneyValue.DbType = DbType.Double;
                moneyValue.Value = convertedValue;

                MySqlParameter sellingRate = new MySqlParameter();
                sellingRate.ParameterName = "@Rate";
                sellingRate.DbType = DbType.Double;
                Root listOfValues = AppelsAPI.RequeteAPI();
                tmpValue = listOfValues.data[int.Parse(idCrypto)].priceUsd.ToString().Split(',');
                sellingRate.Value = tmpValue[0];

                command.Parameters.Add(paramIdCrypto);
                command.Parameters.Add(idUser);
                command.Parameters.Add(Sold);
                command.Parameters.Add(Date);
                command.Parameters.Add(moneyValue);
                command.Parameters.Add(sellingRate);
                MessageBox.Show(command.Parameters.ToString());
   
                reader = command.ExecuteReader();
                pdo.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);


            }

        }
    }

}
