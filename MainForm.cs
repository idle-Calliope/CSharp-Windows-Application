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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e){}

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
         // OPENS LOGIN FORM
            LoginForm lf = new LoginForm(); 
            this.Hide();
            lf.Show();
        }

    }
}
