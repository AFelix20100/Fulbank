using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using projet_Fulbank;
using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;

namespace TestUnitaires
{
    [TestClass]
    public class FulbankAccountTests
    {
        [TestMethod]
        public void Virement()
        {
            User user = UserManager.FindByLogin(1125462937);
            UserManager.setUser(user);
            AccountManager.makeAccount(user);
            OperationManager.withdrawal(500);
            Assert.AreEqual(500, AccountManager.getSoldeBDD(user), "Le retrait a bien été effectué");
        }
    }
}
