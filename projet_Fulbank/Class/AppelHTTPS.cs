using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;
using projet_Fulbank.Class;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Runtime.CompilerServices;

namespace projet_Fulbank
{

    class AppelHTTPS
    {
        static public float getEuroValue()
        //Returns a float with the value of 1 euro in dollars
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application / json");
            string reponse = client.DownloadString("https://api.exchangerate.host/latest?base=USD");
            RootApiEuro root = JsonConvert.DeserializeObject<RootApiEuro>(reponse);
            float valueEuro = float.Parse(root.rates.getEUR().Replace('.', ','));
            return valueEuro;
        }
        static public Root RequeteHTTPS()
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            string reponse = client.DownloadString("https://api.coincap.io/v2/assets?limit=3");
            Root RepApp = JsonConvert.DeserializeObject<Root>(reponse);
            float rootApiEuro = AppelHTTPS.getEuroValue();
            for (int indexCryp = 0; indexCryp < RepApp.data.Count; indexCryp++)
            {
                RepApp.data[indexCryp].priceUsd = RepApp.data[indexCryp].priceUsd * rootApiEuro;
            
            }
            return RepApp;
        }

        static public decimal GetAmountCrypto(string idCrypto, float amount)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            string reponse = client.DownloadString("https://api.coincap.io/v2/assets/" + idCrypto.ToLower());
            ContainerJson RepApp = JsonConvert.DeserializeObject<ContainerJson>(reponse);
            float valeurEuro = getEuroValue();
            float AmountCrypto = RepApp.Data.priceUsd * valeurEuro;
            AmountCrypto = amount / AmountCrypto;
            //AmountCrypto = float.Parse(AmountCrypto.ToString(),System.Globalization.NumberStyles.Float);
            decimal a = decimal.Parse(AmountCrypto.ToString(), System.Globalization.NumberStyles.Float);
            return a;
            
   
            
            

        }

    }
}
