﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trial_transportation
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
        public string usern;
        public Form1()
        {
            InitializeComponent();
            instance = this;

        }

       string[] username = { "sheona", "athena" };
        string[] password = { "123456", "654321" };
        List<string> user = new List<string>();
        List<string> pass = new List<string>();



        private void Form1_Load(object sender, EventArgs e)
        {

            
            StreamReader s1 = new StreamReader(@"C:\Users\nitol\source\repos\trial_transportation\trial_transportation\TexrFile1.txt");
            string line = "";
            while( (line = s1.ReadLine() ) != null)
            {
                string[ ] components= line.Split(" ".ToCharArray());
               
                user.Add(components[1]);
                pass.Add(components[2]);
            }

            s1.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usern = textBox1.Text;
            if(username.Contains(textBox1.Text) && password.Contains(textBox2.Text) && Array.IndexOf(username, textBox1.Text)== Array.IndexOf(password, textBox2.Text) ) {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else if(user.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(user.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("The username/password is incorrect");
            }
        } 
    }
}
