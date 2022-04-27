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
    public partial class BookingsForm : Form
    {
        DbStatements ds = new DbStatements();
        DbConnection dc = new DbConnection();

        public BookingsForm()
        {
            InitializeComponent();
        }

        private void LblDoctorID_Click(object sender, EventArgs e){}

        private void BookingsForm_Load(object sender, EventArgs e){}

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DataTable Bookings = new DataTable();

            int BID = Convert.ToInt32(TxtBookingID.Text),
                PID = Convert.ToInt32(TxtPatientID.Text),
                DID = Convert.ToInt32(TxtDoctorID.Text),
                NID = Convert.ToInt32(TxtNurseID.Text),
                Room = Convert.ToInt32(TxtRoom.Text);
            DateTime dt = DtpDateBooked.Value;
            string date = dt.ToString("yyyy-MM-dd");
            double Bill = Convert.ToDouble(TxtBill.Text);
            string status = TxtStatus.Text,
                   description = TxtDescription.Text,
                   checkin = TxtCheckIN.Text,
                   checkout = TxtCheckOut.Text;
            MessageBox.Show(   "BID      : " + BID+
                               "\nPID      : " + PID +
                               "\nDID    : " + DID +
                               "\nNID    : " + NID +
                               "\nROOM   : " + Room +
                               "\nBILL   : " + Bill +
                               "\nSTATUS : " + status +
                               "\nDESC   : " + description +
                               "\nCHECKIN: " + checkin +
                               "\nCHECKOUT:" + checkout
                            );
            try
            {
                Bookings bookings = new Bookings(BID, PID, date, checkin, checkout, description, DID, NID, Room, Bill, status,"PENDING");

                ds.BookPatient(bookings);
                ds.RetrieveBookingsDESC(Bookings);
                this.Hide();
                dc.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong in Bookings Form: "+ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("Are you sure you want to Reset?\nYou will lose all your progress","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dgr == DialogResult.Yes)
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

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("Are you sure you want to leave this window?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dgr == DialogResult.Yes)
            {
                Menu_Form mf = new Menu_Form();
                this.Hide();
                mf.Show();
            }
                
        }
    }
}
