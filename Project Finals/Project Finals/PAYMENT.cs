
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project_Finals
{
    public partial class PAYMENT : Form
    {

        public static PAYMENT instance;
        private int[] holder_B1c2;
        private int[] holder_B2c2;
        private int[] holder_B3c2;
        private int[] holder_B4c2;
        private int[] holder_B5c2;
        private int[] holder_B6c2;
        private int[] holder_B7c2;
        private int[] holder_B8c2;
        private int[] holder_A1c2;
        private int[] holder_A2c2;
        private int[] holder_A3c2;
        private int[] holder_A4c2;
        private int[] holder_A5c2;
        private int[] holder_A6c2;
        private int[] holder_A7c2;
        private int[] holder_A8c2;
        private int[] holder_A9c2;
        private int[] holder_A10c2;
        private int[] holder_A11c2;
        private int[] holder_A12c2;
        private int[] holder_A13c2;
        private int[] holder_A14c2;
        private int[] holder_A15c2;
        private int[] holder_A16c2;
        private int[] holder_V1c2;
        private int[] holder_V2c2;
        private int[] holder_V3c2;
        private int[] holder_V4c2;
        private int[] holder_V5c2;
        private int[] holder_V6c2;
        private int[] holder_V7c2;
        private int[] holder_V8c2;
        private int[] holder_V9c2;
        private int[] holder_V10c2;
        private int[] holder_V11c2;
        private int[] holder_V12c2;

        private int[] transfer_B1s1;
        private int[] transfer_B2s1;
        private int[] transfer_B3s1;
        private int[] transfer_B4s1;
        private int[] transfer_B5s1;
        private int[] transfer_B6s1;
        private int[] transfer_B7s1;
        private int[] transfer_B8s1;
        private int[] transfer_A1s1;
        private int[] transfer_A2s1;
        private int[] transfer_A3s1;
        private int[] transfer_A4s1;
        private int[] transfer_A5s1;
        private int[] transfer_A6s1;
        private int[] transfer_A7s1;
        private int[] transfer_A8s1;
        private int[] transfer_A9s1;
        private int[] transfer_A10s1;
        private int[] transfer_A11s1;
        private int[] transfer_A12s1;
        private int[] transfer_A13s1;
        private int[] transfer_A14s1;
        private int[] transfer_A15s1;
        private int[] transfer_A16s1;
        private int[] transfer_V1s1;
        private int[] transfer_V2s1;
        private int[] transfer_V3s1;
        private int[] transfer_V4s1;
        private int[] transfer_V5s1;
        private int[] transfer_V6s1;
        private int[] transfer_V7s1;
        private int[] transfer_V8s1;
        private int[] transfer_V9s1;
        private int[] transfer_V10s1;
        private int[] transfer_V11s1;
        private int[] transfer_V12s1;

        private int[] holder_B1c;
        private int[] holder_B2c;
        private int[] holder_B3c;
        private int[] holder_B4c;
        private int[] holder_B5c;
        private int[] holder_B6c;
        private int[] holder_B7c;
        private int[] holder_B8c;
        private int[] holder_A1c;
        private int[] holder_A2c;
        private int[] holder_A3c;
        private int[] holder_A4c;
        private int[] holder_A5c;
        private int[] holder_A6c;
        private int[] holder_A7c;
        private int[] holder_A8c;
        private int[] holder_A9c;
        private int[] holder_A10c;
        private int[] holder_A11c;
        private int[] holder_A12c;
        private int[] holder_A13c;
        private int[] holder_A14c;
        private int[] holder_A15c;
        private int[] holder_A16c;
        private int[] holder_V1c;
        private int[] holder_V2c;
        private int[] holder_V3c;
        private int[] holder_V4c;
        private int[] holder_V5c;
        private int[] holder_V6c;
        private int[] holder_V7c;
        private int[] holder_V8c;
        private int[] holder_V9c;
        private int[] holder_V10c;
        private int[] holder_V11c;
        private int[] holder_V12c;

        public int[] holder_B1s = new int[9];
        public int[] holder_B2s = new int[9];
        public int[] holder_B3s = new int[9];
        public int[] holder_B4s = new int[9];
        public int[] holder_B5s = new int[9];
        public int[] holder_B6s = new int[9];
        public int[] holder_B7s = new int[9];
        public int[] holder_B8s = new int[9];
        public int[] holder_A1s = new int[9];
        public int[] holder_A2s = new int[9];
        public int[] holder_A3s = new int[9];
        public int[] holder_A4s = new int[9];
        public int[] holder_A5s = new int[9];
        public int[] holder_A6s = new int[9];
        public int[] holder_A7s = new int[9];
        public int[] holder_A8s = new int[9];
        public int[] holder_A9s = new int[9];
        public int[] holder_A10s = new int[9];
        public int[] holder_A11s = new int[9];
        public int[] holder_A12s = new int[9];
        public int[] holder_A13s = new int[9];
        public int[] holder_A14s = new int[9];
        public int[] holder_A15s = new int[9];
        public int[] holder_A16s = new int[9];
        public int[] holder_V1s = new int[9];
        public int[] holder_V2s = new int[9];
        public int[] holder_V3s = new int[9];
        public int[] holder_V4s = new int[9];
        public int[] holder_V5s = new int[9];
        public int[] holder_V6s = new int[9];
        public int[] holder_V7s = new int[9];
        public int[] holder_V8s = new int[9];
        public int[] holder_V9s = new int[9];
        public int[] holder_V10s = new int[9];
        public int[] holder_V11s = new int[9];
        public int[] holder_V12s = new int[9];


        public int[] holder_B1s1 = new int[9];
        public int[] holder_B2s1 = new int[9];
        public int[] holder_B3s1 = new int[9];
        public int[] holder_B4s1= new int[9];
        public int[] holder_B5s1 = new int[9];
        public int[] holder_B6s1 = new int[9];
        public int[] holder_B7s1 = new int[9];
        public int[] holder_B8s1 = new int[9];
        public int[] holder_A1s1 = new int[9];
        public int[] holder_A2s1 = new int[9];
        public int[] holder_A3s1 = new int[9];
        public int[] holder_A4s1 = new int[9];
        public int[] holder_A5s1 = new int[9];
        public int[] holder_A6s1 = new int[9];
        public int[] holder_A7s1 = new int[9];
        public int[] holder_A8s1 = new int[9];
        public int[] holder_A9s1 = new int[9];
        public int[] holder_A10s1 = new int[9];
        public int[] holder_A11s1 = new int[9];
        public int[] holder_A12s1 = new int[9];
        public int[] holder_A13s1 = new int[9];
        public int[] holder_A14s1 = new int[9];
        public int[] holder_A15s1 = new int[9];
        public int[] holder_A16s1 = new int[9];
        public int[] holder_V1s1 = new int[9];
        public int[] holder_V2s1 = new int[9];
        public int[] holder_V3s1 = new int[9];
        public int[] holder_V4s1 = new int[9];
        public int[] holder_V5s1 = new int[9];
        public int[] holder_V6s1 = new int[9];
        public int[] holder_V7s1 = new int[9];
        public int[] holder_V8s1 = new int[9];
        public int[] holder_V9s1 = new int[9];
        public int[] holder_V10s1 = new int[9];
        public int[] holder_V11s1 = new int[9];
        public int[] holder_V12s1 = new int[9];

        public bool cancel_order = false;

        public bool addorder = false;

        public int User_Payment = 0;
        public int User_Total = 0;
        public string[] confirmname2 = new string[6];
        private string[] name_of_concert;
        public bool handle = true;
        public int total_holder;

        public string deleting_seat;
        public string deleting_sched;

        public string[] holder_seat = new string[900];
        public string[] holder_schedule = new string[900];
        public string[] holder_price = new string[900];
        public string[] holder_quantity = new string[900];

        public string[] ticket_seat = new string[900];
        public string[] ticket_shedule = new string[900];
        public string[] ticket_price = new string[900];
        public string[] ticket_quantity = new string[900];

        public int holder_counter;

        public string[] seats = new string[900];

        public int counter_delete = 0;

        int counter_update = 0;
        public bool napaka_pogi_ko = false;
        public PAYMENT()
        {
            InitializeComponent();
            instance = this;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            concerts_tickets concerts_Tickets = new concerts_tickets();
            this.Hide();
            concerts_Tickets.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public PAYMENT(int total, string[] confirmtitle, string[] datetime, string[] price_seat, string[] seatnames1, string[] quantity, int counterholder, int[] transfer_B1s, int[] transfer_B2s, int[] transfer_B3s, int[] transfer_B4s, int[] transfer_B5s, int[] transfer_B6s, int[] transfer_B7s, int[] transfer_B8s, int[] transfer_A1s, int[] transfer_A2s, int[] transfer_A3s, int[] transfer_A4s, int[] transfer_A5s, int[] transfer_A6s, int[] transfer_A7s, int[] transfer_A8s, int[] transfer_A9s, int[] transfer_A10s, int[] transfer_A11s, int[] transfer_A12s, int[] transfer_A13s, int[] transfer_A14s, int[] transfer_A15s, int[] transfer_A16s, int[] transfer_V1s, int[] transfer_V2s, int[] transfer_V3s, int[] transfer_V4s, int[] transfer_V5s, int[] transfer_V6s, int[] transfer_V7s, int[] transfer_V8s, int[] transfer_V9s, int[] transfer_V10s, int[] transfer_V11s, int[] transfer_V12s
            , int[] transfer_B1s1, int[] transfer_B2s1, int[] transfer_B3s1, int[] transfer_B4s1, int[] transfer_B5s1, int[] transfer_B6s1, int[] transfer_B7s1, int[] transfer_B8s1, int[] transfer_A1s1, int[] transfer_A2s1, int[] transfer_A3s1, int[] transfer_A4s1, int[] transfer_A5s1, int[] transfer_A6s1, int[] transfer_A7s1, int[] transfer_A8s1, int[] transfer_A9s1, int[] transfer_A10s1, int[] transfer_A11s1, int[] transfer_A12s1, int[] transfer_A13s1, int[] transfer_A14s1, int[] transfer_A15s1, int[] transfer_A16s1, int[] transfer_V1s1, int[] transfer_V2s1, int[] transfer_V3s1, int[] transfer_V4s1, int[] transfer_V5s1, int[] transfer_V6s1, int[] transfer_V7s1, int[] transfer_V8s1, int[] transfer_V9s1, int[] transfer_V10s1, int[] transfer_V11s1, int[] transfer_V12s1)
        {
            InitializeComponent();

            for (int i = 0; i <= 8; i++)
            {
                holder_B1s[i] = transfer_B1s[i];
                holder_B2s[i] = transfer_B2s[i];
                holder_B3s[i] = transfer_B3s[i];
                holder_B4s[i] = transfer_B4s[i];
                holder_B5s[i] = transfer_B5s[i];
                holder_B6s[i] = transfer_B6s[i];
                holder_B7s[i] = transfer_B7s[i];
                holder_B8s[i] = transfer_B8s[i];

                holder_A1s[i] = transfer_A1s[i];
                holder_A2s[i] = transfer_A2s[i];
                holder_A3s[i] = transfer_A3s[i];
                holder_A4s[i] = transfer_A4s[i];
                holder_A5s[i] = transfer_A5s[i];
                holder_A6s[i] = transfer_A6s[i];
                holder_A7s[i] = transfer_A7s[i];
                holder_A8s[i] = transfer_A8s[i];
                holder_A9s[i] = transfer_A9s[i];
                holder_A10s[i] = transfer_A10s[i];
                holder_A11s[i] = transfer_A11s[i];
                holder_A12s[i] = transfer_A12s[i];
                holder_A13s[i] = transfer_A13s[i];
                holder_A14s[i] = transfer_A14s[i];
                holder_A15s[i] = transfer_A15s[i];
                holder_A16s[i] = transfer_A16s[i];

                holder_V1s[i] = transfer_V1s[i];
                holder_V2s[i] = transfer_V2s[i];
                holder_V3s[i] = transfer_V3s[i];
                holder_V4s[i] = transfer_V4s[i];
                holder_V5s[i] = transfer_V5s[i];
                holder_V6s[i] = transfer_V6s[i];
                holder_V7s[i] = transfer_V7s[i];
                holder_V8s[i] = transfer_V8s[i];
                holder_V9s[i] = transfer_V9s[i];
                holder_V10s[i] = transfer_V10s[i];
                holder_V11s[i] = transfer_V11s[i];
                holder_V12s[i] = transfer_V12s[i];

                //concert_ticket 
                holder_B1s1[i] = transfer_B1s1[i];
                holder_B2s1[i] = transfer_B2s1[i];
                holder_B3s1[i] = transfer_B3s1[i];
                holder_B4s1[i] = transfer_B4s1[i];
                holder_B5s1[i] = transfer_B5s1[i];
                holder_B6s1[i] = transfer_B6s1[i];
                holder_B7s1[i] = transfer_B7s1[i];
                holder_B8s1[i] = transfer_B8s1[i];

                holder_A1s1[i] = transfer_A1s1[i];
                holder_A2s1[i] = transfer_A2s1[i];
                holder_A3s1[i] = transfer_A3s1[i];
                holder_A4s1[i] = transfer_A4s1[i];
                holder_A5s1[i] = transfer_A5s1[i];
                holder_A6s1[i] = transfer_A6s1[i];
                holder_A7s1[i] = transfer_A7s1[i];
                holder_A8s1[i] = transfer_A8s1[i];
                holder_A9s1[i] = transfer_A9s1[i];
                holder_A10s1[i] = transfer_A10s1[i];
                holder_A11s1[i] = transfer_A11s1[i];
                holder_A12s1[i] = transfer_A12s1[i];
                holder_A13s1[i] = transfer_A13s1[i];
                holder_A14s1[i] = transfer_A14s1[i];
                holder_A15s1[i] = transfer_A15s1[i];
                holder_A16s1[i] = transfer_A16s1[i];

                holder_V1s1[i] = transfer_V1s1[i];
                holder_V2s1[i] = transfer_V2s1[i];
                holder_V3s1[i] = transfer_V3s1[i];
                holder_V4s1[i] = transfer_V4s1[i];
                holder_V5s1[i] = transfer_V5s1[i];
                holder_V6s1[i] = transfer_V6s1[i];
                holder_V7s1[i] = transfer_V7s1[i];
                holder_V8s1[i] = transfer_V8s1[i];
                holder_V9s1[i] = transfer_V9s1[i];
                holder_V10s1[i] = transfer_V10s1[i];
                holder_V11s1[i] = transfer_V11s1[i];

            }


            holder_counter = counterholder;

            for (int i = 0; i <= 5; i++)
            {
                if (confirmtitle != null && i <= confirmtitle.Length)
                {
                    confirmname2[i] = confirmtitle[i];
                }
            }

            User_Total = total;
            total_holder = total;

            label6.Text = ("₱ " + Convert.ToDouble(total));

            bool pogi = true;

            int inr1 = 0;
            int fck1 = 0;

            while (pogi)
            {

                if (seatnames1[fck1] != null)
                {
                    holder_seat[inr1] = seatnames1[fck1];
                    holder_schedule[inr1] = datetime[fck1];
                    holder_price[inr1] = price_seat[fck1];
                    holder_quantity[inr1] = quantity[fck1];

                    inr1++;
                }

                fck1++;

                if (fck1 == 899)
                {
                    break;
                }

            }

            for (int i = 0; i <= 899; i++)
            {
                if (seatnames1[i] != null)
                {
                    dataGridView1.Rows.Add(seatnames1[i], datetime[i], price_seat[i], quantity[i]);
                }
                else
                {
                    continue;
                }

            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void PAYMENT_Load(object sender, EventArgs e)
        {

        }

        public void concertname()
        {
            label24.Visible = true;

            if (confirmname2[0] == "Bini")
            {
                label24.Text = "BINI CONCERT";
                concert_name.Text = label24.Text;
            }
            else if (confirmname2[1] == "Parokya Ni Edgar")
            {
                label24.Text = " PAROKYA NI EDGAR CONCERT";
                concert_name.Text = label24.Text;
            }
            else if (confirmname2[2] == "SB19")
            {
                label24.Text = "SB19 CONCERT";
                concert_name.Text = label24.Text;
            }
            else if (confirmname2[3] == "Bruno Mars")
            {
                label24.Text = " BRUNO MARS CONCERT";
                concert_name.Text = label24.Text;
            }
            else if (confirmname2[4] == "Taylor Swift")
            {
                label24.Text = "TAYLOR SWIFT CONCERT";
                concert_name.Text = label24.Text;
            }
            else if (confirmname2[5] == "Laufey")
            {
                label24.Text = " LAUFEY CONCERT";
                concert_name.Text = label24.Text;
            }

        }
        public void apply_toreciept()
        {
            label9.Text = textBox1.Text.ToUpper();
            label10.Text = textBox2.Text;

            label19.Text = ("₱ " + textBox4.Text);
            label17.Text = label6.Text;
            label18.Text = label8.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please Make sure to fill up the requirments", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                User_Payment = Convert.ToInt32(textBox4.Text);
                if (User_Payment >= User_Total)
                {
                    double sum = User_Payment - User_Total;
                    label8.Text = ("₱ " + sum);

                    button5.Visible = false;
                    button1.Visible = false;
                    button3.Visible = false;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button4.Visible = true;
                    button9.Visible = true;
                    button2.Visible = false;

                    bool pogi = true;

                    int inr = 0;
                    int fck = 0;

                    while (pogi)
                    {

                        if (holder_seat[fck] != null)
                        {
                            ticket_seat[inr] = holder_seat[fck];
                            ticket_shedule[inr] = holder_schedule[fck];
                            ticket_price[inr] = holder_price[fck];
                            ticket_quantity[inr] = holder_quantity[fck];

                            inr++;
                        }

                        fck++;

                        if (fck == 899)
                        {
                            break;
                        }

                    }

                    apply_toreciept();

                    concertname();

                    datagrind();

                    changepicture();

                    tickets();

                }
                else if (textBox4.Text == null)
                {
                    MessageBox.Show("Please enter a amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Clear();
                    textBox1.Focus();
                }
                else if (User_Payment < User_Total)
                {
                    MessageBox.Show("Insufficient payment", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Clear();
                    textBox1.Focus();

                }
            }
        }

        public void tickets()
        {
            label22.Visible = true;
            label20.Visible = true;
            seat_name.Visible = true;
            amount.Visible = true;
            schedule.Visible = true;

            seat_name.Text = ticket_seat[0];
            amount.Text = ticket_price[0];
            schedule.Text = ticket_shedule[0];

        }
        public void datagrind()
        {

            for (int i = 0; i <= 899; i++)
            {

                if (ticket_seat[i] != null)
                {

                    dataGridView2.Rows.Add(ticket_seat[i], ticket_shedule[i], ticket_price[i], ticket_quantity[i]);

                }
                else
                {
                    continue;

                }

            }

        }
        public void changepicture()
        {
            if (confirmname2[0] == "Bini")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\Bini.jpg");
            }
            else if (confirmname2[1] == "Parokya Ni Edgar")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\Parokya ni edgar.jpg");
            }
            else if (confirmname2[2] == "SB19")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\sb19.jpg");
            }
            else if (confirmname2[3] == "Bruno Mars")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\bruno.jpg");
            }
            else if (confirmname2[4] == "Taylor Swift")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\taylor.jpg");
            }
            else if (confirmname2[5] == "Laufey")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("C:\\Users\\LENOVO-PC\\OneDrive\\Desktop\\Project Finals Group 4\\Laufey.jpg");
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            addorder = true;
            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert, confirmname2, addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;

            string[] deleting_order = new string[4];

            foreach (DataGridViewRow row in selectedRows)
            {
                deleting_order[0] = row.Cells[0].Value.ToString();
                deleting_order[1] = row.Cells[1].Value.ToString();
                deleting_order[2] = row.Cells[2].Value.ToString();
                deleting_order[3] = row.Cells[3].Value.ToString();

                conditional_deleting(deleting_order);

                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }

            for(int i = 0; i <= 899; i++)
            {

                if (holder_seat[i] == deleting_order[0] && holder_schedule[i] == deleting_order[1] && holder_price[i] == deleting_order[2] && holder_quantity[i] == deleting_order[3])
                {
                    holder_seat[i] = null;
                    holder_schedule[i] = null;
                    holder_price[i] = null;
                    holder_quantity[i] = null;
            }

            }

            total_holder -= Convert.ToInt32(deleting_order[2]) * Convert.ToInt32(deleting_order[3]);

            label6.Text = ("₱ " + total_holder.ToString());

            holder_counter--;
        }
        public void conditional_deleting(string[] deleting_order)
        {

            if (deleting_order.Length >= 4)
            {
                switch (deleting_order[0])
                {
                    //B1
                    case "B1":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B1s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B1s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B1s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B1s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B1s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B1s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B1s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B1s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B1s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B2

                    case "B2":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B2s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B2s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B2s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B2s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B2s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B2s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B2s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B2s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B2s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B3

                    case "B3":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B3s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B3s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B3s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B3s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B3s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B3s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B3s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B3s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B3s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B4

                    case "B4":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B4s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B4s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B4s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B4s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B4s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B4s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B4s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B4s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B4s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B5

                    case "B5":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B5s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B5s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B5s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B5s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B5s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B5s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B5s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B5s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B5s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B6

                    case "B6":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B6s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B6s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B6s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B6s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B6s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B6s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B6s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B6s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B6s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B7

                    case "B7":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B7s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B7s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B7s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B7s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B7s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B7s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B7s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B7s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B7s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //B8

                    case "B8":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_B8s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_B8s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_B8s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_B8s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_B8s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_B8s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_B8s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_B8s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_B8s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A1

                    case "A1":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A1s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A1s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A1s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A1s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A1s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A1s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A1s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A1s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A1s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A2

                    case "A2":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A2s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A2s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A2s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A2s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A2s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A2s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A2s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A2s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A2s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A3

                    case "A3":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A3s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A3s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A3s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A3s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A3s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A3s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A3s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A3s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A3s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A4

                    case "A4":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A4s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A4s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A4s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A4s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A4s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A4s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A4s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A4s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A4s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A5

                    case "A5":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A5s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A5s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A5s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A5s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A5s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A5s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A5s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A5s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A5s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A6

                    case "A6":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A6s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A6s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A6s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A6s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A6s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A6s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A6s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A6s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A6s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A7

                    case "A7":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A7s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A7s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A7s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A7s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A7s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A7s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A7s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A7s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A7s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A8

                    case "A8":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A8s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A8s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A8s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A8s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A8s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A8s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A8s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A8s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A8s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A9

                    case "A9":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A9s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A9s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A9s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A9s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A9s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A9s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A9s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A9s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A9s[9] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A10

                    case "A10":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A10s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A10s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A10s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A10s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A10s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A10s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A10s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A10s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A10s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A11

                    case "A11":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A11s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A11s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A11s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A11s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A11s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A11s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A11s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A11s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A11s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A12

                    case "A12":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A12s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A12s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A12s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A12s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A12s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A12s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A12s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A12s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A12s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A13

                    case "A13":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A13s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A13s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A13s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A13s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A13s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A13s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A13s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A13s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A13s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A14

                    case "A14":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A14s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A14s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A14s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A14s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A14s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A14s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A14s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A14s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A14s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A15

                    case "A15":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A15s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A15s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A15s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A15s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A15s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A15s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A15s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A15s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A15s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //A16

                    case "A16":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_A16s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_A16s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_A16s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_A16s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_A16s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_A16s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_A16s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_A16s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_A16s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V1

                    case "V1":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V1s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V1s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V1s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V1s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V1s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V1s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V1s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V1s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V1s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V2

                    case "V2":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V2s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V2s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V2s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V2s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V2s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V2s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V2s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V2s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V2s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V3

                    case "V3":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V3s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V3s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V3s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V3s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V3s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V3s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V3s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V3s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V3s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V4

                    case "V4":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V4s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V4s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V4s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V4s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V4s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V4s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V4s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V4s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V4s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V5

                    case "V5":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V5s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V5s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V5s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V5s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V5s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V5s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V5s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V5s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V5s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V6

                    case "V6":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V6s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V6s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V6s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V6s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V6s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V6s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V6s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V6s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V6s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V7

                    case "V7":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V7s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V7s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V7s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V7s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V7s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V7s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V7s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V7s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V7s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V8

                    case "V8":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V8s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V8s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V8s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V8s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V8s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V8s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V8s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V8s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V8s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V9

                    case "V9":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V9s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V9s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V9s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V9s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V9s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V9s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V9s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V9s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V9s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V10

                    case "V10":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V10s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V10s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V10s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V10s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V10s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V10s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V10s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V10s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V10s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V11

                    case "V11":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V11s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V11s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V11s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V11s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V11s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V11s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V11s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V11s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V11s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }

                        break;

                    //V12

                    case "V12":

                        switch (deleting_order[1])
                        {
                            case "AUGUST 18, 8:00 PM":

                                holder_V12s[0] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "AUGUST 19, 7:00 PM":

                                holder_V12s[1] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "SEPTEMBER 22, 8:00 PM":

                                holder_V12s[2] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "JANUARY 24, 7:00 PM":

                                holder_V12s[3] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 32, 6:00 PM":

                                holder_V12s[4] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 11, 5:30 PM":

                                holder_V12s[5] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MARCH 30, 7:46 PM":

                                holder_V12s[6] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "NOVEMBER 29, 8:00 PM":

                                holder_V12s[7] -= Convert.ToInt32(deleting_order[3]);

                                break;

                            case "MAY 12, 6:00 PM":

                                holder_V12s[8] -= Convert.ToInt32(deleting_order[3]);

                                break;
                        }
                        break;
                }
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void concert_name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void schedule_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            concerts_tickets concerts_Tickets = new concerts_tickets(holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                 transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1,
                  holder_B1s1, holder_B2s1, holder_B3s1, holder_B4s1, holder_B5s1, holder_B6s1, holder_B7s1, holder_B8s1, holder_A1s1, holder_A2s1, holder_A3s1, holder_A4s1, holder_A5s1, holder_A6s1, holder_A7s1, holder_A8s1, holder_A9s1, holder_A10s1, holder_A11s1, holder_A12s1, holder_A13s1, holder_A14s1, holder_A15s1, holder_A16s1, holder_V1s1, holder_V2s1, holder_V3s1, holder_V4s1, holder_V5s1, holder_V6s1, holder_V7s1, holder_V8s1, holder_V9s1, holder_V10s1, holder_V11s1, holder_V12s1,
                  napaka_pogi_ko,
                  holder_B1c2, holder_B2c2, holder_B3c2, holder_B4c2, holder_B5c2, holder_B6c2, holder_B7c2, holder_B8c2, holder_A1c2, holder_A2c2, holder_A3c2, holder_A4c2, holder_A5c2, holder_A6c2, holder_A7c2, holder_A8c2, holder_A9c2, holder_A10c2, holder_A11c2, holder_A12c2, holder_A13c2, holder_A14c2, holder_A15c2, holder_A16c2, holder_V1c2, holder_V2c2, holder_V3c2, holder_V4c2, holder_V5c2, holder_V6c2, holder_V7c2, holder_V8c2, holder_V9c2, holder_V10c2, holder_V11c2, holder_V12c2);
            this.Hide();
            concerts_Tickets.ShowDialog();

        }

        //panel1

        PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();
        PrintDocument PrintDocument = new PrintDocument();
        private void button9_Click_1(object sender, EventArgs e)
        {

            Print(this.panel1);
        }

        public void Print(Panel pnl)
        {
            PrinterSettings settings = new PrinterSettings();
            panel1 = pnl;
            getprintrea(pnl);
            PrintPreviewDialog.Document = PrintDocument;
            PrintDocument.PrintPage += new PrintPageEventHandler(PrintDocument_print);
            PrintPreviewDialog.ShowDialog();
        }
        public void PrintDocument_print(object sender, PrintPageEventArgs e)
        {

            Rectangle pa = new Rectangle();
            e.Graphics.DrawImage(Bitmap, (pa.Width / 5) - (this.panel1.Width / 50) - (pa.Height / 1), this.panel1.Location.X);

        }
        Bitmap Bitmap;
        public void getprintrea(Panel pnl)
        {

            Bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(Bitmap, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        //panel2

        PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
        PrintDocument PrintDocument1 = new PrintDocument();
        private void button8_Click(object sender, EventArgs e)
        {
            Print1(this.panel2);
        }
        public void Print1(Panel pnl1)
        {
            PrinterSettings settings1 = new PrinterSettings();
            panel2 = pnl1;
            getprintrea1(pnl1);
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_print1);
            PrintPreviewDialog1.ShowDialog();
        }

        public void PrintDocument_print1(object sender, PrintPageEventArgs e)
        {

            Rectangle pa1 = new Rectangle();
            e.Graphics.DrawImage(Bitmap1, (pa1.Width / 5) - (this.panel2.Width / 50), this.panel2.Location.X);

        }

        Bitmap Bitmap1;
       

        public void getprintrea1(Panel pnl1)
        {

            Bitmap1 = new Bitmap(pnl1.Width, pnl1.Height);
            pnl1.DrawToBitmap(Bitmap1, new Rectangle(0, 0, pnl1.Width, pnl1.Height));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            counter_update++;

            if (ticket_seat[counter_update] != null)
            {
                seat_name.Text = ticket_seat[counter_update];
                amount.Text = ticket_price[counter_update];
                schedule.Text = ticket_shedule[counter_update];
            }
            else
            {
                counter_update--;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter_update--;

            if (counter_update >= 0)
            {
                seat_name.Text = ticket_seat[counter_update];
                amount.Text = ticket_price[counter_update];
                schedule.Text = ticket_shedule[counter_update];
            }
            else
            {
                counter_update++;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            napaka_pogi_ko = true;

            concerts_tickets concerts_Tickets = new concerts_tickets(holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                 transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1,
                 holder_B1s1, holder_B2s1, holder_B3s1, holder_B4s1, holder_B5s1, holder_B6s1, holder_B7s1, holder_B8s1, holder_A1s1, holder_A2s1, holder_A3s1, holder_A4s1, holder_A5s1, holder_A6s1, holder_A7s1, holder_A8s1, holder_A9s1, holder_A10s1, holder_A11s1, holder_A12s1, holder_A13s1, holder_A14s1, holder_A15s1, holder_A16s1, holder_V1s1, holder_V2s1, holder_V3s1, holder_V4s1, holder_V5s1, holder_V6s1, holder_V7s1, holder_V8s1, holder_V9s1, holder_V10s1, holder_V11s1, holder_V12s1,
                 napaka_pogi_ko,
                 holder_B1c2, holder_B2c2, holder_B3c2, holder_B4c2, holder_B5c2, holder_B6c2, holder_B7c2, holder_B8c2, holder_A1c2, holder_A2c2, holder_A3c2, holder_A4c2, holder_A5c2, holder_A6c2, holder_A7c2, holder_A8c2, holder_A9c2, holder_A10c2, holder_A11c2, holder_A12c2, holder_A13c2, holder_A14c2, holder_A15c2, holder_A16c2, holder_V1c2, holder_V2c2, holder_V3c2, holder_V4c2, holder_V5c2, holder_V6c2, holder_V7c2, holder_V8c2, holder_V9c2, holder_V10c2, holder_V11c2, holder_V12c2);

            this.Hide();
            concerts_Tickets.ShowDialog();
        }
    }
}
