using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using projet_Fulbank.Class.Model;

namespace projet_Fulbank.Class
{
    public class Operation
    {
   
        private int _id;
        private DateTime _date;
        private double _amount;
        private string _description;
        private Account _idDebitor;
        private Account _idCreditor;
        private int _aType;

        public Operation(int anId, DateTime aDate, double anAmout, string aDescription, Account aDebitor, Account aCreditor, int aType)
        {
            this._id = anId;
            this._date = aDate;
            this._amount = anAmout;
            this._description = aDescription;
            this._idDebitor = aDebitor;
            this._idCreditor = aCreditor;
            this._aType = aType;
        }

        public Operation(int anId, DateTime aDate, double anAmout, string aDescription, Account aDebitor, int aType)
        {
            this._id=anId;
            this._date=aDate;
            this._amount=anAmout;
            this._description=aDescription;
            this._idDebitor=aDebitor;
            this._aType=aType;
        }

        //getter
        
        public int getId()
        {
            return this._id;
        }

        public DateTime getDate()
        {
            return this._date;
        }

        public double getAmount()
        {
            return this._amount;
        }

        public string getDescription()
        {
            return this._description;
        }

        public Account getDebitor()
        {
            return this._idDebitor;
        }

        public Account getCreditor()
        {
            return this._idCreditor;
        }

        public int getType()
        {
            return this._aType;
        }

        //setter

        public void setId(int anId)
        {
            this._id=anId;
        }

        public void setDate(DateTime aDate)
        {
            this._date= aDate;
        }

        public void setAmount(double anAmount)
        {
            this._amount = anAmount;
        }

        public void setDescription(string aDescription)
        {
            this._description=aDescription;
        }

        public void setCreditior(Account aCreditior)
        {
            this._idCreditor = aCreditior;
        }

        public void setDebitor(Account aDebitor)
        {
            this._idDebitor=aDebitor;
        } 

        public void setType(int aType)
        {
            this._aType = aType;
        }
       


        //fonction pour retirer de l'argent
        //withdrawal=retrait
       














    }
}
