using static System.Windows.Forms.AxHost;

namespace Reg_Login
{
    public partial class Seat_Selection : Form
    {
        public string SelectedFlightClass { get; set; }
       // public int NumberOfPassengers { get; set; }
        private const string SeatFile = "seats.txt";
        private Button[] seatButtons;
        private List<Button> selectedSeats; // List to store selected seats

        public Seat_Selection()
        {
            InitializeComponent();
            InitializeSeats();
            LoadSeatStatus();
            selectedSeats = new List<Button>();
        }

        private void InitializeSeats()
        {
            seatButtons = new Button[] { seat1, seat2, seat3, seat4, seat5, seat6, seat7, seat8, seat9, seat10 };

            foreach (var seat in seatButtons)
            {
                seat.Click += new EventHandler(Seat_Click);
            }

            button1.Click += new EventHandler(ConfirmBooking_Click);
            btnReset.Click += new EventHandler(btnReset_Click);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button clickedSeat = (Button)sender;

            // Allow only the number of seats specified in txtbox1
            int maxSeats = 0;

            // Attempt to parse the text from txtbox1
            if (int.TryParse(txtbox1.Text, out maxSeats) && maxSeats > 0)
            {
                if (selectedSeats.Count < maxSeats)
                {
                    if (selectedSeats.Contains(clickedSeat))
                    {
                        // Deselect the seat if it's already selected (turn it back to default color)
                        clickedSeat.BackColor = SystemColors.Control;
                        selectedSeats.Remove(clickedSeat); // Remove from the selected list
                    }
                    else
                    {
                        // Select the seat (turn it yellow)
                        clickedSeat.BackColor = System.Drawing.Color.Yellow;
                        selectedSeats.Add(clickedSeat); // Add to the selected list
                    }
                }
                else
                {
                    MessageBox.Show($"You can only select {maxSeats} seats.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of seats.");
            }
        }

        private void ConfirmBooking_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter(SeatFile, true)) // Append to the file
                {
                    foreach (var seat in selectedSeats)
                    {
                        seat.BackColor = System.Drawing.Color.Red; // Change color to red for booked seat
                        seat.Enabled = false; // Disable the seat

                        // Determine seat class
                        string flightClass = "";
                        if (seat.Name == "seat1" || seat.Name == "seat6")
                        {
                            flightClass = "FirstClass";
                        }
                        else if (seat.Name == "seat2" || seat.Name == "seat3" ||
                                 seat.Name == "seat7" || seat.Name == "seat8")
                        {
                            flightClass = "Business Class";
                        }
                        else if (seat.Name == "seat4" || seat.Name == "seat5" ||
                                 seat.Name == "seat9" || seat.Name == "seat10")
                        {
                            flightClass = "Economy";
                        }

                        // Example: Writing flight ID, class, and seat number to the file
                        string flightID = "001"; // Use actual flight ID in your scenario
                        writer.WriteLine(flightID + '\t' + flightClass + '\t' + seat.Name);
                    }
                }


                SaveSeatStatus(); // Save the updated status to the file
                selectedSeats.Clear(); // Clear the selectedSeats list after booking
                MessageBox.Show("Seats booked successfully!"); // Confirmation message
                this.Hide();
                Accomodation acc = new Accomodation();
                acc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No seats selected for booking.");
            }
        }

        private void SaveSeatStatus()
        {
            // Implementation to save seat status (if needed)
        }

        private void LoadSeatStatus()
        {
            if (File.Exists(SeatFile))
            {
                string[] seatData = File.ReadAllLines(SeatFile);
                foreach (var line in seatData)
                {
                    var seatInfo = line.Split('\t');
                    string seatNumber = seatInfo[2]; // Seat number is in the third column

                    foreach (var seat in seatButtons)
                    {
                        if (seat.Name == seatNumber)
                        {
                            seat.BackColor = System.Drawing.Color.Red; // Mark as booked
                            seat.Enabled = false; // Disable the seat
                            break;
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the selected seats only for the current user
            for (int i = 0; i < selectedSeats.Count; i++)
            {
                selectedSeats[i].BackColor = SystemColors.Control; // Reset to default color
            }

            // Clear the selectedSeats list for the current user
            selectedSeats.Clear();

            MessageBox.Show("Your selection has been cleared.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Male/Female Restrooms: Conveniently located at the rear of the aircraft",
                    "Restroom Location",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Men's/Women's Facilities: Located near the entrance of the aircraft for your convenience",
                   "Restroom Location",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enjoy a delicious meal or a refreshing drink at our on-site cafe!", "Cafe Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void seat1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }
        /*public Seat_Selection(string classSelection)
        {
            InitializeComponent();
            selectedClass = classSelection; // Store the selected class for later use
        }*/
        private void Seat_Selection_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblSelectedClass.Text = SelectedFlightClass;
           lbl3.Text =Book_Flights.numPassengers.ToString();
            //string seatSelectedClass = selectedClass;
            // Loop through all seats and disable the red (booked) ones
            foreach (var seat in seatButtons)
            {
                if (seat.BackColor == System.Drawing.Color.Red)
                {
                    seat.Enabled = false; // Already booked, disable
                }
            }
            if (SelectedFlightClass == "First Class")
            {
                // Enable only seat1 and seat6 for First Class


                // Disable all other seats
                seat2.Enabled = false;
                seat3.Enabled = false;
                seat4.Enabled = false;
                seat5.Enabled = false;
                seat7.Enabled = false;
                seat8.Enabled = false;
                seat9.Enabled = false;
                seat10.Enabled = false;
            }
            else if (SelectedFlightClass == "Business")
            {



                seat1.Enabled = false;
                seat4.Enabled = false;
                seat5.Enabled = false;
                seat6.Enabled = false;
                seat9.Enabled = false;
                seat10.Enabled = false;
            }
            else if (SelectedFlightClass == "Economy")
            {

                seat1.Enabled = false;
                seat2.Enabled = false;
                seat3.Enabled = false;
                seat6.Enabled = false;
                seat7.Enabled = false;
                seat8.Enabled = false;
            }
            txtbox1.Text = lbl3.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)    // back btn
        {
            Book_Flights openbookflights = new Book_Flights();
            this.Hide();
            openbookflights.ShowDialog();
            this.Close();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            // Meals go here accomodation as placeholder
            
        }
    }
}