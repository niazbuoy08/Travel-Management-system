using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static trial_transportation.Booking;

namespace trial_transportation
{




    public partial class bus : Form
    {



        private PrintDocument printDocument;



        private List<Booking> bookings;




        public bus()
        {
            InitializeComponent();
            bookings = new List<Booking>();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            
        }

        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
          
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string From = comboBox1.SelectedItem.ToString();
            string To = comboBox2.SelectedItem.ToString();
            DateTime travelDate = travelDateTimePicker.Value.Date;
      
      string print= "\t" + "\t" + "TICKET RECEIPT" +"\n" + "Name: "+ name+ " " + "\n" + "Email: " + email + "\n" + "Phone: " + phone + "\n" + "From: " +  From + "\n" + "To: " + To+ "\n"  + "Date: " + travelDate;
            Font font = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString( print, font, Brushes.Black, new PointF(50, 50));
           
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    printDocument.Print();
                }

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }





        private void bus_Load(object sender, EventArgs e)
        {

        }




        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {




            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string From = comboBox1.SelectedItem.ToString();
            string To = comboBox2.SelectedItem.ToString();
            DateTime travelDate = travelDateTimePicker.Value.Date;
            int seatNumber = (int)seatNumericUpDown.Value;





            foreach (Booking booking in bookings)
            {
                if (booking.TravelDate == travelDate && booking.SeatNumber == seatNumber)
                {
                    MessageBox.Show("This seat has already been booked for the selected date. Please choose another seat or date.");
                    return;
                }
            }




            Booking newBooking = new Booking(name, email, phone, From, To, travelDate, seatNumber);
            bookings.Add(newBooking);





            string bookingDetails = $"{newBooking.Name}, {newBooking.Email}, {newBooking.Phone}, {newBooking.From}, {newBooking.To}, {newBooking.TravelDate.ToShortDateString()}, Seat {newBooking.SeatNumber}";
            listBox_Customer.Items.Add(bookingDetails);





            nameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            travelDateTimePicker.Value = DateTime.Today;
            seatNumericUpDown.Value = 1;
        }





        private void button_remove_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void listBox_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}
