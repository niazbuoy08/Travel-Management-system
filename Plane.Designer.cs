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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plane));
            this.Total = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cmb_flight = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_seat = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.cmbfrom = new System.Windows.Forms.ComboBox();
            this.contact_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.travelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.total_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.Navy;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(885, 446);
            this.Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(84, 34);
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
            this.button1.Location = new System.Drawing.Point(903, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Proceed to Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(885, 139);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(274, 292);
            this.listBox.TabIndex = 50;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // cmb_flight
            // 
            this.cmb_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_flight.FormattingEnabled = true;
            this.cmb_flight.Items.AddRange(new object[] {
            "US Bangla",
            "Biman Bangaldesh",
            "Novo Air"});
            this.cmb_flight.Location = new System.Drawing.Point(560, 263);
            this.cmb_flight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_flight.Name = "cmb_flight";
            this.cmb_flight.Size = new System.Drawing.Size(269, 28);
            this.cmb_flight.TabIndex = 49;
            this.cmb_flight.SelectedIndexChanged += new System.EventHandler(this.flight_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(471, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Flight:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmb_seat
            // 
            this.cmb_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seat.FormattingEnabled = true;
            this.cmb_seat.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3",
            "D1",
            "D2",
            "D3"});
            this.cmb_seat.Location = new System.Drawing.Point(560, 309);
            this.cmb_seat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_seat.Name = "cmb_seat";
            this.cmb_seat.Size = new System.Drawing.Size(269, 28);
            this.cmb_seat.TabIndex = 46;
            this.cmb_seat.SelectedIndexChanged += new System.EventHandler(this.seat_SelectedIndexChanged);
            // 
            // cmb_class
            // 
            this.cmb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Items.AddRange(new object[] {
            "Business ",
            "Economy"});
            this.cmb_class.Location = new System.Drawing.Point(560, 225);
            this.cmb_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(269, 28);
            this.cmb_class.TabIndex = 45;
            this.cmb_class.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // cmbto
            // 
            this.cmbto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.cmbto.Location = new System.Drawing.Point(156, 423);
            this.cmbto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(260, 28);
            this.cmbto.TabIndex = 44;
            this.cmbto.SelectedIndexChanged += new System.EventHandler(this.To_SelectedIndexChanged);
            // 
            // cmbfrom
            // 
            this.cmbfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfrom.FormattingEnabled = true;
            this.cmbfrom.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Barisal",
            "Sylhet",
            "Rajshahi"});
            this.cmbfrom.Location = new System.Drawing.Point(156, 374);
            this.cmbfrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbfrom.Name = "cmbfrom";
            this.cmbfrom.Size = new System.Drawing.Size(260, 28);
            this.cmbfrom.TabIndex = 43;
            this.cmbfrom.SelectedIndexChanged += new System.EventHandler(this.From_SelectedIndexChanged);
            // 
            // contact_text
            // 
            this.contact_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_text.Location = new System.Drawing.Point(156, 321);
            this.contact_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contact_text.Name = "contact_text";
            this.contact_text.Size = new System.Drawing.Size(260, 26);
            this.contact_text.TabIndex = 42;
            this.contact_text.TextChanged += new System.EventHandler(this.contact_TextChanged);
            // 
            // email_text
            // 
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(156, 266);
            this.email_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(260, 26);
            this.email_text.TabIndex = 41;
            this.email_text.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(156, 224);
            this.name_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(260, 26);
            this.name_text.TabIndex = 40;
            this.name_text.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(471, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
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
            this.label9.Location = new System.Drawing.Point(471, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
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
            this.label8.Location = new System.Drawing.Point(471, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
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
            this.label7.Location = new System.Drawing.Point(42, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
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
            this.label6.Location = new System.Drawing.Point(42, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
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
            this.label5.Location = new System.Drawing.Point(42, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
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
            this.label.Location = new System.Drawing.Point(42, 267);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 25);
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
            this.label4.Location = new System.Drawing.Point(42, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
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
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Airplane";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // travelDateTimePicker
            // 
            this.travelDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelDateTimePicker.Location = new System.Drawing.Point(560, 376);
            this.travelDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.travelDateTimePicker.Name = "travelDateTimePicker";
            this.travelDateTimePicker.Size = new System.Drawing.Size(269, 24);
            this.travelDateTimePicker.TabIndex = 54;
            this.travelDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(80, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 55;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(560, 450);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 30);
            this.button3.TabIndex = 56;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(731, 446);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 34);
            this.button4.TabIndex = 57;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(975, 450);
            this.total_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total_text.Name = "total_text";
            this.total_text.Size = new System.Drawing.Size(158, 26);
            this.total_text.TabIndex = 58;
            this.total_text.TextChanged += new System.EventHandler(this.total_text_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 52);
            this.label1.TabIndex = 60;
            this.label1.Text = "Go EaSy";
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trial_transportation.Properties.Resources.newimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.travelDateTimePicker);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.cmb_flight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_seat);
            this.Controls.Add(this.cmb_class);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.cmbfrom);
            this.Controls.Add(this.contact_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Plane";
            this.Text = "Plane";
            this.Load += new System.EventHandler(this.Plane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox cmb_flight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_seat;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.ComboBox cmbto;
        private System.Windows.Forms.ComboBox cmbfrom;
        private System.Windows.Forms.TextBox contact_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker travelDateTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}