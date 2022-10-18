using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    abstract public class Account
    {
        private int _id;
        private string _iban;
        private string _bic;
        private double _solde;
        private int _debt;
        private int _limitSold;
        private int _idPerson;
        private int _idTypeOfAccount;

        //Current
        public Account(int anId, string anIban, string aBic, double aSolde, int idPerson, int TypeOfAccount)
        {
            this._id = anId;
            this._iban = anIban;
            this._bic = aBic;
            this._solde = aSolde;
            this._idPerson = idPerson;
            this._idTypeOfAccount = TypeOfAccount;

        }


        public int getId()
        {
            return this._id;
        }


        public string getIban()
        {
            return this._iban;
        }

        public string getBic()
        {
            return this._bic;
        }

        public double getSolde()
        {
            return this._solde;
        }

        public int getDebt()
        {
            return this._debt;
        }
        public int getLimit()
        {
            return this._limitSold;
        }
        public int getIdPerson()
        {
            return this._idPerson;
        }
        public int getTypeOfAccount()
        {
            return this._idTypeOfAccount;
        }

        public void setId(int anId)
        {
            this._id = anId;
        }

        public void setIban(string anIban)
        {
            this._iban = anIban;
        }

        public void setBic(string aBic)
        {
            this._bic = aBic;
        }

        public void setSolde(double aSolde)
        {
            this._solde = aSolde;
        }

        public void setIdPerson(int unId)
        {
            this._idPerson = unId;
        }
    }
}
