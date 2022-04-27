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
    class Doctor
    {
        private int DoctorID, Age, PhoneNumber;
        private string Fullnames, Email, Availability;
        private char Gender;

        public Doctor()
        {
            this.DoctorID = 1700;
            this.Age = 35;
            this.PhoneNumber = 63521832;
            this.Fullnames = "Derek Shepherd";
            this.Email = "derek.shepherd@ica.com";
            this.Gender = 'M';
            this.Availability = "AVAILABLE";
        }

        public Doctor(int id,int age,int phone,string names,string email,char gender,string availabity)
        {
            this.DoctorID = id;
            this.Age = age;
            this.PhoneNumber = phone;
            this.Fullnames = names;
            this.Email = email;
            this.Gender = gender;
            this.Availability = availabity;
        }

        public int Doctor_ID
        {
            get { return this.DoctorID; }
            set { this.DoctorID = value; }
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

        //public Doctor(int id)
        //{
        //    this.DoctorID = id;
        //}

        public string print()
        {

            int doctorid = this.DoctorID;
            int age = this.Age;
            int phone = this.PhoneNumber;
            string names = this.Fullnames;
            string email = this.Email;
            char gender = this.Gender;
            string availabilities = this.Availability;

            string message = "\n" + doctorid +
                             "\n" + age +
                             "\n" + phone +
                             "\n" + names +
                             "\n" + email +
                             "\n" + gender+
                             "\n" + availabilities;

            return message;
        }
    }
}
