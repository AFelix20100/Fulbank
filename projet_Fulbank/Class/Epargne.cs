using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Epargne:Compte
    {
        private double _limit;
        public Epargne(int anId, string anIban, double aBic, double aSolde, User aPersonn, double aLimit) : base(anId, anIban, aBic, aSolde, aPersonn)
        {
            this._limit = aLimit;
        }

        //getter
        public double getLimit()
        {
            return this._limit;
        }

        public void setLimit(double aLimit)
        {
            this._limit = aLimit;
        }
    }
}
