using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reg_Login
{
    public partial class UserFeedback : Form
    {
        public UserFeedback()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;

            lblUsername.Text = Login.CurrentUser.CurrentUserName;
            lblCurrentEmail.Text = Login.CurrentUser.CurrentEmail;

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "feedback.txt");

            string name, email, received = "", recommend = "", improve;
            int age, phone;

            phone = int.Parse(txtphone.Text);
            age = int.Parse(txtage.Text);
            name = lblUsername.Text;
            email = lblCurrentEmail.Text;


            if (radPoor.Checked)
            {
                received = radPoor.Text;
            }
            else if (radGood.Checked)
            {
                received = radGood.Text;
            }
            else if (radExcellent.Checked)
            {
                received = radExcellent.Text;
            }
            
            if (radUnlikely.Checked)
            {
                recommend = radUnlikely.Text;

            }
            else if (radLikely.Checked)
            {
                recommend = radLikely.Text;
            }
            else if (radVeryLikely.Checked)
            {
                recommend = radVeryLikely.Text;
            }

            
            improve = textBox1.Text;

            StreamWriter writer = new StreamWriter(relativePath, append: true);
            using (writer)
            {
                writer.WriteLine(phone + "/" + age + "/" + name + "/" + email + "/" + received + "/" + recommend + "/" + improve);
            }

            MessageBox.Show("Thank you for your feedback, logging you out now");
            this.Hide();
            Welcome wel = new Welcome();
            wel.ShowDialog();
            this.Close();
        }
    }
}
