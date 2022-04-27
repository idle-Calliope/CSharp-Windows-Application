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
    public partial class Menu_Form : Form
    {
       //RegisterForm RF = new RegisterForm();
        DbStatements ds = new DbStatements();
        DbConnection dc = new DbConnection();

        public Menu_Form()
        {
            InitializeComponent();
        }

        private void registerPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OPEN REGISTER FORM
            RegisterForm RF = new RegisterForm();
            this.Hide();
            RF.Show();
        }

        private void viewPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         // VIEW ALL PATIENTS

            // REFRESH THE TABLE
            DataTable Patients = new DataTable();
            DgvPatients.DataSource = null;

            // REBIND THE DATA SOURCE
            try
            {
                ds.RetrievePatients(Patients);
                DgvPatients.DataSource = Patients;
                MessageBox.Show("PATIENTS TABLE UPDATED!", "NOTICE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allPatientsToolStripMenuItem_Click(object sender, EventArgs e){}

        private void bookAppointmentForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingsForm BF = new BookingsForm();
            
            // BOOK APPOINTMENT FOR PATIENT
            //this.Hide();
            BF.Show();
        }

        private void viewAllBookingsToolStripMenuItem_Click(object sender, EventArgs e){}

        private void mostRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VIEW ALL BOOKINGS ------- SORTED BY MOST RECENT
            DataTable Bookings = new DataTable();
            DgvBookings.DataSource = null;
            try
            { 
                ds.RetrieveBookingsDESC(Bookings);
                DgvBookings.DataSource = Bookings;
                MessageBox.Show("BOOKINGS TABLE UPDATED!", "NOTICE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void earliestEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VIEW ALL BOOKINGS ------ SORTED BY EARLIEST RECORD
            DataTable Bookings = new DataTable();
            DgvBookings.DataSource = null;
            try { 
                ds.RetrieveBookings(Bookings);
                DgvBookings.DataSource = Bookings;
                MessageBox.Show("BOOKINGS TABLE UPDATED!", "NOTICE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewAllDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VIEW ALL DOCTORS
            DataTable Doctors = new DataTable();
            DgvDoctors.DataSource = null;
            try
            {
                ds.RetrieveDoctors(Doctors);
                DgvDoctors.DataSource = Doctors;
                MessageBox.Show("DOCTORS TABLE UPDATED!", "NOTICE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void viewAllNursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VIEW ALL NURSE RECORDS
            DataTable Nurses = new DataTable();
            DgvNurses.DataSource = null;
            try
            {
                ds.RetrieveNurses(Nurses);
                DgvNurses.DataSource = Nurses;
                MessageBox.Show("NURSE TABLE UPDATED!", "NOTICE MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e){}

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            this.Hide();
            sf.Show();
        }

        private void patientRecordsToolStripMenuItem_Click(object sender, EventArgs e){}

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            // ON LOAD SHOWS PATIENT TABLE, BOOKINGS TABLE, DOCTORS TABLE
            DataTable Patients = new DataTable();
            DataTable Bookings = new DataTable();
            DataTable Doctors = new DataTable();
            DataTable Nurses = new DataTable();

            try
            {
                ds.RetrievePatients(Patients);
                DgvPatients.DataSource = Patients;

                ds.RetrieveBookings(Bookings);
                DgvBookings.DataSource = Bookings;

                ds.RetrieveDoctors(Doctors);
                DgvDoctors.DataSource = Doctors;

                ds.RetrieveNurses(Nurses);
                DgvNurses.DataSource = Nurses;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong in Menu Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateBookingRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingUpdate bu = new BookingUpdate();
            this.Hide();
            bu.Show();
        }

        private void DgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateDoctorRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
