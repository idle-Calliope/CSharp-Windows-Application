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
    public partial class RegisterForm : Form
    {
        DbConnection dc = new DbConnection();
        DbStatements ds = new DbStatements();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ListCardName_SelectedIndexChanged(object sender, EventArgs e){}
        private void GBCardDetails_Enter(object sender, EventArgs e){}
        private void RDBtnDebit_CheckedChanged(object sender, EventArgs e){}
        private void RDBtnCredit_CheckedChanged(object sender, EventArgs e){}

        private void BtnRegisterPatient_Click(object sender, EventArgs e)
        {
            DataTable Patients = new DataTable();

            try
            {
                // Patient ID ---- IDENTITY (1900,1)
                int pid = Convert.ToInt32(this.TxtID.Text);
                string names = this.TxtFullName.Text;
                int phone = Convert.ToInt32(this.TxtPhoneNum.Text);
                string email = this.TxtEmail.Text;
                string card_type = this.CBoxType.Text;
                string card_name = this.CBoxCardName.Text;
                int acc = Convert.ToInt32(this.TxtAccountNum.Text);
                string text =   "PID : " + pid +
                                "\nNames : "+names+
                                "\nPhone : "+phone+
                                "\nEmail : "+email+
                                "\nCard Type : "+card_type+
                                "\nCard Name : "+card_name+
                                "\nAcc No : "+acc;
                
                MessageBox.Show(text);
            
                Patients patients = new Patients(pid, names, phone, email, card_type, card_name, acc);
                
                ds.RegisterPatients(patients);
                ds.RetrievePatients(Patients);
                Menu_Form mf = new Menu_Form();
                this.Hide();
                mf.Show();

                dc.CloseConnection();
            }
            // OTHER EXCEPTIONS MAY BE CAUGHT ------ FORMAT EXCEPTION, EMPTY OBJECTS
            catch(Exception ex)
            {
                 MessageBox.Show("Something went wrong in Register Form" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
     
        }

        private void RegisterForm_Load(object sender, EventArgs e){}

        private void GBRegister_Enter(object sender, EventArgs e){}

        private void LblPatientID_Click(object sender, EventArgs e){}

        private void LblPatientName_Click(object sender, EventArgs e){}

        private void LblAccountNum_Click(object sender, EventArgs e){}

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
