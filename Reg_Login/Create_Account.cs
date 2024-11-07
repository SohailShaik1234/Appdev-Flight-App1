using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Reg_Login
{
    public partial class Create_Account : Form
    {

        

        public Create_Account()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            ActiveControl = button1;

            

        }

        


        private void button1_Click(object sender, EventArgs e)
        {

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Users.txt");
            string[] allLines = File.ReadAllLines(relativePath);
            string Pattern = @"[!@#$%^&*()_+={}\[\]:;\""'<>?,./`~]";
            Regex hasNum = new Regex(@"\d");
            string passUpper = txtCreatePass.Text;
            bool containsSpecialChar = Regex.IsMatch(txtCreatePass.Text, Pattern);
            bool containsUpperCase = passUpper.Any(char.IsUpper);
            User_Select f5 = new User_Select();

            bool userExists = false;

            foreach (string line in allLines)
            {
                string[] parts = line.Split("\t");
                if (parts[0].Length > 0 && parts[0] == txtCreateUser.Text || parts[2].Length > 0 && parts[2] == txtCreateMail.Text)
                {
                    userExists = true;
                    break;
                }


            }


            if (userExists == true)
            {
                MessageBox.Show("User with username or email already exists");
            }
            else
            {
                List<string> errorMessages = new List<string>();

                if (txtCreateUser.Text == "" && txtCreatePass.Text == "" && txtCreateMail.Text == "" && txtID.Text == "" && txtPasswordConfirm.Text == "")
                {
                    errorMessages.Add("Please enter something");

                }
                if (txtCreateUser.Text == "")
                {
                    errorMessages.Add("Enter Username please");

                }
                if (txtCreatePass.Text == "")
                {
                    errorMessages.Add("Enter Password please");

                }
                if (txtCreateMail.Text == "")
                {
                    errorMessages.Add("Enter Email please");

                }
                if (txtID.Text == "")
                {
                    errorMessages.Add("Enter ID Number please");

                }
                if (txtID.Text.Length < 13 && txtID.Text.Length > 0)
                {
                    errorMessages.Add("ID Must be 13 characters");
                }
                if (!txtCreateMail.Text.Contains("@") && txtCreateMail.Text != "")
                {
                    errorMessages.Add("Please enter valid email");
                }
                if (txtCreatePass.Text != txtPasswordConfirm.Text && txtPasswordConfirm.Text != "")
                {
                    errorMessages.Add("Passwords do not match");
                }
                else if (txtCreatePass.Text != "" && txtPasswordConfirm.Text == "" && containsSpecialChar == true)
                {
                    errorMessages.Add("Please confirm password");
                }
                if (containsSpecialChar == false && txtCreatePass.Text != "")
                {
                    errorMessages.Add("Password needs special character");
                }
                if (txtCreatePass.Text.Length < 8 && txtCreatePass.Text != "")
                {
                    errorMessages.Add("Password is too short");
                }
                if (!containsUpperCase && txtCreatePass.Text != "")
                {
                    errorMessages.Add("Password needs Upper Case letter");
                }
                if (!hasNum.IsMatch(txtCreatePass.Text) && txtCreatePass.Text != "")
                {
                    errorMessages.Add("Password needs number");
                }
                if (txtSecQuestion.Text == "")
                {
                    errorMessages.Add("Please answer security question");
                }
                if (chkTnC.Checked != true)
                {
                    errorMessages.Add("Please accept terms and conditions");
                }


                if (errorMessages.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", errorMessages), "Error");
                }
                else
                {
                    StreamWriter writer = new StreamWriter(relativePath, append: true);
                    writer.Write(txtCreateUser.Text + "\t" + txtCreatePass.Text + "\t" + txtCreateMail.Text + "\t" + Reg_Login.User_Select.GlobalSettings.isAdmin + "\t" + txtID.Text + "\t" + txtSecQuestion.Text + "\n");


                    writer.Close();



                    MessageBox.Show("Account Created");
                    this.Hide();
                    Login f2 = new Login();
                    f2.ShowDialog();
                    this.Close();

                }




            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome f3 = new Welcome();
            f3.ShowDialog();
            this.Close();
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }



        }



        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtCreatePass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtCreatePass.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtCreatePass.PasswordChar == '\0')
            {
                btnView.BringToFront();
                txtCreatePass.PasswordChar = '*';

            }
        }

        private void btnConfirmView_Click(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.PasswordChar == '*')
            {
                btnConfirmHide.BringToFront();
                txtPasswordConfirm.PasswordChar = '\0';
            }
        }

        private void btnConfirmHide_Click(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.PasswordChar == '\0')
            {
                btnConfirmView.BringToFront();
                txtPasswordConfirm.PasswordChar = '*';

            }
        }

        private void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreatePass_TextChanged(object sender, EventArgs e)
        {
            txtPasswordConfirm.Enabled = !string.IsNullOrWhiteSpace(txtCreatePass.Text);

            if (string.IsNullOrWhiteSpace(txtCreatePass.Text))
            {
                txtPasswordConfirm.Clear();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("By creating an account, you agree to provide accurate information, keep your account secure, and use our services responsibly and lawfully. You are responsible for maintaining the confidentiality of your password and agree to our Privacy Policy on how we handle your data. We may modify these terms or suspend your account for any violations. By continuing, you accept these Terms and Conditions, which are governed by [Your Jurisdiction]'s laws.");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is a security Question");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }
    }
}
