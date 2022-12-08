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
            reader.Close();
            pdo.Close();

        }


        //envoide l'opération dans la base de données.
        public static void sentOperationWithdrawal(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor, idType) VALUES(@date, @anAmount, 'Retrait de ' @anAmountt ' euros', @idDebitor, 2 )";
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
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
           


            reader = command.ExecuteReader();
            reader.Close();
            pdo.Close();
        }


        public static void TransferCurrentIntoBooklet(double anAmount)
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
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmountt ' euros dans le compte epargne ', @iduser, @iduser , 1 )";
            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "@date";
            param3.DbType = DbType.DateTime;
            param3.Value = DateTime.Now;
            MySqlParameter param4 = new MySqlParameter();
            param4.ParameterName = "@iduser";
            param4.DbType = DbType.Int64;
            //param4.Value = AccountManager.
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
            reader.Close();
            pdo.Close();

        }

        public static void TransfertBookletIntoCurrent(double anAmount)
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
            command.CommandText = "INSERT INTO Operation(date, amount, description, idDebitor,idCreditor, idType) VALUES(@date, @anAmount, 'Virement de ' @anAmountt ' euros ', @iduser, @iduser , 1 )";
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
            reader.Close();
            pdo.Close();

        }




    }
}
