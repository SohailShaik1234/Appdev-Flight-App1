using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class ForgotPass : Form
    {
        // private const string DefaultSecurityAnswer = "answer123";
        public ForgotPass()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim(); //This .trim() removes blank white speaces the user may enter
            string securityAnswer = txtSecurityAnswer.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string pattern = @"[!@#$%]";

            //ISnullorwhitespeaces: checks whether a given string is blank or only have tabs spaces filled in
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(securityAnswer) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            if (newPassword.Length < 8 || !Regex.IsMatch(newPassword, pattern) || !newPassword.Any(char.IsUpper))
            {
                MessageBox.Show("New password must be at least 8 characters long, contain an uppercase letter, and a special character.", "Error");
                return;
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Users.txt");
            string[] lines = File.ReadAllLines(relativePath);
            bool userFound = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('\t');

                if (parts.Length > 2 && string.Equals(parts[2].Trim(), email, StringComparison.OrdinalIgnoreCase) && securityAnswer == parts[5])  // Default answer
                {
                    parts[1] = newPassword;  // Update password
                    lines[i] = parts[0] + "\t" + parts[1] + "\t" + parts[2] + "\t" + parts[3] + "\t" + parts[4] + "\t" + parts[5];//string.Join("\t", parts);  // Rebuild the line
                    userFound = true;
                    break;
                }
            }

            if (userFound)
            {
                File.WriteAllLines(relativePath, lines);  // Save changes

                MessageBox.Show("Password successfully reset!", "Success");
                Login lg = new Login();
                this.Hide();
                lg.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or security answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();

        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }


}
