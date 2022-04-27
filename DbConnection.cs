using System;
using System.Data.SqlClient;
using System.Windows.Forms;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    class DbConnection
    {
        // CHANGE DATA SOURCE HERE --------------
        string constring = "Data Source=DESKTOP-2R206H4;Initial Catalog=AFROMED_CLINIC;Integrated Security=True;Pooling=False";
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        SqlDataReader dr;

        public DbConnection()
        {
            try
            {
                this.con = new SqlConnection(this.constring);
                this.com = null;
                this.da = null;
                this.dr = null;
                //this.con.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void OpenConnection()
        {
            try
            {
                this.con.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                this.com.Dispose();
                this.con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void CreateCommand(string sql)
        {
            try
            {
                this.OpenConnection();
                this.com = new SqlCommand(sql, this.con);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void ExecuteCommand(string sql)
        {
            try
            {
                this.CreateCommand(sql);
                int result = this.com.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Execution successful");
                }
                else
                {
                    MessageBox.Show("Execution unsuccessful");
                }
                this.CloseConnection();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void ExecuteAdapter(string sql)
        {
            try
            {
                this.CreateCommand(sql);
                this.Da = new SqlDataAdapter(this.com);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        public void checkId()
        {
           try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MessageBox.Show("Login Successful", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bool success = true;
                        while(success)
                        {
                            Menu_Form mf = new Menu_Form();
                            mf.Show();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("ID not found!!!" + "\nRestart the application", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong : "+ex.Message);
            }
        }

        public void ExecuteReader(string sql)
        {
            try
            {
                this.CreateCommand(sql);
                this.Dr = this.com.ExecuteReader();
                this.checkId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOMETHING WENT WRONG!!! " + ex.Message + "\n\nPLEASE RESTART THE APPLICATION", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlDataAdapter Da
        {
            set { this.da = value; }
            get { return this.da; }
        }

        public SqlDataReader Dr
        {
            set { this.dr = value; }
            get { return this.dr; }
        }
    }
}
