using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    class Patients
    {
        private int PatientID;
        private string FullNames;
        private int PhoneNumber;
        private string Email;
        private string BankCard;
        private string BankName;
        private int AccountNumber;

        public Patients()
        {
            this.PatientID = 1900;
            this.FullNames = "First Second";
            this.PhoneNumber = 22231200;
            this.Email = "first.second@ica.com";
            this.BankCard = "Credit Card";
            this.BankName = "FNB";
            this.AccountNumber = 12334455;
        }

        public Patients(int id, string names,int phone,string email,string bankcard, string bankname,int accnum)
        {
            this.PatientID = id;
            this.FullNames = names;
            this.PhoneNumber = phone;
            this.Email = email;
            this.BankCard = bankcard;
            this.BankName = bankname;
            this.AccountNumber = accnum;
        }

        //public Patients(int id)
        //{
        //    this.PatientID = id;
        //}

        public int Patient_ID
        {
            get { return this.PatientID; }
            set { this.PatientID = value; }
        }

        public string Full_Names
        {
            get { return this.FullNames; }
            set { this.FullNames = value; }
        }

        public int Phone
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }

        public string Emails
        {
            get { return this.Email; }
            set { this.Email = value; }
        }

        public string Bank_Card
        {
            get { return this.BankCard; }
            set { this.BankCard = value; }
        }

        public string Bank_Name
        {
            get { return this.BankName; }
            set { this.BankName = value; }
        }

        public int Account_Num
        {
            get { return this.AccountNumber; }
            set { this.AccountNumber = value; }
        }

        public string print()
        {
            int pid = this.PatientID;
            string names = this.FullNames;
            int phone = this.PhoneNumber;
            string email = this.Email;
            string card = this.BankCard;
            string cardname = this.BankName;
            int acc = this.AccountNumber;

            string message = "\n" + pid +
                             "\n" + names +
                             "\n" + phone +
                             "\n" + email +
                             "\n" + card +
                             "\n" + cardname +
                             "\n" + acc;

            return message;
        }
    }
}
