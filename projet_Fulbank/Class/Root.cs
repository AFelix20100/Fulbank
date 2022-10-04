using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Root
    //Ceci est l'objet envoyé par la requette HTTPS qui contient la réponse JSON de l'API de cryptomonnaies
    {
        public List<Data> data {get; set;}
    }
}
