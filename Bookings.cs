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
    class Bookings
    {
        private int BookingID, Room;
        private double Bill;
        private string Checkin, Checkout;
        private string Description;
        private string Status;
        private string DateBooked;
        private int patients_ID;
        private int doctorsID;
        private int nursesID;
        private string availability;
        

        public Bookings()
        {
            this.BookingID = 2300;
            this.patients_ID = 1900;
            this.DateBooked = "20Dec2021";
            this.Checkin = "20:00:00";
            this.Checkout = "20:00:00";
            this.Description = "C-Section";
            this.doctorsID = 1700;
            this.nursesID = 1600;
            this.Room = 1;
            this.Bill = 3301.20;
            this.Status = "PENDING";
            this.availability = "AVAILABLE";
        }


        public Bookings(int id, int patientID, string datebooked, string checkin, string checkout, string description, int doctorID, int nurseID, int room, double bill, string status,string availability)
        {
            this.BookingID = id;
            this.patients_ID = patientID;
            this.DateBooked = datebooked;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Description = description;
            this.doctorsID = doctorID;
            this.nursesID = nurseID;
            this.Room = room;
            this.Bill = bill;
            this.Status = status;
            this.availability = availability;
        }

        //public Bookings(int id, Patients patient,string datebooked,string checkin,string checkout,string description,Doctor doctor,Nurse nurse,int room,double bill,string status)
        //{
        //    this.BookingID = id;
        //    this.patients_ = patient;
        //    this.Checkin = checkin;
        //    this.Checkout = checkout;
        //    this.Description = description;
        //    this.doctors = doctor;
        //    this.nurses = nurse;
        //    this.Room = room;
        //    this.Bill = bill;
        //    this.Status = status;
        //}

        public int PatientsID
        {
            get { return this.patients_ID; }
            set { this.patients_ID = value; }
        }
        
        public int DoctorID
        {
            get { return this.doctorsID; }
            set { this.doctorsID = value; }
        }

        public int NurseID
        {
            get { return this.nursesID; }
            set { this.nursesID = value; }
        }

        //public Patients Patients { get; set; }
        //public Doctor Doctor { get; set; }
        //public Nurse Nurse { get; set; }

        public int Booking_ID
        {
            get { return this.BookingID; }
            set { this.BookingID = value; }
        }

        public int Rooms
        {
            get { return this.Room; }
            set { this.Room = value; }
        }

        public double Bills
        {
            get { return this.Bill; }
            set { this.Bill = value; }
        }

        public string Date_Booked
        {
            get { return this.DateBooked; }
            set { this.DateBooked = value; }
        }

        public string CheckIN
        {
            get { return this.Checkin; }
            set { this.Checkin = value; }
        }

        public string CheckOUT
        {
            get { return this.Checkout; }
            set { this.Checkout = value; }
        }

        public string Descriptions
        {
            get { return this.Description; }
            set { this.Description = value; }
        }
        
        public string Status_
        {
            get { return this.Status; }
            set { this.Status = value; }
        }

        public string Availability
        {
            get { return this.availability; }
            set { this.availability = value; }
        }

        public string print()
        {
            int bookid = this.BookingID;
            int patientid =this.patients_ID;
            string datebooked = this.DateBooked;
            string checkin =this.Checkin;
            string checkout = this.Checkout;
            string desc = this.Description;
            int doctorid = this.doctorsID;
            int nurseid = this.nursesID;
            int room = this.Room;
            double bill = this.Bill;
            string status = this.Status;
            string avail = this.availability;

            string message = "\n" + bookid +
                             "\n" + patientid +
                             "\n" +datebooked+
                             "\n" + checkin +
                             "\n" + checkout +
                             "\n" + desc+
                             "\n" + doctorid+
                             "\n" + nurseid+
                             "\n" + room+
                             "\n" + bill+
                             "\n" + status+
                             "\n" + avail;

            return message;
        }

    }
}
