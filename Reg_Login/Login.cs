using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            ActiveControl = button1;
        }


        public static class CurrentUser //stores info of current user
        {
            public static string CurrentUserName { get; set; }
            public static string CurrentEmail { get; set; }
            public static bool IsAdmin { get; set; }


        }


        private void button1_Click(object sender, EventArgs e)
        {

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Users.txt");
            StreamReader reader = new StreamReader(relativePath);
            string lineRec = reader.ReadLine();
            string[] lineArray = new string[2];
            string userName = "";
            string Password = "";
            string Email = "";
            bool accountExists = false;

            while (lineRec != null)
            {

                lineArray = lineRec.Split("\t");
                userName = lineArray[0];
                Password = lineArray[1];
                Email = lineArray[2];
                bool isAdmin = bool.Parse(lineArray[3]);



                if (txtUser.Text == userName || txtUser.Text == Email)
                {
                    accountExists = true;
                    if (txtPass.Text == Password)
                    {
                        CurrentUser.CurrentUserName = userName;
                        CurrentUser.CurrentEmail = Email;
                        CurrentUser.IsAdmin = isAdmin;

                        if (Reg_Login.User_Select.GlobalSettings.isAdmin == false && isAdmin == false)
                        {
                            MessageBox.Show("Welcome!");
                            this.Hide();
                            Search_Flights f4 = new Search_Flights();
                            f4.ShowDialog();
                            this.Close();
                            reader.Close();
                        }
                        else if (Reg_Login.User_Select.GlobalSettings.isAdmin == false && isAdmin == true)
                        {
                            MessageBox.Show("This is an Admin account. Log in from the Admin side", "Error");
                        }
                        else if (Reg_Login.User_Select.GlobalSettings.isAdmin == true)
                        {
                            this.Hide();
                            Admin_Form af = new Admin_Form();
                            af.ShowDialog();
                            this.Close();
                            reader.Close();
                        }





                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect");
                    }

                    break;
                }


                lineRec = reader.ReadLine();
            }

            if (txtUser.Text != userName && txtUser.Text != Email)
            {
                MessageBox.Show("Account does not exist");
                accountExists = false;
            }







            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome f3 = new Welcome();
            f3.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPass Fp = new ForgotPass();
            Fp.ShowDialog();
            this.Close();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnView.BringToFront();
                txtPass.PasswordChar = '*';

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_Account f1 = new Create_Account();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
