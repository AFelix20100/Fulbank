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
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace projet_Fulbank
{

    class AppelsAPI //la classe qui gere les appelles des APIs
    {
        static public float getEuroValue()
            //Appel pour avoir la valeur d'un dollar américain en euro
            //Retourne un float avec la valeur d'un euro en dollars américains
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application / json");
            string reponse = client.DownloadString("https://api.exchangerate.host/latest?base=USD");
            RootApiEuro root = JsonConvert.DeserializeObject<RootApiEuro>(reponse);
            float valueEuro = float.Parse(root.rates.getEUR().Replace('.', ',')); // les floats françaises nécessitent une virgule au lieu d'un point pour qu'il soit valide
            return valueEuro;
        }
        static public Root RequeteAPI()
            //Appel pour recuperer les informations de 3 dernières cryptomonnaies 
            //Retourne un objet Root avec 3 listes Data
        {
            WebClient client = new WebClient();
            //client.Headers.Add("Accepts", "application/json");
            string reponse = client.DownloadString("https://api.coincap.io/v2/assets?limit=3");
            Root RepApp = JsonConvert.DeserializeObject<Root>(reponse);
            float rootApiEuro = AppelsAPI.getEuroValue(); //récupération de la valeur d'un euro
            for (int indexCryp = 0; indexCryp < RepApp.data.Count; indexCryp++)
            {
                RepApp.data[indexCryp].priceUsd = RepApp.data[indexCryp].priceUsd * rootApiEuro; //convertition de la valeur des cryptomonnaie en euros 
            }
            return RepApp;
        }
        static public decimal GetAmountCrypto(string idCrypto, float amount)
            //Appel pour recuperer la valeur en euro d'une certaine quantite de cryptomonnaie 
            //Retourne un float.
        {
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            string reponse = client.DownloadString("https://api.coincap.io/v2/assets/" + idCrypto.ToLower());
            ContainerJson RepApp = JsonConvert.DeserializeObject<ContainerJson>(reponse);
            float valeurEuro = getEuroValue();
            float AmountCrypto = RepApp.Data.priceUsd * valeurEuro;
            AmountCrypto = amount / AmountCrypto;
            decimal euroVal = decimal.Parse(AmountCrypto.ToString(), System.Globalization.NumberStyles.Float);
            return euroVal;
        }

        static public Root getCryptoHistory(string idCrypto)
            //Appel pour avoir l'histoire d'une certaine cryptomonnaie
            //Retourne un objet Root qui contient des listes de Data
        {
            decimal value = 0;
            WebClient client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            string url = "https://api.coincap.io/v2/assets/"+idCrypto+"/history?interval=d1";
            string reponse = client.DownloadString(url);
            Root RepApp = JsonConvert.DeserializeObject<Root>(reponse);
            for(int i = 355; i < RepApp.data.Count(); i++)
            {
                value = Decimal.Parse(RepApp.data[i].priceUsd.ToString());
                value = Math.Truncate(value); //
                RepApp.data[i].priceUsd = float.Parse(value.ToString());
            }
            return RepApp;
        }
    }
}
