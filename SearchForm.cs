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
    public partial class SearchForm : Form
    {
        DbStatements ds = new DbStatements();
        DbConnection dc = new DbConnection();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(this.TxtID.Text);
            string table = this.CBoxTable.GetItemText(this.CBoxTable.SelectedItem);

            MessageBox.Show("ID    : "+ID+
                            "\nTable : "+table);
            try
            { 
                switch(table)
                {
                    case "Patients":
                        DgvRecords.Show();
                        DataTable Patients = new DataTable();
                        DgvRecords.DataSource = null;
                        ds.SearchPatients(Patients, ID);
                        DgvRecords.DataSource = Patients;
                        break;
                    case "Bookings":
                        DgvRecords.Show();
                        DataTable Bookings = new DataTable();
                        DgvRecords.DataSource = null;
                        ds.SearchBookings(Bookings, ID);
                        DgvRecords.DataSource = Bookings;
                        break;
                    case "Doctors":
                        DgvRecords.Show();
                        DataTable Doctors = new DataTable();
                        DgvRecords.DataSource = null;
                        ds.SearchDoctors(Doctors, ID);
                        DgvRecords.DataSource = Doctors;
                        break;
                    case "Nurses":
                        DgvRecords.Show();
                        DataTable Nurses = new DataTable();
                        DgvRecords.DataSource = null;
                        ds.SearchNurses(Nurses, ID);
                        DgvRecords.DataSource = Nurses;
                        break;
                    default:
                        MessageBox.Show("You have not selected a table","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in Search Form: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void SearchForm_Load(object sender, EventArgs e)
        {
            DgvRecords.Hide();
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
    }
}
