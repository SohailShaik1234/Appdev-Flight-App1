using System.Text;
using System.Windows.Forms;

namespace Reg_Login
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            label11.Text = Invoice.finalPrice.ToString("C");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (text.Length == 16)
            {
                StringBuilder formatText = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    formatText.Append(text[i]);
                    if ((i + 1) % 4 == 0 && i < text.Length - 1)
                    {
                        formatText.Append(" ");
                    }
                }
                textBox1.Text = formatText.ToString();
            }



            label1.Text = String.Format(textBox1.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            


            textBox1.MaxLength = 16;
            textBox2.MaxLength = 3;
            textBox1.TextChanged += this.textBox1_TextChanged;
            textBox2.TextChanged += this.textBox2_TextChanged;
            textBox3.TextChanged += this.textBox3_TextChanged;
            dateTimePicker1.Value = DateTime.Now;
            label8.Text = dateTimePicker1.Value.ToString("dd/MM/yy");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label2.Text = String.Format(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = String.Format(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.TextLength < 16)
                {
                    MessageBox.Show("Card Number Must Be 16 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter CVV Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.TextLength < 3)
                {
                    MessageBox.Show("CVV Code Must Be 3 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Name of Card Holder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("This Card Is Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((textBox1.TextLength > 15) && (textBox2.TextLength > 2) && (textBox3.Text != "") && (dateTimePicker1.Value > DateTime.Now))
            {
                MessageBox.Show("Transaction Has Been Successful", "Payment Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string currentUser = Login.CurrentUser.CurrentUserName;
                string currentEmail = Login.CurrentUser.CurrentEmail;

                File.AppendAllText("BookedUsers.txt", currentUser + "\t" + currentEmail + Environment.NewLine);



                this.Hide();
                UserFeedback Ufe = new UserFeedback();
                Ufe.ShowDialog();
                this.Close();
            }





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = dateTimePicker1.Value.ToString("dd/MM/yy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice inv = new Invoice();
            inv.ShowDialog();
            this.Close();
        }
    }
}
