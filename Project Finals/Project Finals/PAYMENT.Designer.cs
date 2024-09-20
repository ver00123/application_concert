namespace Project_Finals
{
    partial class PAYMENT
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

        private Button GetButton3()
        {
            return button3;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            SEATS = new DataGridViewTextBoxColumn();
            SCHEDULES = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            QUANTITY1 = new DataGridViewTextBoxColumn();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button5 = new Button();
            panel1 = new Panel();
            label24 = new Label();
            panel2 = new Panel();
            amount = new Label();
            label20 = new Label();
            schedule = new Label();
            seat_name = new Label();
            pictureBox1 = new PictureBox();
            label22 = new Label();
            label23 = new Label();
            concert_name = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button4 = new Button();
            button9 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(101, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(101, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "PAYMENT";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(147, 418);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 5;
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 455);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "TOTAL :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 421);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "PAYMENT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "NAME :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 91);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 9;
            label5.Text = "MOBILE # :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(148, 451);
            label6.Name = "label6";
            label6.Size = new Size(23, 25);
            label6.TabIndex = 13;
            label6.Text = "0";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 483);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 14;
            label7.Text = "CHANGE :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(148, 478);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 15;
            label8.Text = "0";
            label8.Click += label8_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(325, 418);
            button3.Name = "button3";
            button3.Size = new Size(58, 27);
            button3.TabIndex = 17;
            button3.Text = "PAY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(162, 378);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 18;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SEATS, SCHEDULES, PRICE, QUANTITY });
            dataGridView1.Location = new Point(10, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(425, 236);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SEATS
            // 
            SEATS.HeaderText = "SEATS";
            SEATS.MinimumWidth = 6;
            SEATS.Name = "SEATS";
            SEATS.Width = 125;
            // 
            // SCHEDULES
            // 
            SCHEDULES.HeaderText = "SCHEDULES";
            SCHEDULES.MinimumWidth = 6;
            SCHEDULES.Name = "SCHEDULES";
            SCHEDULES.Width = 125;
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.MinimumWidth = 6;
            PRICE.Name = "PRICE";
            PRICE.Width = 125;
            // 
            // QUANTITY
            // 
            QUANTITY.HeaderText = "QUANTITY";
            QUANTITY.MinimumWidth = 6;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlDarkDark;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 41);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 21;
            label9.Text = "NAME :";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 79);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 22;
            label10.Text = "MOBILE # :";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(158, 0);
            label11.Name = "label11";
            label11.Size = new Size(122, 37);
            label11.TabIndex = 23;
            label11.Text = "RECIEPT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlDarkDark;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(2, 143);
            label12.Name = "label12";
            label12.Size = new Size(441, 20);
            label12.TabIndex = 24;
            label12.Text = "------------------------------------------------------------------------";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, QUANTITY1 });
            dataGridView2.Location = new Point(5, 166);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(435, 270);
            dataGridView2.TabIndex = 25;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "SEATS";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "SCHEDULES";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "PRICE";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // QUANTITY1
            // 
            QUANTITY1.HeaderText = "QUANTITY";
            QUANTITY1.MinimumWidth = 6;
            QUANTITY1.Name = "QUANTITY1";
            QUANTITY1.Width = 125;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlDarkDark;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 471);
            label13.Name = "label13";
            label13.Size = new Size(78, 25);
            label13.TabIndex = 26;
            label13.Text = "TOTAL :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlDarkDark;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 502);
            label14.Name = "label14";
            label14.Size = new Size(101, 25);
            label14.TabIndex = 27;
            label14.Text = "CHANGE :";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ControlDarkDark;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(314, 38);
            label15.Name = "label15";
            label15.Size = new Size(100, 30);
            label15.TabIndex = 28;
            label15.Text = "TICKETS ";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlDarkDark;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 443);
            label16.Name = "label16";
            label16.Size = new Size(111, 25);
            label16.TabIndex = 29;
            label16.Text = "PAYMENT :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ControlDarkDark;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(122, 467);
            label17.Name = "label17";
            label17.Size = new Size(23, 25);
            label17.TabIndex = 30;
            label17.Text = "0";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ControlDarkDark;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(132, 502);
            label18.Name = "label18";
            label18.Size = new Size(23, 25);
            label18.TabIndex = 31;
            label18.Text = "0";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.ControlDarkDark;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(144, 443);
            label19.Name = "label19";
            label19.Size = new Size(23, 25);
            label19.TabIndex = 32;
            label19.Text = "0";
            label19.Click += label19_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(243, 378);
            button5.Name = "button5";
            button5.Size = new Size(63, 23);
            button5.TabIndex = 34;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(443, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 548);
            panel1.TabIndex = 36;
            panel1.Paint += panel1_Paint;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(23, 113);
            label24.Name = "label24";
            label24.Size = new Size(102, 30);
            label24.TabIndex = 40;
            label24.Text = "Concert :";
            label24.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(amount);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(schedule);
            panel2.Controls.Add(seat_name);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(concert_name);
            panel2.Location = new Point(14, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 314);
            panel2.TabIndex = 37;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.BackColor = SystemColors.ControlDarkDark;
            amount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount.Location = new Point(157, 201);
            amount.Name = "amount";
            amount.Size = new Size(23, 25);
            amount.TabIndex = 30;
            amount.Text = "0";
            amount.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.ControlDarkDark;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(22, 201);
            label20.Name = "label20";
            label20.Size = new Size(107, 25);
            label20.TabIndex = 29;
            label20.Text = "AMOUNT :";
            label20.Visible = false;
            // 
            // schedule
            // 
            schedule.AutoSize = true;
            schedule.BackColor = SystemColors.ControlDarkDark;
            schedule.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            schedule.Location = new Point(282, 54);
            schedule.Name = "schedule";
            schedule.Size = new Size(89, 25);
            schedule.TabIndex = 28;
            schedule.Text = "schedule";
            schedule.Visible = false;
            schedule.Click += schedule_Click;
            // 
            // seat_name
            // 
            seat_name.AutoSize = true;
            seat_name.BackColor = SystemColors.ControlDarkDark;
            seat_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seat_name.Location = new Point(93, 118);
            seat_name.Name = "seat_name";
            seat_name.Size = new Size(120, 25);
            seat_name.TabIndex = 26;
            seat_name.Text = "SEAT : name";
            seat_name.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(543, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 314);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.ControlDarkDark;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(21, 118);
            label22.Name = "label22";
            label22.Size = new Size(66, 25);
            label22.TabIndex = 24;
            label22.Text = "SEAT :";
            label22.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = SystemColors.ControlDarkDark;
            label23.Location = new Point(21, 54);
            label23.Name = "label23";
            label23.Size = new Size(217, 15);
            label23.TabIndex = 23;
            label23.Text = "__________________________________________";
            // 
            // concert_name
            // 
            concert_name.AutoSize = true;
            concert_name.BackColor = SystemColors.ControlDarkDark;
            concert_name.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            concert_name.Location = new Point(19, 13);
            concert_name.Name = "concert_name";
            concert_name.Size = new Size(123, 41);
            concert_name.TabIndex = 22;
            concert_name.Text = "TICKET";
            concert_name.Click += concert_name_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(208, 899);
            button6.Name = "button6";
            button6.Size = new Size(65, 55);
            button6.TabIndex = 32;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(347, 899);
            button7.Name = "button7";
            button7.Size = new Size(65, 55);
            button7.TabIndex = 31;
            button7.Text = ">";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOliveGreen;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(620, 903);
            button8.Name = "button8";
            button8.Size = new Size(131, 40);
            button8.TabIndex = 38;
            button8.Text = "PRINT";
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOliveGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(757, 905);
            button4.Name = "button4";
            button4.Size = new Size(131, 40);
            button4.TabIndex = 39;
            button4.Text = "BUY AGAIN";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click_2;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkOliveGreen;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(171, 507);
            button9.Name = "button9";
            button9.Size = new Size(131, 40);
            button9.TabIndex = 40;
            button9.Text = "PRINT";
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            button9.Click += button9_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(165, 507);
            button2.Name = "button2";
            button2.Size = new Size(141, 40);
            button2.TabIndex = 41;
            button2.Text = "CANCEL ORDER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // PAYMENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 963);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PAYMENT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAYMENT";
            Load += PAYMENT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SEATS;
        private DataGridViewTextBoxColumn SCHEDULES;
        private DataGridViewTextBoxColumn PRICE;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button5;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn QUANTITY1;
        private Panel panel1;
        private Panel panel2;
        private Label concert_name;
        private Label amount;
        private Label label20;
        private Label schedule;
        private Label seat_name;
        private PictureBox pictureBox1;
        private Label label22;
        private Label label23;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label24;
        private Button button4;
        private Button button9;
        private Button button2;
    }
}