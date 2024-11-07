using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class adminFeedback : Form
    {
        DataTable table = new DataTable();
        
        public adminFeedback()
        {
            InitializeComponent();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(baseDirectory, "feedback.txt");

            // Read all lines from the text file
            string[] lines = File.ReadAllLines(relativePath);

            // Loop through each line in the file
            for (int i = 0; i < lines.Length; i++)
            {
                // Split the line using '\t' as the delimiter (for tab-separated values)
                string[] values = lines[i].Split('/');

                // Ensure the values length matches the table column count
                if (values.Length == table.Columns.Count)
                {
                    // Add the values to the table as a new row
                    table.Rows.Add(values);
                }
                else
                {
                    MessageBox.Show("Error, please try again","Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                }


            }
        }

        private void adminFeedbackview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            table.Columns.Add("Phone", (typeof(string))); // Matches the order of writing in the user form
            table.Columns.Add("Age", (typeof(string)));
            table.Columns.Add("Name", (typeof(string)));
            table.Columns.Add("E-mail", (typeof(string)));
            table.Columns.Add("Services Received", (typeof(string)));
            table.Columns.Add("Expectations", (typeof(string)));
            table.Columns.Add("Satisfactory", (typeof(string)));
            table.Columns.Add("Recommend Us", (typeof(string)));

            dataGridView3.DataSource = table;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
