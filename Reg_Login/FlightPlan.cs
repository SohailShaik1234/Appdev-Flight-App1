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

    public partial class FlightPlan : Form
    {
        public static double planPrice;

        public FlightPlan()
        {
            InitializeComponent();
            radNone.Checked = true;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radNone.Checked)
            {
                planPrice = 0;
            }
            else if (rad250.Checked)
            {
                planPrice = 250;
            }
            else if (rad500.Checked)
            {
                planPrice = 500;
            }
            else if (rad750.Checked)
            {
                planPrice = 750;
            }

            this.Hide();
            Invoice inv = new Invoice();
            inv.ShowDialog();
            this.Close();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accomodation acc = new Accomodation();
            acc.ShowDialog();
            this.Close();
        }
    }
}
