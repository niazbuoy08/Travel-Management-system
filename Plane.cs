using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_transportation
{
    public partial class Plane : Form
    {
        public Plane()
        {
            InitializeComponent();
        }

        private void Plane_Load(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add(seat.Text + "              " + 1400 + "              " + cmbclass.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Price TravelPrice = new Price();
            PClassPrice CPrice = new PClassPrice();
            FlightPrice FPrice = new FlightPrice();
            double[] Travelcost = new double[30];
            double[] Classcost = new double[30];
            double[] Flightcost = new double[30];
            double Total;
            if (To.Text == "Dhaka")
            {
                Travelcost[0] = TravelPrice.Dhaka;
                if (cmbclass.Text == "Business")
                {
                    Classcost[0] = CPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Classcost[0] = CPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = FPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = FPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = FPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Classcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Chittagong")
            {
                Travelcost[0] = TravelPrice.Chittagong;
                if (cmbclass.Text == "Business")
                {
                    Classcost[0] = CPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Classcost[0] = CPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = FPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = FPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = FPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Classcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Barisal")
            {
                Travelcost[0] = TravelPrice.Barisal;
                if (cmbclass.Text == "Business")
                {
                    Classcost[0] = CPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Classcost[0] = CPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = FPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = FPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = FPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Classcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Sylhet")
            {
                Travelcost[0] = TravelPrice.Sylhet;
                if (cmbclass.Text == "Business")
                {
                    Classcost[0] = CPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Classcost[0] = CPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = FPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = FPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = FPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Classcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Rajshahi")
            {
                Travelcost[0] = TravelPrice.Rajshahi;
                if (cmbclass.Text == "Business")
                {
                    Classcost[0] = CPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Classcost[0] = CPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = FPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = FPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = FPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Classcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void From_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void To_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
