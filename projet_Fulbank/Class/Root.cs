using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Root
    //Objet utlisé pour désérialiser la reponse reçue en JSON
    //Il représente l'entité racine de l'arborescence du réponse
    {
        public List<Data> data {get; set;} //une serie de listes dans lequelles il y a les informations des cryptomonnaies
    }
}
