using Reg_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Reg_Login
{


    public partial class User_Select : Form
    {
      

        private Image adminLight;
        private Image adminDark;
        private Image userLight;
        private Image userDark;
       


        public User_Select()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(63, 103, 130);
            this.DoubleBuffered = true;



            string binPath = AppDomain.CurrentDomain.BaseDirectory;
            string adminLightPath = System.IO.Path.Combine(binPath, "Light.png");
            string adminDarkPath = System.IO.Path.Combine(binPath, "Dark.png");
            string userLightPath = System.IO.Path.Combine(binPath, "userLight.png");
            string userDarkPath = System.IO.Path.Combine(binPath, "userDark.png");

            adminLight = Image.FromFile(adminLightPath);
            adminDark = Image.FromFile(adminDarkPath);
            userLight = Image.FromFile(userLightPath);
            userDark = Image.FromFile(userDarkPath);
            panel1.BackgroundImage = adminDark;
            panel2.BackgroundImage = userDark;

        }

        public static class GlobalSettings
        {
            public static bool isAdmin { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome f3 = new Welcome();
            f3.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            GlobalSettings.isAdmin = true;

            this.Hide();
            Staff_Password f6 = new Staff_Password();
            f6.ShowDialog();
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            GlobalSettings.isAdmin = false;
            this.Hide();
            Create_Account f1 = new Create_Account();
            f1.ShowDialog();
            this.Close();

        }




        private void panel1_MouseHover(object sender, EventArgs e)
        {




        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackgroundImage = adminDark;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackgroundImage = adminLight;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackgroundImage = userLight;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackgroundImage = userDark;
        }

        
    }
}
