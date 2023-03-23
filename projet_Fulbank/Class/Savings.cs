using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    public class Savings:Account
    {
        private double _limit;
        public Savings(int anId, string anIban, string aBic, double aSolde, int idPerson, int TypeOfAccount, int aLimit) : base(anId, anIban, aBic, aSolde, idPerson, TypeOfAccount)
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
