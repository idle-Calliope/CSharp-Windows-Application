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
    class Nurse
    {
        private int NurseID, Age, PhoneNumber;
        private string Fullnames, Email,Availability;
        private char Gender;

        public Nurse()
        {
            this.NurseID = 1600;
            this.Age = 31;
            this.PhoneNumber = 63521832;
            this.Fullnames = "Bailey Wey";
            this.Email = "bailey.wey@ica.com";
            this.Gender = 'F';
            this.Availability = "AVAILABLE";
        }

        public Nurse(int id, int age, int phone, string names, string email, char gender, string availabilities)
        {
            this.NurseID = id;
            this.Age = age;
            this.PhoneNumber = phone;
            this.Fullnames = names;
            this.Email = email;
            this.Gender = gender;
            this.Availability = availabilities;
        }
        
        public int Nurse_ID
        {
            get { return this.NurseID; }
            set { this.NurseID = value; }
        }

        public int Age_
        {
            get { return this.Age; }
            set { this.Age = value; }
        }

        public int Phone_Number
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

        public char Gender_
        {
            get { return this.Gender; }
            set { this.Gender = value; }
        }

        public string Availability_
        {
            get { return this.Availability; }
            set { this.Availability = value; }
        }

        public string print()
        {
            int nurseid = this.NurseID;
            int age = this.Age;
            int phone = this.PhoneNumber;
            string names = this.Fullnames; 
            string email = this.Email;
            char gender = this.Gender;
            string availabities = this.Availability;


            string message = "\n" + nurseid +
                             "\n" + age +
                             "\n" + phone +
                             "\n" + names +
                             "\n" + email +
                             "\n" + gender+
                             "\n" + availabities;

            return message;
        }



        //public Nurse(int id)
        //{
        //    this.NurseID = id;
        //}
    }
}
