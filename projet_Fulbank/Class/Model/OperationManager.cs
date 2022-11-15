using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class.Model
{
    public class OperationManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="anAmount"></param>
        public static void withdrawal(double anAmount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login)";
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
           
            
        }

        public static void transfert(int aTypeOfAccount)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account SET Sold = @aAmount WHERE idTypeOfAccount = @aTypeOfAccount AND idPerson = (SELECT id FROM Person WHERE login = @login)";
            MySqlParameter parameter = new MySqlParameter();
            parameter.ParameterName = "@login";
            parameter.DbType = DbType.Int64;
        }


    }
}
