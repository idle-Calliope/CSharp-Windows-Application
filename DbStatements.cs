using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; // For the Data Table

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    class DbStatements
    {
        DbConnection dc = new DbConnection();

        public void RegisterPatients(Patients patients)
        {
            string sql = "INSERT INTO Patients VALUES ('"+patients.Patient_ID+"','"+patients.Full_Names+"','"+patients.Phone+"','"+patients.Emails+"','"+patients.Bank_Card+"','"+patients.Bank_Name+"','"+patients.Account_Num+"')";
            MessageBox.Show("Registration Successful");
            dc.ExecuteCommand(sql);
        }

        public void RetrievePatients(DataTable patients)
        {
            string sql = "SELECT * FROM Patients";

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(patients);
            dc.CloseConnection();
        }

        public void SearchPatients(DataTable patients, int ID)
        {
            string sql = "SELECT * FROM Patients WHERE PatientID ="+ID;

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(patients);
            dc.CloseConnection();
        }

        public void BookPatient(Bookings bookings)
        {
            // (BID, patients, date, checkin, checkout, description, doctors, nurse, Room, Bill, status);
            string sql = "INSERT INTO Bookings VALUES ( '"+bookings.Booking_ID+"','"+bookings.PatientsID+"','"+bookings.Date_Booked+"','"+bookings.CheckIN+"','"+bookings.CheckOUT+"','"+bookings.Descriptions+"','"+bookings.DoctorID+"','"+bookings.NurseID+"','"+bookings.Rooms+"','"+bookings.Bills+"','"+bookings.Status_+"','"+bookings.Availability+"')";
            MessageBox.Show("Booking successful");
            dc.ExecuteCommand(sql);
        }

        public void SearchBookings(DataTable bookings, int ID)
        {
            string sql = "SELECT * FROM Bookings WHERE BookingID =" + ID;

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(bookings);
            dc.CloseConnection();
        }

        public void RetrieveBookings(DataTable bookings)
        {
            string sql = "SELECT * FROM Bookings";

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(bookings);
            dc.CloseConnection();
        }

        public void RetrieveBookingsDESC(DataTable bookings)
        {
            string sql = "SELECT * FROM Bookings ORDER BY Date_booked DESC";

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(bookings);
            dc.CloseConnection();
        }

        public void UpdateBookings(Bookings bookings)
        {
            string sql = "UPDATE Bookings SET Check_IN = '" +bookings.CheckIN+ "' ," +
                                             "Check_OUT = '" +bookings.CheckOUT+ "' ," +
                                             "Descriptions = '" +bookings.Descriptions+ "' ," +
                                             "Doctor_Assigned = '" +bookings.DoctorID+ "' ," +
                                             "Room_No = '" +bookings.Rooms+ "' ," +
                                             "Bill = '" +bookings.Bills+ "' ," +
                                             "Status_ = '" +bookings.Status_+ "' ," +
                                             "Doctor_Nurse_Availability ='"+bookings.Availability+"'" +
                                             "WHERE BookingID = " +bookings.Booking_ID;
            //('"+bookings.Booking_ID+"', '"+bookings.PatientsID+"', '"+bookings.Date_Booked+"', '"+bookings.CheckIN+"', '"+bookings.CheckOUT+"', '"+bookings.Descriptions+"', '"+bookings.DoctorID+"', '"+bookings.NurseID+"', '"+bookings.Rooms+"', '"+bookings.Bills+"', '"+bookings.Status_+"')"

            //dc.CreateCommand(sql);
            dc.ExecuteCommand(sql);
            dc.CloseConnection();
        }

        public void UpdateAudit(AuditLog auditLog)
        {
            string sql = "INSERT INTO Audit_Log VALUES ('"+auditLog.ID_+"','"+auditLog.Timechanged+"','"+auditLog.Reasons_+"','"+auditLog.Tablename+"')";
            dc.ExecuteCommand(sql);
        }

        public void GetAudit()
        {
            string sql = "SELECT * FROM BookingsAudit";
            dc.ExecuteAdapter(sql);
            dc.CloseConnection();
        }

        public void SearchDoctors(DataTable doctors, int ID)
        {
            string sql = "SELECT * FROM Doctors WHERE Doctor_ID =" + ID;

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(doctors);
            dc.CloseConnection();
        }

        public void RetrieveDoctors(DataTable doctors)
        {
            string sql = "SELECT * FROM Doctors";

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(doctors);
            dc.CloseConnection();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            string sql = "UPDATE Doctors SET Availability_ = '" + doctor.Availability_ + "' WHERE Doctor_ID = "+doctor.Doctor_ID;
            dc.ExecuteCommand(sql);
            dc.CloseConnection();
        }

        public void UpdateNurse(Nurse nurse)
        {
            string sql = "UPDATE Nurses SET Availability_ = '" + nurse.Availability_ +"' WHERE Nurse_ID = "+nurse.Nurse_ID;
            dc.ExecuteCommand(sql);
            dc.CloseConnection();
        }

        public void RetrieveNurses(DataTable nurses)
        {
            string sql = "SELECT * FROM Nurses";

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(nurses);
            dc.CloseConnection();
        }

        public void SearchNurses(DataTable nurses, int ID)
        {
            string sql = "SELECT * FROM Nurses WHERE Nurse_ID =" + ID;

            dc.ExecuteAdapter(sql);
            dc.Da.Fill(nurses);
            dc.CloseConnection();
        }

        public void RetrieveAdmin(int id,int password)
        {
            string sql = "SELECT * FROM Admins WHERE AdminID ="+id+" AND Admin_Password ="+password;

            dc.ExecuteReader(sql);
            //dc.ExecuteAdapter(sql);
            dc.CloseConnection();
        }

        

    }
}
