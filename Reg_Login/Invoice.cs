using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Reg_Login
{
    public partial class Invoice : Form
    {
        public static double finalPrice;


        public Invoice()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;

            lblUsername.Text = Login.CurrentUser.CurrentUserName;
            lblEmail.Text = Login.CurrentUser.CurrentEmail;
            lblFlightPrice.Text = Book_Flights.totalFlightPrice.ToString();
            lblAccomodation.Text = Accomodation.finalPrice.ToString();
            lblMeal.Text = FlightPlan.planPrice.ToString();

            finalPrice = double.Parse(Book_Flights.totalFlightPrice.ToString()) + double.Parse(Accomodation.finalPrice.ToString()) + double.Parse(FlightPlan.planPrice.ToString());

            lblTotal.Text = finalPrice.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.ShowDialog();
            this.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.Title = "Save Invoice";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Document doc = new Document(PageSize.A4, 50, 50, 25, 25);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                        doc.Open();

                        // Set font styles
                        iTextSharp.text.Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                        iTextSharp.text.Font regularFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                        // Load the image from resources
                        Bitmap bmp = Properties.Resources.Logo; // Replace 'Logo' with your resource name
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());

                            // Resize and position the image
                            img.ScaleToFit(200, 100); // Adjust the size as needed
                            img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                            doc.Add(img); // Add image to the document
                        }

                        // Header Table
                        PdfPTable headerTable = new PdfPTable(1);
                        headerTable.WidthPercentage = 100;

                        PdfPCell cell1 = new PdfPCell(new Phrase(Login.CurrentUser.CurrentUserName, regularFont));
                        cell1.Border = PdfPCell.NO_BORDER;
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        headerTable.AddCell(cell1);

                        Paragraph invoiceTitle = new Paragraph("Invoice", boldFont);
                        invoiceTitle.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(invoiceTitle);
                        doc.Add(new Paragraph("\n"));

                        PdfPCell cell3 = new PdfPCell(new Phrase(Login.CurrentUser.CurrentEmail, regularFont));
                        cell3.Border = PdfPCell.NO_BORDER;
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        headerTable.AddCell(cell3);

                        PdfPCell emptyCell = new PdfPCell(new Phrase(" "));
                        emptyCell.Border = PdfPCell.NO_BORDER;
                        headerTable.AddCell(emptyCell);

                        doc.Add(headerTable);
                        doc.Add(new Paragraph("\n"));

                        // Line items table
                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 2f, 1f });

                        table.AddCell(new PdfPCell(new Phrase("Total Flight Price:", regularFont)) { Border = PdfPCell.NO_BORDER });
                        table.AddCell(new PdfPCell(new Phrase(Book_Flights.totalFlightPrice.ToString(), regularFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                        table.AddCell(new PdfPCell(new Phrase("Flight Plan:", regularFont)) { Border = PdfPCell.NO_BORDER });
                        table.AddCell(new PdfPCell(new Phrase(FlightPlan.planPrice.ToString(), regularFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                        table.AddCell(new PdfPCell(new Phrase("Accommodation:", regularFont)) { Border = PdfPCell.NO_BORDER });
                        table.AddCell(new PdfPCell(new Phrase(Accomodation.finalPrice.ToString(), regularFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                        // Spacer before total
                        PdfPCell spacerCell = new PdfPCell(new Phrase(" ")) { Border = PdfPCell.NO_BORDER };
                        spacerCell.Colspan = 2;
                        table.AddCell(spacerCell);

                        // Total
                        table.AddCell(new PdfPCell(new Phrase("Total:", boldFont)) { Border = PdfPCell.NO_BORDER });
                        table.AddCell(new PdfPCell(new Phrase(finalPrice.ToString("C"), boldFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                        doc.Add(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (doc.IsOpen()) doc.Close();
                    }

                    MessageBox.Show("PDF Invoice generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightPlan flp = new FlightPlan();
            flp.ShowDialog();
            this.Close();
        }
    }
}
