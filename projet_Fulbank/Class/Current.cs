using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Current:Account
    {
        private double _debt;

        public Current(int anId, string anIban, string aBic, double aSolde, int idPerson, int TypeOfAccount, int aDebt) : base(anId,anIban,aBic,aSolde,idPerson,TypeOfAccount)
        {
            this._debt = aDebt;
        }

        public double getOverdraft()
        {
            return this._debt;
        }

        public void setOverdraft(double aOverdraft)
        {
            this._debt = aOverdraft;
        }
    }
}
