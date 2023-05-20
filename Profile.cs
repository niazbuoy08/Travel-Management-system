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
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trial_transportation
{
    public partial class Profile : Form
    {
        
        public Profile()
        {
            InitializeComponent();
            label1.Text = "Welcome" + " " + Form1.instance.usern + "!";
           

         }

       






        private void Profile_Load(object sender, EventArgs e)
        {

            StreamReader pf1 = new StreamReader(@"D:\1-2\SWE4202\project\Travel-Management-system\user.txt");
            string line = "";




            while ((line = pf1.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray());
                string[] username = { "sheona", "athena" };
                string[] password = { "123456", "654321" };
                List<string> user = new List<string>();
                List<string> name = new List<string>();
                List<string> phone = new List<string>();
                List<string> email = new List<string>();
                List<string> nationality = new List<string>();
                List<string> gender = new List<string>();
                List<string> country = new List<string>();
                foreach(String u in user)
                if (line.Contains(Form1.instance.usern))
                {
                        if (components[6] == Form1.instance.usern)
                    label8.Text= components[0];
                        label9.Text=components[1];
                        label10.Text = components[2];
                        label11.Text = components[3];
                        label12.Text = components[4];
                        label13.Text = components[5];
                }
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
