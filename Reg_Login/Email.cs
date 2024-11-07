using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
          //  pass.MaxLength = 20;
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress(from.Text);
                mm.To.Add(to.Text);
                mm.Subject = subj.Text;
                mm.Body = content.Text;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(from.Text, pass.Text);
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("Email has been sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
