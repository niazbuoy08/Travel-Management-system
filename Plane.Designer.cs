namespace trial_transportation
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
            this.lblTotal.Location = new System.Drawing.Point(945, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 23);
            this.lblTotal.TabIndex = 53;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(863, 458);
            this.Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(69, 26);
            this.Total.TabIndex = 52;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(863, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 22);
            this.button1.TabIndex = 51;
            this.button1.Text = "Proceed to Payment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(863, 158);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(216, 292);
            this.listBox.TabIndex = 50;
            // 
            // flight
            // 
            this.flight.FormattingEnabled = true;
            this.flight.Items.AddRange(new object[] {
            "US Bangla",
            "Biman Bangaldesh",
            "Novo Air"});
            this.flight.Location = new System.Drawing.Point(601, 263);
            this.flight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flight.Name = "flight";
            this.flight.Size = new System.Drawing.Size(168, 24);
            this.flight.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Flight:";
            // 
            // seat
            // 
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
            this.seat.Location = new System.Drawing.Point(601, 322);
            this.seat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(168, 24);
            this.seat.TabIndex = 46;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "Business ",
            "Economy"});
            this.cmbclass.Location = new System.Drawing.Point(601, 213);
            this.cmbclass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(168, 24);
            this.cmbclass.TabIndex = 45;
            // 
            // To
            // 
            this.To.FormattingEnabled = true;
            this.To.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.To.Location = new System.Drawing.Point(180, 434);
            this.To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(260, 24);
            this.To.TabIndex = 44;
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.From.Location = new System.Drawing.Point(180, 381);
            this.From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(260, 24);
            this.From.TabIndex = 43;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(180, 326);
            this.contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(260, 22);
            this.contact.TabIndex = 42;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(180, 266);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(260, 22);
            this.email.TabIndex = 41;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(180, 214);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(260, 22);
            this.name.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Date:";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Seat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Class:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Contact:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(72, 265);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 25);
            this.label.TabIndex = 33;
            this.label.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Airplane";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Go EaSy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 378);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 26);
            this.button2.TabIndex = 55;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 562);
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