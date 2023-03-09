using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_Fulbank.Class;
using System.Drawing.Printing;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Utilities.Collections;

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
            pdo.Close();

        }

        public static void sentOperationWithdrawal(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor, idType) VALUES(@date, @anAmount, 'Retrait de ' @anAmountt ' euros', @iduser, 1 )";
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@date";
            param3.DbType = DbType.DateTime;
            param3.Value = DateTime.Now;
            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@iduser";
            param4.DbType = DbType.Int64;
            param4.Value = UserManager.getUser().getId();
            MySqlParameter param5 = new MySqlParameter();
            param5.ParameterName = "@anAmount";
            param5.DbType = DbType.Double;
            param5.Value = anAmount;
            MySqlParameter param6 = new MySqlParameter();
            param6.ParameterName = "@anAmountt";
            param6.DbType = DbType.String;
            param6.Value = anAmount.ToString();
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);



            reader = command.ExecuteReader();
            pdo.Close();
        }

        public static void TransferToBeneficiary(double anAmount, string anIban) //Transfert vers un compte extérieur
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE set sold = sold + @anAmout WHERE iban = @anIban AND idTypeOfAccount = 1";
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@anAmount";
            param1.DbType = DbType.Double;
            param1.Value = anAmount;
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anIban";
            param2.DbType = DbType.String;
            param2.Value = anIban;
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
            pdo.Close();

        }

        public static void TransferCurrentToSaving(double anAmount) // Transfert du compte courant vers le compte épargne
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE set sold = sold - @anAmount WHERE idTypeOfAccount = 1  AND idPerson = (SELECT id FROM Person WHERE login = @login)";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@anAmount";
            param.DbType = DbType.Double;
            param.Value = anAmount;
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@login";
            param1.DbType = DbType.Int64;
            param1.Value = UserManager.getUser().getLogin();
            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            reader = command.ExecuteReader();
            pdo.Close();

            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE set sold = sold + @anAmount WHERE idTypeOfAccount = 2 AND idPerson = (SELECT id FROM Person WHERE login = @login)";
            reader = command.ExecuteReader();
            pdo.Close();

        }

        public static void TransferSavingToCurrent(double anAmount) // Transfert du coompte épargne au compte courant
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE set sold = sold - @anAmount WHERE idTypeOfAccount = 2 AND idPerson = (SELECT id FROM Person WHERE login = @login)";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@login";
            param.DbType = DbType.Int64;
            param.Value = UserManager.getUser().getLogin();
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@anAmount";
            param1.DbType = DbType.Double;
            param1.Value = anAmount;
            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            reader = command.ExecuteReader();
            pdo.Close();

            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE set sold = sold + @anAmount WHERE idTypeOfAccount = 1 AND idPerson = (SELECT id FROM Person WHERE login = @login)";
            reader = command.ExecuteReader();
            pdo.Close();
        }

        public static void OperationTransferToCurrent(double anAmount) // Enregistrement du transfert du compte épargne vers le ccompte courant dans la table opération
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation (date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmount ' euros du compte épargne dans le compte courant ', @idDebitor, @idCreditor , 1 )";
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@date";
            param1.DbType = DbType.DateTime;
            param1.Value = DateTime.Now;
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anAmount";
            param2.DbType = DbType.Int32;
            param2.Value = anAmount;
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@idDebitor";
            param3.DbType = DbType.Double;
            param3.Value = AccountManager.GetSavingsById(UserManager.getUser()).getId();
            MySqlParameter param5 = new MySqlParameter();
            param5.ParameterName = "@idCreditor";
            param5.DbType = DbType.Int32;
            param5.Value = AccountManager.GetCurrentById(UserManager.getUser()).getId();
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param5);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

        }

        public static void OperationTransferToSavings(double anAmount) // Enregistrement dans la base du transfert du compte courant vers le compte épargne dans la table opération
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmount ' euros du compte courant dans le compte epargne ', @idDebitor, @idCreditor , 1 )";
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@date";
            param1.DbType = DbType.DateTime;
            param1.Value = DateTime.Now;
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@anAmount";
            param2.DbType = DbType.Int64;
            param2.Value = anAmount;
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@idDebitor";
            param3.DbType = DbType.Double;
            param3.Value = AccountManager.GetCurrentById(UserManager.getUser()).getId();
            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@idCreditor";
            param4.DbType = DbType.Int64;
            param4.Value = AccountManager.GetSavingsById(UserManager.getUser()).getId();
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();

        }
        public static void OperationTransfertBeneficiary(double anAmount) // Enregistrement dans la BDD du tranfest effectué vers un bénéficiaire extérieur
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = " INSERT INTO 'Operation' ( date, amount, description, idDebitor, idCreditor, idType) VALUES ( @date, @anAmount, 'Virement d'une valeur de ' @anAmout ' € effectué sur le compte courant de ' @idCreditor ', @idDebitor, @idCreditor, 1 )";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@date";
            param.DbType = DbType.Int32;
            param.Value = DateTime.Now;
            MySqlParameter param1 = new MySqlParameter();
            param1.ParameterName = "@anAmount";
            param1.DbType = DbType.Double;
            param1.Value = anAmount;
            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "@iCreditor";
            param2.DbType = DbType.Int32;
            param2.Value = UserManager.getUser().getId();
            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
            pdo.Close();

        }
    }
}
