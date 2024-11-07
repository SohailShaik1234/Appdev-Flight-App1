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
    public partial class Book_Flights : Form
    {
        string fromLocation = Reg_Login.Search_Flights.fromLocation;
        string toLocation = Reg_Login.Search_Flights.toLocation;
        string depatureDate = Reg_Login.Search_Flights.departureDate;
        string flightClass = Reg_Login.Search_Flights.planeClass;
        public static string chosenCity;
        DateTime departureDateTime = Reg_Login.Search_Flights.departureDateTime;
        string checkClass = "";
        public static int numPassengers;
        double flightPrice = 0;
        public static double totalFlightPrice;


        public Book_Flights()
        {
            InitializeComponent();
            lblCurrentUsername.Text = Reg_Login.Login.CurrentUser.CurrentUserName;
            /*dgFlight.Columns.Add("From", "From Location");
            dgFlight.Columns.Add("To", "To Location");
            dgFlight.Columns.Add("flightClass", "Flight Class");
            dgFlight.Columns.Add("departureDate", "Departure Date");*/
            cmbFrom.Text = fromLocation;
            cmbTo.Text = toLocation;
            cmbClass.Text = flightClass;
            DTDepart.MinDate = DateTime.Today;
            DTDepart.Value = departureDateTime.Date;



            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            lblCurrentUsername.Text = Reg_Login.Login.CurrentUser.CurrentUserName;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Flights sf = new Search_Flights();
            sf.ShowDialog();
            this.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("No Flights:" + '\n' + '\n' + "If the table is empty, it means that there are NO FLIGHTS AVALIABLE, you can use the components at the top of the screen to search for a new flight.");
            MessageBox.Show("Selecting & Confirming Flight Booking:" + '\n' + '\n' + "1. Select a flight of your choosing by clicking on the table." + '\n' + "2. After doing so press 'Continue'.");
            MessageBox.Show("Sorting Flights:" + '\n' + '\n' + "Use can sort flights by using the 'Sort' compnent on the left hand side of your screen");

        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangesThing();

            if (cmbTo.Text == cmbFrom.Text)
            {
                MessageBox.Show("Please select 2 different areas");
            }
        }

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangesThing();
            if (cmbTo.Text == cmbFrom.Text)
            {
                MessageBox.Show("Please select 2 different areas");
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangesThing();
        }

        private void ChangesThing()
        {


            dgFlight.Rows.Clear();


            if (cmbTo.Text != cmbFrom.Text)
            {

                dgFlight.Rows.Add(cmbFrom.Text, cmbTo.Text, cmbClass.Text, DTDepart.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void DTDepart_ValueChanged(object sender, EventArgs e)
        {
            ChangesThing();
        }

        private void radEco_CheckedChange(object sender, EventArgs e)
        {
            ChangesThing();
        }

        private void radBus_CheckedChange(object sender, EventArgs e)
        {
            ChangesThing();
        }

        private void radFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            ChangesThing();
        }

        private void dgFlight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnGo clicked!"); // Debug line

            if (numPassengers > 0)
            {
                checkClass = cmbClass.Text;
                chosenCity = cmbTo.SelectedItem.ToString();
                this.Hide();
                Seat_Selection ss = new Seat_Selection();
                ss.SelectedFlightClass = checkClass;
                ss.ShowDialog();
                this.Close();

            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pro = new Profile();
            pro.ShowDialog();
            this.Close();
        }

        private void Book_Flights_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblFlightClass.Text = cmbClass.Text;
            lblFrom.Text = cmbFrom.Text;
            lblTo.Text = cmbTo.Text;
            lblDepartureDate.Text = DTDepart.Text;
            chosenCity = cmbTo.SelectedItem.ToString();





            if (cmbFrom.Text == "Durban King Shaka International Airport" && cmbTo.Text == "Cape Town International Airport")
            {
                flightPrice = 2160;
                //chosenCity = "Cape Town International Airport";
                lblFlightID.Text = "001";
                lblFromTime.Text = "08:00 AM"; 
                lblToTime.Text = "09:30 AM"; 
                lblTotalTime.Text = "1h 30m"; 

            }
            else if (cmbFrom.Text == "Durban King Shaka International Airport" && cmbTo.Text == "Johannesburg O.R. Tambo International Airport")
            {
                flightPrice = 1440;
                //chosenCity = "Johannesburg O.R. Tambo International Airport";
                lblFlightID.Text = "002";
                lblFromTime.Text = "10:00 AM";
                lblToTime.Text = "11:10 AM";
                lblTotalTime.Text = "1h 10m";
            }
            else if (cmbFrom.Text == "Durban King Shaka International Airport" && cmbTo.Text == "Port Elizabeth Chief Dawid Stuurman International Airport")
            {
                flightPrice = 1800;
                //chosenCity =
                lblFlightID.Text = "003";
                lblFromTime.Text = "12:00 PM";
                lblToTime.Text = "01:15 PM";
                lblTotalTime.Text = "1h 15m";
            }
            else if (cmbFrom.Text == "Cape Town International Airport" && cmbTo.Text == "Durban King Shaka International Airport")
            {
                flightPrice = 2340;
                lblFlightID.Text = "004";
                lblFromTime.Text = "02:00 PM";
                lblToTime.Text = "03:30 PM";
                lblTotalTime.Text = "1h 30m";
            }
            else if (cmbFrom.Text == "Cape Town International Airport" && cmbTo.Text == "Johannesburg O.R. Tambo International Airport")
            {
                flightPrice = 1620;
                lblFlightID.Text = "005";
                lblFromTime.Text = "04:00 PM";
                lblToTime.Text = "05:20 PM";
                lblTotalTime.Text = "1h 20m";
            }
            else if (cmbFrom.Text == "Cape Town International Airport" && cmbTo.Text == "Port Elizabeth Chief Dawid Stuurman International Airport")
            {
                flightPrice = 1980;
                lblFlightID.Text = "006";
                lblFromTime.Text = "06:00 PM";
                lblToTime.Text = "07:10 PM";
                lblTotalTime.Text = "1h 10m";
            }
            else if (cmbFrom.Text == "Johannesburg O.R. Tambo International Airport" && cmbTo.Text == "Durban King Shaka International Airport")
            {
                flightPrice = 1350;
                lblFlightID.Text = "007";
                lblFromTime.Text = "08:30 AM";
                lblToTime.Text = "09:40 AM";
                lblTotalTime.Text = "1h 10m";
            }
            else if (cmbFrom.Text == "Johannesburg O.R. Tambo International Airport" && cmbTo.Text == "Cape Town International Airport")
            {
                flightPrice = 1710;
                lblFlightID.Text = "008";
                lblFromTime.Text = "11:00 AM";
                lblToTime.Text = "12:30 PM";
                lblTotalTime.Text = "1h 30m";
            }
            else if (cmbFrom.Text == "Johannesburg O.R. Tambo International Airport" && cmbTo.Text == "Port Elizabeth Chief Dawid Stuurman International Airport")
            {
                flightPrice = 1530;
                lblFlightID.Text = "009";
                lblFromTime.Text = "01:00 PM";
                lblToTime.Text = "02:10 PM";
                lblTotalTime.Text = "1h 10m";
            }
            else if (cmbFrom.Text == "Port Elizabeth Chief Dawid Stuurman International Airport" && cmbTo.Text == "Durban King Shaka International Airport")
            {
                flightPrice = 1890;
                lblFlightID.Text = "010";
                lblFromTime.Text = "03:00 PM";
                lblToTime.Text = "04:15 PM";
                lblTotalTime.Text = "1h 15m";
            }
            else if (cmbFrom.Text == "Port Elizabeth Chief Dawid Stuurman International Airport" && cmbTo.Text == "Cape Town International Airport")
            {
                flightPrice = 2070;
                lblFlightID.Text = "011";
                lblFromTime.Text = "05:00 PM";
                lblToTime.Text = "05:50 PM";
                lblTotalTime.Text = "50m"; // Example total time
            }
            else if (cmbFrom.Text == "Port Elizabeth Chief Dawid Stuurman International Airport" && cmbTo.Text == "Johannesburg O.R. Tambo International Airport")
            {
                flightPrice = 1620;
                lblFlightID.Text = "012";
                lblFromTime.Text = "07:00 PM";
                lblToTime.Text = "08:10 PM";
                lblTotalTime.Text = "1h 10m";
            }
            else
            {
                flightPrice = 0;
                lblFlightID.Text = "--";
                lblFromTime.Text = "";
                lblToTime.Text = "";
                lblTotalTime.Text = "";
            }


            lblFlightPrice.Text = flightPrice.ToString("C");

            if (NUDAdults.Value == 0 && NUDChildren.Value == 0 && NUDInfants.Value == 0)
            {
                MessageBox.Show("Please enter number of passengers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFlightPrice.Text = 0.ToString("C");
            }
            else if (NUDAdults.Value == 0 && (NUDChildren.Value > 0 || NUDInfants.Value > 0))
            {
                MessageBox.Show("Children/Infants cannot book without Adults", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFlightPrice.Text = 0.ToString("C");
            }
            else if (NUDAdults.Value > 0 && (NUDChildren.Value > 0 || NUDInfants.Value > 0))
            {
                //MessageBox.Show("Booked");
                numPassengers = int.Parse(NUDAdults.Value.ToString()) + int.Parse(NUDChildren.Value.ToString());
            }
            else if (NUDAdults.Value > 0)
            {
                //MessageBox.Show("Booked");
                numPassengers = int.Parse(NUDAdults.Value.ToString()) + int.Parse(NUDChildren.Value.ToString());
            }



            if (cmbClass.SelectedIndex == 1)
            {
                flightPrice = flightPrice + 1000;
            }
            else if (cmbClass.SelectedIndex == 2)
            {
                flightPrice = flightPrice + 2000;
            }
            lblFlightPrice.Text = flightPrice.ToString("C");

            totalFlightPrice = flightPrice * numPassengers;
            lblTotalPrice.Text = totalFlightPrice.ToString("C");



        }

        private void dgFlight_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (numPassengers > 0)
            {
                checkClass = cmbClass.Text;
                chosenCity = cmbTo.SelectedItem.ToString();
                this.Hide();
                Seat_Selection ss = new Seat_Selection();
                ss.SelectedFlightClass = checkClass;
                ss.ShowDialog();
                this.Close();

            }
        }
    }
}
