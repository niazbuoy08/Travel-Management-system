﻿namespace trial_transportation
{
    partial class Plane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.flight = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.seat = new System.Windows.Forms.ComboBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.To = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.ComboBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1111, 557);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(164, 29);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.Navy;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(996, 557);
            this.Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(94, 32);
            this.Total.TabIndex = 52;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1032, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 28);
            this.button1.TabIndex = 51;
            this.button1.Text = "Proceed to Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(996, 174);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(308, 364);
            this.listBox.TabIndex = 50;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // flight
            // 
            this.flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight.FormattingEnabled = true;
            this.flight.Items.AddRange(new object[] {
            "US Bangla",
            "Biman Bangaldesh",
            "Novo Air"});
            this.flight.Location = new System.Drawing.Point(630, 329);
            this.flight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flight.Name = "flight";
            this.flight.Size = new System.Drawing.Size(302, 33);
            this.flight.TabIndex = 49;
            this.flight.SelectedIndexChanged += new System.EventHandler(this.flight_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(530, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 29);
            this.label11.TabIndex = 48;
            this.label11.Text = "Flight:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // seat
            // 
            this.seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat.FormattingEnabled = true;
            this.seat.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "C1",
            "C2",
            "C3",
            "C4",
            "D1",
            "D2",
            "D3",
            "D4",
            "E1",
            "E2",
            "E3",
            "E4",
            "F1",
            "F2",
            "F3",
            "F4"});
            this.seat.Location = new System.Drawing.Point(630, 386);
            this.seat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(302, 33);
            this.seat.TabIndex = 46;
            this.seat.SelectedIndexChanged += new System.EventHandler(this.seat_SelectedIndexChanged);
            // 
            // cmbclass
            // 
            this.cmbclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "Business ",
            "Economy"});
            this.cmbclass.Location = new System.Drawing.Point(630, 281);
            this.cmbclass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(302, 33);
            this.cmbclass.TabIndex = 45;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.FormattingEnabled = true;
            this.To.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.To.Location = new System.Drawing.Point(175, 529);
            this.To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(292, 33);
            this.To.TabIndex = 44;
            this.To.SelectedIndexChanged += new System.EventHandler(this.To_SelectedIndexChanged);
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.FormattingEnabled = true;
            this.From.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.From.Location = new System.Drawing.Point(175, 468);
            this.From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(292, 33);
            this.From.TabIndex = 43;
            this.From.SelectedIndexChanged += new System.EventHandler(this.From_SelectedIndexChanged);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(175, 401);
            this.contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(292, 30);
            this.contact.TabIndex = 42;
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(175, 333);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(292, 30);
            this.email.TabIndex = 41;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(175, 280);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(292, 30);
            this.name.TabIndex = 40;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(530, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Date:";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(530, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Seat:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(530, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Class:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "To:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "From:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Contact:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Navy;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(55, 333);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 29);
            this.label.TabIndex = 33;
            this.label.Text = "Email:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 46);
            this.label2.TabIndex = 31;
            this.label2.Text = "Airplane";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(575, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Go EaSy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(630, 470);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 28);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(90, 615);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 44);
            this.button2.TabIndex = 55;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trial_transportation.Properties.Resources.newimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1525, 820);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.flight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.seat);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Plane";
            this.Text = "Plane";
            this.Load += new System.EventHandler(this.Plane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox flight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox seat;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.ComboBox To;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}