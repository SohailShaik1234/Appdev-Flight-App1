using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Staff_Password : Form
    {
        
        string staffPassword = "12345678";


        public Staff_Password()
        {
            InitializeComponent();
           
            this.WindowState = FormWindowState.Maximized;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtStaffPassword.Text == staffPassword)
            {
                this.Hide();
                Create_Account f1 = new Create_Account();
                f1.ShowDialog();
                this.Close();
            }
            else

            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome f3 = new Welcome();
            f3.ShowDialog();
            this.Close();
        }
    }


}

