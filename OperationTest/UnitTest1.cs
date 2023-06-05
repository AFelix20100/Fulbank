using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using projet_Fulbank.Class.Model;
using projet_Fulbank;
using projet_Fulbank.Class;
using Moq;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace OperationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void withdrawalTest()
        {
            Mock<MySqlConnection> mockConnection = new Mock<MySqlConnection>();
            // Configure le mock pour que la commande et le reader renvoient des valeurs prédéfinies
            Mock<MySqlCommand> mockCommand = new Mock<MySqlCommand>();
            mockCommand.Setup(m => m.ExecuteReader()).Returns(() => Mock.Of<MySqlDataReader>());
            mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Injecte le mock dans la classe OperationManager
            typeof(DBConnexion).GetField("pdo", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, mockConnection.Object);

            // Appelle la fonction withdrawal avec un montant de 100
            OperationManager.withdrawal(100);

            // Vérifie que la commande a été créée avec les bons paramètres
            mockCommand.VerifySet(m => m.CommandText = "UPDATE Account set sold = @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login) AND idTypeOfAccount = 1", Times.Once());
            mockCommand.Verify(m => m.Parameters.AddWithValue("@login", UserManager.getUser().getLogin()), Times.Once());
            mockCommand.Verify(m => m.Parameters.AddWithValue("@anAmount", 100), Times.Once());

            // Vérifie que la commande a été exécutée
            mockCommand.Verify(m => m.ExecuteReader(), Times.Once());

            // Vérifie que la connexion a été ouverte et fermée
            mockConnection.Verify(m => m.Open(), Times.Once());
            mockConnection.Verify(m => m.Close(), Times.Once());
           
        }
    }
}
