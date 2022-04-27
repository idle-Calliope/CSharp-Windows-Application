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
    class Admin
    {
        private int AdminID, PhoneNumber, AdminPassword;
        private string Fullnames, Email;

        public Admin()
        {
            this.AdminID = 2100;
            this.PhoneNumber = 51907880;
            this.AdminPassword = 1234;
            this.Fullnames = "Moses Lawson";
            this.Email = "moses.lawson@ica.com";
        }

        public Admin(int id, int phone, int password,string names, string email)
        {
            this.AdminID = id;
            this.PhoneNumber = phone;
            this.AdminPassword = password;
            this.Fullnames = names;
            this.Email = email;
        }

        public int Admin_ID
        {
            get { return this.AdminID; }
            set { this.AdminID = value; }
        }

        public int Phone_Number
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }

        public int Phone_Numbers
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }

        public string Full_Names
        {
            get { return this.Fullnames; }
            set { this.Fullnames = value; }
        }

        public string Email_Address
        {
            get { return this.Email; }
            set { this.Email = value; }
        }

        public string print()
        {
            int adminid = this.AdminID;
            int phone = this.PhoneNumber;
            int pwd = this.AdminPassword;
            string names = this.Fullnames;
            string email = this.Email;

            string message = "\n"+adminid+
                             "\n"+phone+
                             "\n"+pwd+
                             "\n"+names+
                             "\n"+email;

            return message;
        }

        
    }
}
