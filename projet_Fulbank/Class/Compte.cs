using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    abstract class Compte
    {
        private int _id;
        private string _iban;
        private double _bic;
        private double _solde;
        private User _person;

        public Compte(int anId, string anIban, double aBic, double aSolde, User aPerson)
        {
            this._id = anId;
            this._iban = anIban;
            this._bic = aBic;
            this._solde = aSolde;
            this._person = aPerson;
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
        public User getUser()
        {
            return this._person;
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
