using System.Data;
using static System.Windows.Forms.LinkLabel;

namespace Reg_Login
{
    public partial class Admin_Form : Form
    {
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();

        public Admin_Form()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            




            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Ensure only full rows can be selected
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Text = "Admin " + Login.CurrentUser.CurrentUserName;



            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "BookedUsers.txt");
            string[] lines = File.ReadAllLines(relativePath);
            StreamReader reader = new StreamReader(relativePath);
            string lineRec = reader.ReadLine();

            while (lineRec != null)
            {
                lines = lineRec.Split("\t");

                dataGridView4.Rows.Add(lines[0], lines[1]);


                lineRec = reader.ReadLine();


            }

            reader.Close();

        }

        private void btnLoadDetails_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "Users.txt");
            string[] lines = new string[5];
            StreamReader reader = new StreamReader(relativePath);
            string lineRec = reader.ReadLine();

            while (lineRec != null)
            {
                lines = lineRec.Split("\t");

                dataGridView2.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5]);

                int currentRowIndex = dataGridView2.Rows.Count - 1;

                lineRec = reader.ReadLine();

                for (int j = 0; j < lines.Length; j++)
                {
                    if (j == 1) // Assuming the password is in the second column
                    {
                        dataGridView2.Rows[currentRowIndex].Cells[j].Value = new string('*', lines[j].Length);
                    }
                    else if (j == 5) // Mask for the sixth column
                    {
                        dataGridView2.Rows[currentRowIndex].Cells[j].Value = "*";
                    }
                    else
                    {
                        dataGridView2.Rows[currentRowIndex].Cells[j].Value = lines[j].Trim();
                    }
                }



            }

            reader.Close();


           

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dateTimePicker1.Value = DateTime.Now;
            btnReset.Visible = false;
            txtID.Visible = false;
            cmbDept.Visible = false;
            cmbArrive.Visible = false;
            groupBox1.Visible = false;
            dateTimePicker1.Visible = false;
            txtDept.Visible = false;
            txtArrive.Visible = false;
            txtPrice.Visible = false;
            btnAdd.Visible = false;
            txtID.MaxLength = 3;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;

            DataTable dt2 = new DataTable();

            dt2.Columns.Add("FlightID", typeof(string));
            dt2.Columns.Add("Departure", typeof(string));
            dt2.Columns.Add("Arrival", typeof(string));
            dt2.Columns.Add("Price(R)", typeof(double));
            dt2.Columns.Add("Class", typeof(string));
            dt2.Columns.Add("Departure Date", typeof(string));
            dt2.Columns.Add("Departure Time", typeof(string));
            dt2.Columns.Add("Arrival Time", typeof(string));
            dt2.Columns.Add("...", typeof(string));
            dt2.Columns.Add("....", typeof(string));

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "FlightAvaliable(1).txt");
            string[] lines = File.ReadAllLines(relativePath);

            foreach (string line in lines)
            {
                string[] values = line.Split('\t');

                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                dt2.Rows.Add(row);


            }



            dataGridView1.DataSource = dt2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Is Admin", typeof(string));
            table.Columns.Add("ID Number", typeof(string));
            table.Columns.Add("Security Question", typeof(string));*/

            //dataGridView2.DataSource = table;
            /*dataGridView2.Columns["Username"].Width = 150; // Set to your desired width
            dataGridView2.Columns["Email"].Width = 150;
            dataGridView2.Columns["ID Number"].Width = 150;
            dataGridView2.Columns["Is Admin"].Width = 150;
            dataGridView2.Columns["Password"].Width = 150;
            dataGridView2.Columns["Security Question"].Width = 150;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.WindowState = FormWindowState.Maximized;
            /*table2.Columns.Add("Phone", (typeof(string))); // Matches the order of writing in the user form
            table2.Columns.Add("Age", (typeof(string)));
            table2.Columns.Add("Name", (typeof(string)));
            table2.Columns.Add("E-mail", (typeof(string)));
            table2.Columns.Add("Services Received", (typeof(string)));
            table2.Columns.Add("Expectations", (typeof(string)));
            table2.Columns.Add("Satisfactory", (typeof(string)));
            table2.Columns.Add("Recommend Us", (typeof(string)));*/

            //dataGridView3.DataSource = table2;
            //dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter Either Flight ID or Class \n(Frirst/Business/Economy)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt2.Columns.Add("FlightID", typeof(string));
                dt2.Columns.Add("Departure", typeof(string));
                dt2.Columns.Add("Arrival", typeof(string));
                dt2.Columns.Add("Price(R)", typeof(double));
                dt2.Columns.Add("Class", typeof(string));
                dt2.Columns.Add("Departure Date", typeof(string));
                dt2.Columns.Add("Departure Time", typeof(string));
                dt2.Columns.Add("Arrival Time", typeof(string));
                dt2.Columns.Add("...", typeof(string));
                dt2.Columns.Add("....", typeof(string));


                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string relativePath = Path.Combine(baseDirectory, "FlightAvaliable(1).txt");
                string[] lines = File.ReadAllLines(relativePath);

                foreach (string line in lines)
                {
                    string[] values = line.Split('\t');

                    if (txtSearch.Text == values[0] || txtSearch.Text == values[4])
                    {
                        string[] row = new string[values.Length];

                        for (int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j].Trim();

                        }
                        dt2.Rows.Add(row);
                    }



                    dataGridView1.DataSource = dt2;
                    btnReset.Visible = true;


                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("FlightID", typeof(string));
            dt2.Columns.Add("Departure", typeof(string));
            dt2.Columns.Add("Arrival", typeof(string));
            dt2.Columns.Add("Price(R)", typeof(double));
            dt2.Columns.Add("Class", typeof(string));
            dt2.Columns.Add("Departure Date", typeof(string));
            dt2.Columns.Add("Departure Time", typeof(string));
            dt2.Columns.Add("Arrival Time", typeof(string));
            dt2.Columns.Add("...", typeof(string));
            dt2.Columns.Add("....", typeof(string));

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "FlightAvaliable(1).txt");
            string[] lines = File.ReadAllLines(relativePath);

            foreach (string line in lines)
            {
                string[] values = line.Split('\t');

                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                dt2.Rows.Add(row);


            }

            dataGridView1.DataSource = dt2;
            txtSearch.Clear();
            btnReset.Visible = false;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            cmbDept.Visible = true;
            cmbArrive.Visible = true;
            groupBox1.Visible = true;
            dateTimePicker1.Visible = true;
            // btnCID.Visible = true;
            txtDept.Visible = true;
            txtArrive.Visible = true;
            txtPrice.Visible = true;
            btnAdd.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "FlightAvaliable(1).txt");
            string[] lines = File.ReadAllLines(relativePath);
            string clas = "";

            if (radFirst.Checked == true)
            {
                clas = "First";
            }
            if (radBusiness.Checked == true)
            {
                clas = "Business";
            }
            if (radEconomy.Checked == true)
            {
                clas = "Economy";
            }

            if ((radFirst.Checked != true) && (radBusiness.Checked != true) && (radEconomy.Checked != true))
            {
                MessageBox.Show("Select A Seat Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((cmbDept.Text == "") || (cmbArrive.Text == "") || (cmbDept.Text == cmbArrive.Text))
                {
                    MessageBox.Show("Select Two Different Areas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtID.Text == "")
                    {
                        MessageBox.Show("Enter Unique Flight ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtPrice.Text == "")
                        {
                            MessageBox.Show("Enter Price For Flight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (dateTimePicker1.Value < DateTime.Now)
                            {
                                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if ((txtDept.Text == "") || (txtArrive.Text == "") || (txtDept.Text == txtArrive.Text))
                                {
                                    MessageBox.Show("Invalid Time(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    StreamWriter writer = new StreamWriter(relativePath, true);
                                    using (writer)
                                    {
                                        writer.WriteLine(txtID.Text + '\t' + cmbDept.Text + '\t' + cmbArrive.Text + '\t' + txtPrice.Text + '\t' + clas + '\t' + dateTimePicker1.Text + '\t' + txtDept.Text + '\t' + txtArrive.Text + '\t' + "");
                                        MessageBox.Show("Flight Has Been Added", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnAdd.Visible = false;
                                        txtID.Visible = false;
                                        cmbDept.Visible = false;
                                        cmbArrive.Visible = false;
                                        groupBox1.Visible = false;
                                        dateTimePicker1.Visible = false;
                                        txtDept.Visible = false;
                                        txtArrive.Visible = false;
                                        txtPrice.Visible = false;
                                        btnReset.Visible = true;
                                        label9.Visible = false;
                                        label8.Visible = false;
                                        label7.Visible = false;
                                    }
                                }

                            }
                        }
                    }
                }


            }










        }

        private void btnCID_Click(object sender, EventArgs e)
        {





        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)        //how many rows you have selected.
            {
                MessageBox.Show("Please select a flight to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //Pick which row we want out
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Remove the selected row from the DataGridView
            dataGridView1.Rows.Remove(selectedRow);
            MessageBox.Show("Flight has been deleted.", "Delete Success");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReadFeedback_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {






        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

            Email email = new Email();
            email.ShowDialog();

        }

        private void btnReadFeedback_Click_1(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "feedback.txt");
            string[] lines = new string[7];
            StreamReader reader = new StreamReader(relativePath);
            string lineRec = reader.ReadLine();


            // Loop through each line in the file
            while (lineRec != null)
            {
                // Split the line using '\t' as the delimiter (for tab-separated values)
                lines = lineRec.Split('/');

                dataGridView3.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5], lines[6]);



                lineRec = reader.ReadLine();

            }

            reader.Close();
        }
    }
}
