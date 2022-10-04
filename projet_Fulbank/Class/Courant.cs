using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Courant:Compte
    {
        private double _overdraft;

        public Courant(int anId, string anIban, double aBic, double aSolde, User aPersonn, double anUncovered) : base(anId, anIban, aBic, aSolde, aPersonn)
        {
            this._overdraft = anUncovered;
        }

        public double getDecouvert()
        {
            return this._overdraft;
        }

        public void setOverdraft(double aOverdraft)
        {
            this._overdraft = aOverdraft;
        }
    }
}
