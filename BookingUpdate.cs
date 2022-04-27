using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    public partial class BookingUpdate : Form
    {
        DbStatements ds = new DbStatements();
        DbConnection dc = new DbConnection();
        public BookingUpdate()
        {
            InitializeComponent();
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e){ }
        private void LblPatientID_Click(object sender, EventArgs e){ }
        private void LblCheckIN_Click(object sender, EventArgs e){ }

        public void calculateBill(DateTime dt, double amount)
        {
            // CHECK IF CUURENT CANCEL DATE IS THE DATE BOOKED
            DateTime UpdateDate = DateTime.Now;
            if (dt == UpdateDate)
                amount = 4789.49;
            else 
                amount -= amount;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
             // REFRESH TABLE
                DataTable Bookings = new DataTable();
                DgvBookings.DataSource = null;

             // INPUT CONVERSION
            int BID = Convert.ToInt32(TxtBookingID.Text),
                PID = Convert.ToInt32(TxtPatientID.Text),
                DID = Convert.ToInt32(TxtDoctorID.Text),
                NID = Convert.ToInt32(TxtNurseID.Text),
                Room = Convert.ToInt32(TxtRoom.Text);
            
            DateTime dt = DtpDateBooked.Value;
            string date = dt.ToString("yyyy-MM-dd"),
                   status = TxtStatus.Text,
                   description = TxtDescription.Text,
                   checkin = TxtCheckIN.Text,
                   checkout = TxtCheckOut.Text,
                   avail = TxtAvail.Text;

            double Bill = Convert.ToDouble(TxtBill.Text);

            //  VARIABLES FOR WRITING TO AUDIT FILE  
            
            // CHANGE FOLDER AND FILENAME HERE--------------- 
                string folder = @"C:\Users\Ella\Desktop\";
                string fileName = "TXTFILE.txt";
                string fullPath = folder + fileName;

                FilesReadWrite frw = new FilesReadWrite(folder, fileName, fullPath);

                string current_time = DateTime.Now.ToString("hh:mm:ss"); // FOR AUDIT LOG
                AuditLog al = new AuditLog(BID, current_time, status, "Booking Table");
            try
            {
                /*
                 *  CREATE AN INSTANCE OF BOOKINGS
                 *  PASS THE INPUT TO ITS OBJECT
                 */
                if (status.Equals("CANCELED"))
                {
                    calculateBill(dt, Bill); // Updates BILL when booking is canceled
                    Bookings bookings = new Bookings(BID, PID, date, checkin, checkout, description, DID, NID, Room, Bill, status, avail);
                    Nurse nurse = new Nurse(NID, 34, 65039030, "some name", "email", 'f', "AVAILABLE");
                    Doctor doctor = new Doctor(DID, 35, 68990321, "some other name", "email", 'm', "AVAILABLE");

                    ds.UpdateNurse(nurse);
                    ds.UpdateDoctor(doctor);
                    ds.UpdateBookings(bookings);

                    // AuditLog al is converted to string to write to file
                    string message = al.print();
                    frw.ReadAndWrite("\n" + message);
                    ds.UpdateAudit(al);
                    
                    ds.RetrieveBookingsDESC(Bookings);
                    dc.CloseConnection();
                }
                if(status.Equals("DISCHARGED"))
                {
                    Bill -= Bill; // Debits BILL When Patient DISCHARGES

                    Bookings bookings = new Bookings(BID, PID, date, checkin, checkout, description, DID, NID, Room, Bill, status, avail);
                    Nurse nurse = new Nurse(NID, 34, 65039030, "some name", "email", 'f', "AVAILABLE");
                    Doctor doctor = new Doctor(DID, 35, 68990321, "some other name", "email", 'm', "AVAILABLE");

                    ds.UpdateNurse(nurse);
                    ds.UpdateDoctor(doctor);
                    ds.UpdateBookings(bookings);

                    string message = al.print();
                    frw.ReadAndWrite("\n" + message);
                    ds.UpdateAudit(al);

                    ds.RetrieveBookingsDESC(Bookings);
                    dc.CloseConnection();
                }
                else
                {
                    

                    Bookings bookings = new Bookings(BID, PID, date, checkin, checkout, description, DID, NID, Room, Bill, status, avail);
                    Nurse nurse = new Nurse(NID, 34, 65039030, "some name", "email", 'f', "UNAVAILABLE");
                    Doctor doctor = new Doctor(DID, 35, 68990321, "some other name", "email", 'm', "UNAVAILABLE");

                    ds.UpdateNurse(nurse);
                    ds.UpdateDoctor(doctor);
                    ds.UpdateBookings(bookings);

                    string message = al.print();
                    frw.ReadAndWrite("\n" + message);
                    ds.UpdateAudit(al);

                    ds.RetrieveBookingsDESC(Bookings);
                    dc.CloseConnection();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong IN BOOKING UPDATE.CS: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BookingUpdate_Load(object sender, EventArgs e)
        {
            DataTable Bookings = new DataTable();
            ds.RetrieveBookings(Bookings);
            DgvBookings.DataSource = Bookings;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable Bookings = new DataTable();
            DgvBookings.DataSource = null;
            int ID = Convert.ToInt32(this.TxtID.Text);

            ds.SearchBookings(Bookings, ID);
            DgvBookings.DataSource = Bookings;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("Are you sure you want to leave this window?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Menu_Form mf = new Menu_Form();
            if (dgr == DialogResult.Yes)
            {
                this.Hide();
                mf.Show();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
        //  CONFIRM WINDOW TO EXIT BACK TO MAIN MENU
            DialogResult dgr = MessageBox.Show("Are you sure you want to Reset?\nYou will lose all your progress", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dgr == DialogResult.Yes)
            {
                this.TxtBookingID.Text = null;
                this.TxtPatientID.Text = null;
                this.TxtDescription.Text = null;
                this.TxtDoctorID.Text = null;
                this.TxtNurseID.Text = null;
                this.TxtRoom.Text = null;
                this.TxtBill.Text = null;
                this.TxtStatus.Text = null;
            }
        }

        private void GBoxBookings_Enter(object sender, EventArgs e){}
    }
}
