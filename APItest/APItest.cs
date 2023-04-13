using Microsoft.VisualStudio.TestTools.UnitTesting;
using projet_Fulbank;
using System.ComponentModel.Design.Serialization;
using projet_Fulbank.Class;
using System.Text.RegularExpressions;

namespace APItest

{
    [TestClass]
    public class TestAPI
    {
        [TestMethod]
        public void TestEuroAPITrue()
        {
            float response = AppelsAPI.getEuroValue();
            Regex rx = new Regex("[+-]?([0-9]*[.])?[0-9]+");
            string Matches = rx.IsMatch(response.ToString()).ToString();
            Assert.AreEqual("True", Matches, "Received "+ response + " instead of a float value");

        }

        [TestMethod]
        public void TestEuroAPIFalse()
        {
            float response = AppelsAPI.getEuroValue();
            Regex rx = new Regex("[+-]?([0-9]*[.])?[0-9]+");
            string Matches = rx.IsMatch(response.ToString()).ToString();
            string errorMessage = "Error: received "+response.ToString();

            if (Matches == "True")
            {
                errorMessage = "Received a float value which means that the API call was successfull";
            }

            Assert.AreEqual("False", Matches, "errorMessage");

        }


        [TestMethod]
        public void TestCryptoAPITrue()
        {

            Root response = AppelsAPI.RequeteAPI();
            Regex rx = new Regex("[+-]?([0-9]*[.])?[0-9]+");
            string Matches = rx.IsMatch(response.data[0].priceUsd.ToString()).ToString();

            Assert.AreEqual("True", Matches, "Received " + Matches + " instead of True");

        }

        [TestMethod]
        public void TestCryptoAPIFalse()
        {

            Root response = AppelsAPI.RequeteAPI();
            Regex rx = new Regex("[+-]?([0-9]*[.])?[0-9]+");
            string Matches = rx.IsMatch(response.data[0].priceUsd.ToString()).ToString();
            string errorMessage = "Error: received " + response.ToString();
            if (Matches == "True")
            {
                errorMessage = "Received a float value which means that the API call was successfull";
            }

            Assert.AreEqual("False", Matches, errorMessage);

        }
    }
}