using System;
using System.Windows.Forms;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    public partial class LoginForm : Form
    {
        DbConnection dc = new DbConnection();
        DbStatements ds = new DbStatements();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e){}

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.TxtID.Text);
                int password = Convert.ToInt32(this.TxtPassword.Text);

                ds.RetrieveAdmin(id, password);
                this.Hide();
            }
            // Multicatch clause
            catch(FormatException ex) {MessageBox.Show("Something went wrong in Login Form" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch(Exception ex){ MessageBox.Show("Something went wrong in Login Form"+ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }

        private void GBAdmin_Enter(object sender, EventArgs e){}
        private void TxtID_TextChanged(object sender, EventArgs e){}
        private void LblID_Click(object sender, EventArgs e){}
        private void TxtPassword_TextChanged(object sender, EventArgs e){}
        private void LblPassword_Click(object sender, EventArgs e){}
    }
}
