using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace projet_Fulbank.Class
{
    internal class Agios
    {
        private int _id;
        private string _label;
        private bool _amount;
        private bool _rate;
        private string _description;

        public Agios(int id, string label, bool amount, bool rate, string description)
        {
            _id = id;
            _label = label;
            _amount = amount;
            _rate = rate;
            _description = description;
        }
    }
}
