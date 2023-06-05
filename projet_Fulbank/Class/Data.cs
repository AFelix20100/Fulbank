using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Data
    //Objet data utilisé pour désérialiser le réponse reçue en json

    {
        public string name { get; set; } //nom d'une cryptomonnie
        public string id { get; set; } // id d'une cryptomonnie
        public float priceUsd { get; set; } // prix d'une cryptomonnie
    }
}
