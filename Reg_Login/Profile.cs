using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Profile : Form
    {

        //this is a public variable that stores the phone number so that it can be used in other forms
        public static string phoneNum;


        public Profile()
        {
            //dw about this
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            //this closes edit profile and makes it go back to previous page (book flights)
            this.Hide();
            Book_Flights f7 = new Book_Flights();
            f7.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //This code opens a file dialog to select a picture when they click the picturebox
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //this filter makes sure they can only select image files
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //if the image they select is valid it changes the image of the picturebox to the one selected
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                    //This runs the method to save image (you'll see more about it down)
                    SaveImagePath(ofd.FileName);
                }
            }

        }




        private void btnAddPhoneNum_Click_1(object sender, EventArgs e)
        {
            //this code runs when they click the phone number button

            string userImput;
            // they click the button it opens an input box with below prompt and it stores that input in userimput variable
            userImput = Interaction.InputBox("Please enter your phone number", "Imput box", "");
            if (userImput != null)
            {
               //If they type smth this code will occur. It changes the label to match their input and brings label to front.

                MessageBox.Show("You number is: " + userImput);
                lblPhoneNum.Text = userImput;
                lblPhoneNum.Show();
                lblPhoneNum.BringToFront();

                //stores whatever they type in the phoneNum variable from before
                phoneNum = lblPhoneNum.Text;
            }
        }

        private void btnTermsAndConditions_Click_1(object sender, EventArgs e)
        {
            //if they click the t&c button it will display messagebox with all this

            MessageBox.Show("Booking and Payment: Ensure accurate booking details and full payment at the time of reservation." +
               "Changes and Cancellations: Changes and cancellations may incur fees; review our policy for details. "
             + "Refunds for cancellations will only be processed in accordance with the airline's refund policy, which varies based on ticket class and fare type."
             + "Refunds will be issued to the original payment method, and processing times may vary depending on the payment provider.\r\nCertain discounted or promotional fares may be non-refundable", "Terms and condtions");

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //when form loads this code happens

            
            //it stores the image from imagepath.txt in a variable called savedImagePath
            string savedImagePath = LoadImagePath();
            if (!string.IsNullOrEmpty(savedImagePath) && File.Exists(savedImagePath))
            {
                //if the txt file exists and if it has stuff in it, it locates the image stated in the txt file and makes the picturebox image whatever that is
                pictureBox1.Image = Image.FromFile(savedImagePath);
            }
        }

     

        private void SaveImagePath(string path)
        {
            //this is a custom method that creates a txt file called imagePath.txt in the project folder (to store location of image)

            File.WriteAllText("imagePath.txt", path);
        }

        private string LoadImagePath()
        {
            //custom method that checks if the imagepath.txt exists, if it does it reads whatever is in there and gets the location of that image

            if (File.Exists("imagePath.txt"))
            {
                return File.ReadAllText("imagePath.txt");
            }
            return null;
        }

    }
}
