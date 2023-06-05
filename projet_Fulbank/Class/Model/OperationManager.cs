using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_Fulbank.Class;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Reflection;

namespace projet_Fulbank.Class.Model
{
    public class OperationManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;


        /// <summary>
        ///     fonction pour retirer de l'argent, donc ca modifie enlève de la bdd aussi.
        /// </summary>
        /// <param name="anAmount"></param>
        public static void withdrawal(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1";
            command.Parameters.AddWithValue("@login", UserManager.getUser().getLogin());
            command.Parameters.AddWithValue("@anAmount", anAmount);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }


        //envoide l'opération dans la base de données.
        public static void sentOperationWithdrawal(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor, idCreditor, idType) VALUES(@date, @anAmount, 'Retrait de ' @anAmountt ' euros', @idDebitor,@idCreditor, 2)";
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@date";
            param3.DbType = DbType.DateTime;
            param3.Value = DateTime.Now;
            command.Parameters.Add(param3);

            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@idDebitor";
            param4.DbType = DbType.Int64;
            param4.Value = AccountManager.getCurrentById(UserManager.getUser()).getId();

            MySqlParameter param7 = new MySqlParameter();
            param7.ParameterName = "@idCreditor";
            param7.DbType = DbType.Int64;
            param7.Value = AccountManager.getCurrentById(UserManager.getUser()).getId();

            MySqlParameter param5 = new MySqlParameter();
            param5.ParameterName = "@anAmount";
            param5.DbType = DbType.Double;
            param5.Value = anAmount;
            MySqlParameter param6 = new MySqlParameter();
            param6.ParameterName = "@anAmountt";
            param6.DbType = DbType.String;
            param6.Value = anAmount.ToString();
            
