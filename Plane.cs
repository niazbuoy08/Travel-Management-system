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
            double[] Travelcost = new double[20];
            double[] Seatcost = new double[20];
            double[] Flightcost = new double[20];
            double Total;
            if (To.Text == "Dhaka")
            {
                Travelcost[0] = TravelPrice.Dhaka;
                if (cmbclass.Text == "Business")
                {
                    Seatcost[0] = TravelPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Seatcost[0] = TravelPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = TravelPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = TravelPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = TravelPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Seatcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Chittagong")
            {
                Travelcost[0] = TravelPrice.Chittagong;
                if (cmbclass.Text == "Business")
                {
                    Seatcost[0] = TravelPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Seatcost[0] = TravelPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = TravelPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = TravelPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = TravelPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Seatcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Barisal")
            {
                Travelcost[0] = TravelPrice.Barisal;
                if (cmbclass.Text == "Business")
                {
                    Seatcost[0] = TravelPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Seatcost[0] = TravelPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = TravelPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = TravelPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = TravelPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Seatcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Sylhet")
            {
                Travelcost[0] = TravelPrice.Sylhet;
                if (cmbclass.Text == "Business")
                {
                    Seatcost[0] = TravelPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Seatcost[0] = TravelPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = TravelPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = TravelPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = TravelPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Seatcost[0] + Flightcost[0];
            lblTotal.Text = Total.ToString();
            if (To.Text == "Rajshahi")
            {
                Travelcost[0] = TravelPrice.Rajshahi;
                if (cmbclass.Text == "Business")
                {
                    Seatcost[0] = TravelPrice.Business;
                }
                else if (cmbclass.Text == "Economy")
                {
                    Seatcost[0] = TravelPrice.Economy;
                }
                if (flight.Text == "US Bangla")
                {
                    Flightcost[0] = TravelPrice.USBangla;
                }
                else if (flight.Text == "Bangladesh Biman")
                {
                    Flightcost[0] = TravelPrice.BimanBangladesh;
                }
                else if (flight.Text == "Novo Air")
                {
                    Flightcost[0] = TravelPrice.NovoAir;
                }
            }
            Total = Travelcost[0] + Seatcost[0] + Flightcost[0];
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
    }
}
