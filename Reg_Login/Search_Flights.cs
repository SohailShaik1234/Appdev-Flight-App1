using System.Data;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Search_Flights : Form
    {
        public static string sClass;
        public static string fromLocation;
        public static string toLocation;
        public static string departureDate;
        public static DateTime departureDateTime = DateTime.Now;
        public static string planeClass;

        public Search_Flights()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            label5.Text = "Welcome" + " " + Reg_Login.Login.CurrentUser.CurrentUserName;

        }





        DataTable dt2 = new DataTable();



        private void btnSearch_Click(object sender, EventArgs e)
        {

            Search_Flights frm4 = new Search_Flights();
            Book_Flights frm2 = new Book_Flights();

            //string sClass = "";



            if (radioButton1.Checked)
            {
                sClass = "Economy";
            }
            else if (radioButton2.Checked)
            {
                sClass = "Business";
            }
            else if (radioButton3.Checked)
            {
                sClass = "First";
            }





            if ((comboBox1.Text == comboBox2.Text))
            {
                MessageBox.Show("Select Two Different Areas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton3.Checked == false))
            {
                MessageBox.Show("Pick a Seating Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text != comboBox2.Text)
            {

                fromLocation = comboBox1.Text;
                toLocation = comboBox2.Text;
                departureDate = dateTimePicker1.Text;
                departureDateTime = dateTimePicker1.Value.Date;


                if (radioButton1.Checked)
                {
                    planeClass = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    planeClass = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    planeClass = radioButton3.Text;
                }


                this.Hide();
                Book_Flights f7 = new Book_Flights();
                f7.ShowDialog();
                this.Close();


            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;

            // Optional: set the default value to today
            dateTimePicker1.Value = DateTime.Now;
            this.WindowState = FormWindowState.Maximized;
            dateTimePicker1.Value = DateTime.Now;
            //dateTimePicker2.Value = DateTime.Now.AddDays(2)   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice inv = new Invoice();
            inv.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }
    }
}