            param4.Value = UserManager.getUser().getId();
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);


            command.Parameters.Add(param6);
            command.Parameters.Add(param7);


          

          
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }

        public static void PurchaseCrypto(string cryptoName, double cryptoAmount, double euroAmount)
        {
            pdo.Open();
            //Exemple : Achat de bitcoin -2500€
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor, idCreditor, idType) VALUES(@date, @euroAmount, 'Achat de ' @cryptoName, @iduser, @idCreditor, 1 )";
            command.Parameters.AddWithValue("@date", DateTime.Now);
            command.Parameters.AddWithValue("@euroAmount", "-" + euroAmount);
            command.Parameters.AddWithValue("@cryptoName", cryptoName);
            command.Parameters.AddWithValue("@iduser", UserManager.getUser().getId());
            command.Parameters.AddWithValue("@idCreditor", UserManager.getUser().getId());
            command.ExecuteNonQuery();


            //Exemple : Achat de bitcoin + 0.0004 btc
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor, idCreditor, idType) VALUES(@date, @cryptoAmount, 'Achat de ' @cryptoName, @iduser, @idCreditor, 1 )";
            command.Parameters.AddWithValue("@date", DateTime.Now);
            command.Parameters.AddWithValue("@cryptoAmount", cryptoAmount);
            command.Parameters.AddWithValue("@cryptoName", cryptoName);
            command.Parameters.AddWithValue("@iduser", UserManager.getUser().getId());
            command.Parameters.AddWithValue("@idCreditor", UserManager.getUser().getId());
            command.ExecuteNonQuery();

            pdo.Close();

        }

        public static void TransferCurrentIntoSavings(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = sold + @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 2";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@login";
            param.DbType = DbType.Int64;
            param.Value = UserManager.getUser().getLogin();
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anAmount";
            param2.DbType = DbType.Double;
            param2.Value = anAmount;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

            pdo.Open();
            command.CommandText= "UPDATE Account set sold = sold - @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1";
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }

        public static void setOperationTransfer(double anAmount)
        {
            pdo.Open();
            command= pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmountt ' euros dans le compte epargne ', @idDebitor, @idCreditor , 1 )";
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@date";
            param3.DbType = DbType.DateTime;
            param3.Value = DateTime.Now;
            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@idDebitor";
            param4.DbType = DbType.Int64;
            param4.Value = AccountManager.getCurrentById(UserManager.getUser()).getId();
            MySqlParameter param5 = new MySqlParameter();
            param5.ParameterName = "@anAmount";
            param5.DbType = DbType.Double;
            param5.Value = anAmount;
            MySqlParameter param6 = new MySqlParameter();
            param6.ParameterName = "@anAmountt";
            param6.DbType = DbType.String;
            param6.Value = anAmount.ToString();
            MySqlParameter idCreditor = new MySqlParameter();
            idCreditor.ParameterName = "@idCreditor";
            idCreditor.DbType = DbType.Int64;
            idCreditor.Value = AccountManager.getSavingsById(UserManager.getUser()).getId();
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(idCreditor);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

        }

        public static void TransfertSavingsIntoCurrent(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = sold + @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1 ";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@login";
            param.DbType = DbType.Int64;
            param.Value = UserManager.getUser().getLogin();
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anAmount";
            param2.DbType = DbType.Double;
            param2.Value = anAmount;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

            pdo.Open();
            command.CommandText = "UPDATE Account set sold = sold - @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 2";
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }

        public static void setOperationTransferIntoCurrent(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmountt ' euros dans le compte courant ', @idDebitor, @idCreditor , 1 )";
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@date";
            param3.DbType = DbType.DateTime;
            param3.Value = DateTime.Now;
            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@idDebitor";
            param4.DbType = DbType.Int32;
            param4.Value = AccountManager.getSavingsById(UserManager.getUser()).getId();
            MySqlParameter param5 = new MySqlParameter();
            param5.ParameterName = "@anAmount";
            param5.DbType = DbType.Double;
            param5.Value = anAmount;
            MySqlParameter param6 = new MySqlParameter();
            param6.ParameterName = "@anAmountt";
            param6.DbType = DbType.String;
            param6.Value = anAmount.ToString();
            MySqlParameter idCreditor = new MySqlParameter();
            idCreditor.ParameterName = "@idCreditor";
            idCreditor.DbType = DbType.Int32;
            idCreditor.Value = AccountManager.getCurrentById(UserManager.getUser()).getId();

            command.Parameters.Add(idCreditor);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

        }


        public static void TransfertIntoBeneficiary(double anAmount,string anIban)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = sold + @anAmount WHERE iban = @anIban AND idTypeOfAccount = 1";
            MySqlParameter theIban = new MySqlParameter();
            theIban.ParameterName = "@anIban";
            theIban.DbType = DbType.String;
            theIban.Value = anIban;
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anAmount";
            param2.DbType = DbType.Double;
            param2.Value = anAmount;
            command.Parameters.Add(theIban);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

            pdo.Open();
            command.CommandText = "UPDATE Account set sold = sold - @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1";
            MySqlParameter theLogin = new MySqlParameter();
            theLogin.ParameterName = "@login";
            theLogin.DbType = DbType.Int64;
            theLogin.Value = theLogin.Value = UserManager.getUser().getLogin();
            command.Parameters.Add(theLogin);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }

        public static void setOperationTransfertIntoBeneficiary(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmountt ' euros dans le compte courant ', @idDebitor, @idCreditor , 1)";
            MySqlParameter idDebitor = new MySqlParameter();
            idDebitor.ParameterName = "@idDebitor";
            idDebitor.DbType = DbType.Int32;
            idDebitor.Value = UserManager.getUser().getId();
            MySqlParameter idCreditor = new MySqlParameter();
            idCreditor.ParameterName = "@idCreditor";
            idCreditor.DbType = DbType.Int32;

            MySqlParameter anAmountt = new MySqlParameter(); 
            command.Parameters.Add(idCreditor);
            command.Parameters.Add(idDebitor);
        }



           
        

        public static void AddMoneyFromCrypto(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = sold + @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1";
            MySqlParameter login = new MySqlParameter();
            login.ParameterName = "@login";
            login.DbType = DbType.Int64;
            login.Value = UserManager.getUser().getLogin();
            MySqlParameter Amount = new MySqlParameter();
            Amount.ParameterName = "@anAmount";
            Amount.DbType = DbType.Double;
            Amount.Value = anAmount;
            command.Parameters.Add(login);
            command.Parameters.Add(Amount);
            reader = command.ExecuteReader();
            pdo.Close();
        }
        /// <summary>
        /// Cette fonction permet de récupérer les opérations sur les différents comptes que ce soit courant
        /// ou epargen
        /// </summary>
        /// <param name="login"></param>
        /// <param name="typeAccount">Peut prendre la valeur 1 ou 2; 1 = Courant et 2 = Epargne</param>
        /// <returns></returns>
        public static List<Operation> GetOperationsByLogin(long login,int typeAccount)
        {
            User user = UserManager.FindByLogin(login);
            List<Operation> operations = new List<Operation>();
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "SELECT O.* FROM Operation O INNER JOIN Account A ON A.id = O.idDebitor OR A.id = O.idCreditor INNER JOIN Person P ON P.id = A.idPerson WHERE P.login = @login AND A.idTypeOfAccount = @type";
            command.Parameters.AddWithValue("@login", user.getLogin());
            command.Parameters.AddWithValue("@type", typeAccount);
            reader = command.ExecuteReader();
            

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    DateTime date;
                    DateTime.TryParse(reader["date"].ToString(), out date);
                    double amount = Convert.ToDouble(reader["amount"]);
                    string description = reader["description"].ToString();
                    int idDebitor = Convert.ToInt32(reader["idDebitor"]);
                    int idCreditor = Convert.ToInt32(reader["idCreditor"]);
                    int unType = int.Parse(reader["idType"].ToString());
                    operations.Add(new Operation(id, date, amount, description, AccountManager.getAccountById(idDebitor),AccountManager.getAccountById(idCreditor),unType));
                }
            }
            pdo.Close();
            return operations; 
        }
    }
}
