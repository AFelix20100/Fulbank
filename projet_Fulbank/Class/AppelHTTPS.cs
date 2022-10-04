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

namespace projet_Fulbank
{

     class AppelHTTPS
    {
        public string ApiKey { get; set; }


        static public RootApiEuro getEuro()
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application / json");
            string reponse = client.DownloadString("https://api.exchangerate.host/latest?base=USD");
            RootApiEuro root = JsonConvert.DeserializeObject<RootApiEuro>(reponse);
            return root;
        }
        static public Root RequeteHTTPS() {
        
        WebClient client = new WebClient();
        client.Headers.Add("Accepts", "application/json");
        string reponse = client.DownloadString("https://api.coincap.io/v2/assets");
        Root RepApp = JsonConvert.DeserializeObject<Root>(reponse);
        RootApiEuro rootApiEuro = getEuro();
        for (int indexCryp = 0; indexCryp < RepApp.data.Count; indexCryp++)    
            {   
            RepApp.data[indexCryp].priceUsd = (float.Parse(RepApp.data[indexCryp].priceUsd) * float.Parse(getEuro().rates.getUSD())).ToString(); 
            }

            return RepApp;
        }
    }
}
 