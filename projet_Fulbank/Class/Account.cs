using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    public class Account
    {
        private int _id;
        private string _iban;
        private double _bic;
        private double _solde;
        private int _debt;
        private int _limitSold;
        private User _person;
        private int _idTypeOfPerson;

        public Account(int anId, string anIban, double aBic, double aSolde, int debt, int limitSold, User aPerson, int TypeOfAccount)
        {
            this._id = anId;
            this._iban = anIban;
            this._bic = aBic;
            this._solde = aSolde;
            this._debt = debt;
            this._limitSold = limitSold;
            this._person = aPerson;
            this._idTypeOfPerson = TypeOfAccount;

        }
        public int getId()
        {
            return this._id;
        }


        public string getIban()
        {
            return this._iban;
        }

        public double getBic()
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
        public User getUser()
        {
            return this._person;
        }
        public int getTypeOfAccount()
        {
            return this._idTypeOfPerson;
        }

        public void setId(int anId)
        {
            this._id = anId;
        }

        public void setIban(string anIban)
        {
            this._iban = anIban;
        }

        public void setBic(double aBic)
        {
            this._bic = aBic;
        }

        public void setSolde(double aSolde)
        {
            this._solde = aSolde;
        }

        public void setUser(User unUser)
        {
            this._person = unUser;
        }
    }
}
