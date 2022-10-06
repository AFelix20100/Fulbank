using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    class Wallet
    {
        private bool _sold;
        private bool _amount;
        private string _date;
        private bool _sellingRate;
        private User _Person;
        private CryptoCurrency _crypto;

        public Wallet(bool aSold, bool anAmount, string aDate, bool aSellingRate, User aPersonn, CryptoCurrency aCrypto)
        {
            this._sold = aSold;
            this._amount = anAmount;
            this._date = aDate;
            this._sellingRate = aSellingRate;
            this._Person = aPersonn;
            this._crypto = aCrypto;

        }

        //getter 
        public bool getSold()
        {
            return this._sold;
        }

        public bool getAmount()
        {
            return this._amount;
        }

        public string getDate()
        {
            return this._date;
        }

        public bool getSellingRate()
        {
            return this._sellingRate;
        }

        public User getPerson()
        {
            return this._Person;
        }

        public CryptoCurrency getCrypto()
        {
            return this._crypto;
        }

        //setter

        public void setSold(bool aSold)
        {
            this._sold = aSold;
        }

        public void setAmount(bool anAmount)
        {
            this._amount = anAmount;
        }

        public void setDate(string aDate)
        {
            this._date = aDate;
        }

        public void setSellingRate(bool aSellingRate)
        {
            this._sellingRate = aSellingRate;
        }

        public void setPerson(User aPerson)
        {
            this._Person = aPerson;
        }

        public void setCrypto(CryptoCurrency aCrypto)
        {
            this._crypto = aCrypto;
        }



    }
}
