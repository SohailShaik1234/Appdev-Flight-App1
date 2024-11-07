using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Accomodation : Form
    {

        private int budgetValue;
        public static int finalPrice;
        string Selectedcity;
        public Accomodation()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            dataGridView1.RowCount = 8;
            this.WindowState = FormWindowState.Maximized;



            if (Book_Flights.chosenCity == "Durban King Shaka International Airport")
            {
                Selectedcity = "Durban";
            }
            else if (Book_Flights.chosenCity == "Cape Town International Airport")
            {
                Selectedcity = "Cape Town";
            }
            else if (Book_Flights.chosenCity == "Johannesburg O.R. Tambo International Airport")
            {
                Selectedcity = "Johannesburg";
            }
            else if (Book_Flights.chosenCity == "Port Elizabeth Chief Dawid Stuurman International Airport")
            {
                Selectedcity = "Port Elizabeth";
            }

            lblCity.Text = Selectedcity;

        }




        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the number of days.");

            }


            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter your budget.");

            }



            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Hotels.txt");
            StreamReader reader = new StreamReader(relativePath);
            string lineRec = reader.ReadLine();
            string[] lineArray = new string[2];
            string chosenCity = lblCity.Text;
            int numDays = int.Parse(textBox1.Text);
            int budget = budgetValue;

            dataGridView1.Rows.Clear();



            while (lineRec != null)
            {
                lineArray = lineRec.Split("\t");
                string hotel = lineArray[1];
                string city = lineArray[0];



                if (budget >= int.Parse(lineArray[2]))
                {
                    bool hotelExists = false;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var row = dataGridView1.Rows[i];

                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == hotel && row.Cells[2].Value.ToString() == city)
                        {
                            hotelExists = true;
                            break;
                        }
                    }

                    if (hotelExists == false && city == chosenCity)
                    {
                        dataGridView1.Rows.Add(hotel, lineArray[2], city);
                    }



                }



                lineRec = reader.ReadLine();
            }

            if (dataGridView1.Rows.Count < 8)
            {
                dataGridView1.RowCount = 8;
            }

            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                var priceValue = dataGridView1[1, e.RowIndex].Value;

                if (priceValue != null)
                {
                    finalPrice = int.Parse(textBox1.Text) * Convert.ToInt32(priceValue);
                    lblfinalPrice.Text = finalPrice.ToString("C");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out budgetValue))
            {
                textBox2.Text = budgetValue.ToString("C");
            }

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            lblfinalPrice.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            FlightPlan flp = new FlightPlan();
            flp.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seat_Selection ss = new Seat_Selection();
            ss.ShowDialog();
            this.Close();
        }
    }




}
