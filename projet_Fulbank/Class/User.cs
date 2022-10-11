using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class
{
    public class User
    {
        private int _id;
        private string _last_name;
        private string _first_name;
        private string _mail;
        private double _number;
        private string _adress;
        private int _cp;
        private string _city;
        private string _country;
        private int _aType;
        private string _password;
        private long _login;
        //public static List<User> AllUsers = new List<User>();
        private List<Account> AllAccount;

        public User(int anId, string aLastName, string aFirstName, string aMail, double aNumber, string anAdress, int aCp, string aCity, string oneCoutry,int aType)
        {
            this._id = anId;
            this._last_name = aLastName;
            this._first_name = aFirstName;
            this._mail = aMail;
            this._number = aNumber;
            this._adress = anAdress;
            this._cp = aCp;
            this._city = aCity;
            this._country = oneCoutry;
            this._aType = aType;
            //this._login = generateId();
            //this._password = generatePassword();
            this.AllAccount = new List<Account>();
            //AllUsers.Add(this);
        }
        public User(int anId, string aLastName, string aFirstName, string aMail, double aNumber, string anAdress, int aCp, string aCity, string oneCoutry, long unLogin, string unPassword,int aType)
        {
            this._id = anId;
            this._last_name = aLastName;
            this._first_name = aFirstName;
            this._mail = aMail;
            this._number = aNumber;
            this._adress = anAdress;
            this._cp = aCp;
            this._city = aCity;
            this._country = oneCoutry;
            this._aType = aType;
            //this._login = generateId();
            //this._password = generatePassword();
            this._login = unLogin;
            this._password = unPassword;
            this.AllAccount = new List<Account>();
            //AllUsers.Add(this);
        }

        //Getters
        public int getId()
        { 
            return this._id;
        }

        public string getLastName()
        {
            return this._last_name;
        }

        public string getFirstName()
        {
            return this._first_name;
        }

        public string getMail()
        {
            return this._mail;
        }

        public double getNumber()
        {
            return this._number;
        }

        public string getAdress()
        {
            return this._adress;
        }

        public int getCp()
        {
            return this._cp;
        }

        public string getCity()
        {
            return this._city;
        }

        public string getCountry()
        {
            return this._country;
        }
        /*
		public int getTypeOfPerson()
		{
			return this._aType;
		}
		*/
        public long getLogin()
        {
            return this._login;
        }

        public string getPassword()
        {
            return this._password;
        }
        /*
        public List<Account> getLesComptes()
        {
            return this.AllAccount;
        }
        */
        /*
        public static List<User> getLesUsers()
        {
            return AllUsers;
        }
        */
        //Setters
        public void setId(int anId)
        {
            this._id = anId;
        }

        public void setLastName(string aLastName)
        {
            this._last_name = aLastName;
        }

        public void setFirstName(string aFirstName)
        {
            this._first_name = aFirstName;
        }

        public void setMail(string aMail)
        {
            this._mail = aMail;
        }

        public void setNumber(double aNumber)
        {
            this._number = aNumber;
        }

        public void setAdress(string anAdress)
        {
            this._adress = anAdress;
        }

        public void setCp(int aCp)
        {
            this._cp = aCp;
        }

        public void setCity(string aCity)
        {
            this._city = aCity;
        }

        public void setCountry(string aCountry)
        {
            this._country = aCountry;
        }
        /*
		public void setTypeOfPerson(string aType)
		{
			this._aType = aType;
		}
		*/
       /*public void setLogin(string aLogin)
        {
            this._login = aLogin;
        }
        */
        public void setPassword(string aPassword)
        {
            this._password = aPassword;
        }
        /*
        public void addAccount(Account unCompte)
        {
            this.AllAccount.Add(unCompte);
        }
        */
        public override string ToString()
        {
            return this._last_name + " " + this._first_name;
        }

        private static long generateId()
        {
            long anId = 0;
            Random random = new Random();
            anId = random.Next(100000000,999999999);
            return anId;
        }

        public static string generatePassword()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int i = 0; i < 10; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, sb.ToString());
                return hash;
            }
            
        }
        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }

    }
}
