using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class CryptoCurrency
    {
        private int _id;
        private string _label;
        private bool _rate;

        public CryptoCurrency(int anId, string aLabel, bool aRate)
        {
            this._id = anId;
            this._label = aLabel;
            this._rate = aRate;
        }

        //getter

        public int getId()
        {
            return this._id;
        }

        public string getLabel()
        {
            return this._label;
        }

        public bool getRate()
        {
            return this._rate;
        }

        //setter
        public void setId(int anId)
        {
            this._id = anId;
        }

        public void setLabel(string aLabel)
        {
            this._label = aLabel;
        }

        public void setRate(bool aRate)
        {
            this._rate = aRate;
        }
    }
}
