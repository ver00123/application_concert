using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace Project_Finals
{

    public partial class concerts_tickets : Form
    {
        public string[] name_of_concert = new string[6];
        private string[] confirmname2;
        public static concerts_tickets instance;

        private bool holder_conformation;
        private bool addorder;
        private string[] holder_seat;
        private string[] holder_schedule;
        private string[] holder_price;
        private string[] holder_quantity;
        private int holder_counter;
        private int total_holder;
        private int[] holder_B1s;
        private int[] holder_B2s;
        private int[] holder_B3s;
        private int[] holder_B4s;
        private int[] holder_B5s;
        private int[] holder_B6s;
        private int[] holder_B7s;
        private int[] holder_B8s;
        private int[] holder_A1s;
        private int[] holder_A2s;
        private int[] holder_A3s;
        private int[] holder_A4s;
        private int[] holder_A5s;
        private int[] holder_A6s;
        private int[] holder_A7s;
        private int[] holder_A8s;
        private int[] holder_A9s;
        private int[] holder_A10s;
        private int[] holder_A11s;
        private int[] holder_A12s;
        private int[] holder_A13s;
        private int[] holder_A14s;
        private int[] holder_A15s;
        private int[] holder_A16s;
        private int[] holder_V1s;
        private int[] holder_V2s;
        private int[] holder_V3s;
        private int[] holder_V4s;
        private int[] holder_V5s;
        private int[] holder_V6s;
        private int[] holder_V7s;
        private int[] holder_V8s;
        private int[] holder_V9s;
        private int[] holder_V10s;
        private int[] holder_V11s;
        private int[] holder_V12s;

        public int[] holder_B1c = new int[9];
        public int[] holder_B2c = new int[9];
        public int[] holder_B3c = new int[9];
        public int[] holder_B4c = new int[9];
        public int[] holder_B5c = new int[9];
        public int[] holder_B6c = new int[9];
        public int[] holder_B7c = new int[9];
        public int[] holder_B8c = new int[9];

        public int[] holder_A1c = new int[9];
        public int[] holder_A2c = new int[9];
        public int[] holder_A3c = new int[9];
        public int[] holder_A4c = new int[9];
        public int[] holder_A5c = new int[9];
        public int[] holder_A6c = new int[9];
        public int[] holder_A7c = new int[9];
        public int[] holder_A8c = new int[9];
        public int[] holder_A9c = new int[9];
        public int[] holder_A10c = new int[9];
        public int[] holder_A11c = new int[9];
        public int[] holder_A12c = new int[9];
        public int[] holder_A13c = new int[9];
        public int[] holder_A14c = new int[9];
        public int[] holder_A15c = new int[9];
        public int[] holder_A16c = new int[9];

        public int[] holder_V1c = new int[9];
        public int[] holder_V2c = new int[9];
        public int[] holder_V3c = new int[9];
        public int[] holder_V4c = new int[9];
        public int[] holder_V5c = new int[9];
        public int[] holder_V6c = new int[9];
        public int[] holder_V7c = new int[9];
        public int[] holder_V8c = new int[9];
        public int[] holder_V9c = new int[9];
        public int[] holder_V10c = new int[9];
        public int[] holder_V11c = new int[9];
        public int[] holder_V12c = new int[9];

        //logout value

        public int[] holder_B1c1 = new int[9];
        public int[] holder_B2c1 = new int[9];
        public int[] holder_B3c1 = new int[9];
        public int[] holder_B4c1 = new int[9];
        public int[] holder_B5c1 = new int[9];
        public int[] holder_B6c1 = new int[9];
        public int[] holder_B7c1 = new int[9];
        public int[] holder_B8c1 = new int[9];

        public int[] holder_A1c1 = new int[9];
        public int[] holder_A2c1 = new int[9];
        public int[] holder_A3c1 = new int[9];
        public int[] holder_A4c1 = new int[9];
        public int[] holder_A5c1 = new int[9];
        public int[] holder_A6c1 = new int[9];
        public int[] holder_A7c1 = new int[9];
        public int[] holder_A8c1 = new int[9];
        public int[] holder_A9c1 = new int[9];
        public int[] holder_A10c1 = new int[9];
        public int[] holder_A11c1 = new int[9];
        public int[] holder_A12c1 = new int[9];
        public int[] holder_A13c1 = new int[9];
        public int[] holder_A14c1 = new int[9];
        public int[] holder_A15c1 = new int[9];
        public int[] holder_A16c1 = new int[9];

        public int[] holder_V1c1 = new int[9];
        public int[] holder_V2c1 = new int[9];
        public int[] holder_V3c1 = new int[9];
        public int[] holder_V4c1 = new int[9];
        public int[] holder_V5c1 = new int[9];
        public int[] holder_V6c1 = new int[9];
        public int[] holder_V7c1 = new int[9];
        public int[] holder_V8c1 = new int[9];
        public int[] holder_V9c1 = new int[9];
        public int[] holder_V10c1 = new int[9];
        public int[] holder_V11c1 = new int[9];
        public int[] holder_V12c1 = new int[9];
        public concerts_tickets()
        {
            InitializeComponent();
            instance = this;
        }
          public concerts_tickets(int[] holder_B1s, int[] holder_B2s, int[] holder_B3s, int[] holder_B4s, int[] holder_B5s, int[] holder_B6s, int[] holder_B7s, int[] holder_B8s, int[] holder_A1s, int[] holder_A2s, int[] holder_A3s, int[] holder_A4s, int[] holder_A5s, int[] holder_A6s, int[] holder_A7s, int[] holder_A8s, int[] holder_A9s, int[] holder_A10s, int[] holder_A11s, int[] holder_A12s, int[] holder_A13s, int[] holder_A14s, int[] holder_A15s, int[] holder_A16s, int[] holder_V1s, int[] holder_V2s, int[] holder_V3s, int[] holder_V4s, int[] holder_V5s, int[] holder_V6s, int[] holder_V7s, int[] holder_V8s, int[] holder_V9s, int[] holder_V10s, int[] holder_V11s, int[] holder_V12s,
             int[] transfer_B1s1 ,int[] transfer_B2s1, int[]transfer_B3s1, int[] transfer_B4s1, int[] transfer_B5s1, int[] transfer_B6s1, int[] transfer_B7s1, int[] transfer_B8s1, int[] transfer_A1s1, int[] transfer_A2s1, int[] transfer_A3s1, int[] transfer_A4s1, int[] transfer_A5s1, int[] transfer_A6s1, int[] transfer_A7s1, int[] transfer_A8s1, int[] transfer_A9s1, int[] transfer_A10s1, int[] transfer_A11s1, int[] transfer_A12s1, int[] transfer_A13s1, int[] transfer_A14s1, int[] transfer_A15s1, int[] transfer_A16s1, int[] transfer_V1s1, int[] transfer_V2s1, int[] transfer_V3s1, int[] transfer_V4s1, int[] transfer_V5s1, int[] transfer_V6s1, int[] transfer_V7s1, int[] transfer_V8s1, int[] transfer_V9s1, int[] transfer_V10s1, int[] transfer_V11s1, int[] transfer_V12s1,
               int[] holder_B1s1, int[] holder_B2s1, int[] holder_B3s1, int[] holder_B4s1, int[] holder_B5s1, int[] holder_B6s1,int[] holder_B7s1, int[] holder_B8s1, int[] holder_A1s1, int[] holder_A2s1, int[] holder_A3s1, int[] holder_A4s1, int[] holder_A5s1, int[] holder_A6s1, int[] holder_A7s1, int[] holder_A8s1, int[] holder_A9s1, int[] holder_A10s1, int[] holder_A11s1, int[] holder_A12s1, int[] holder_A13s1, int[] holder_A14s1, int[] holder_A15s1, int[] holder_A16s1, int[] holder_V1s1, int[] holder_V2s1, int[] holder_V3s1, int[] holder_V4s1, int[] holder_V5s1, int[] holder_V6s1, int[] holder_V7s1, int[] holder_V8s1, int[] holder_V9s1, int[] holder_V10s1, int[] holder_V11s1, int[] holder_V12s1,
               bool napaka_pogi_ko,
              int[] holder_B1c2, int[] holder_B2c2, int[] holder_B3c2, int[] holder_B4c2, int[] holder_B5c2, int[] holder_B6c2, int[] holder_B7c2, int[] holder_B8c2, int[] holder_A1c2, int[] holder_A2c2, int[] holder_A3c2, int[] holder_A4c2, int[] holder_A5c2, int[] holder_A6c2, int[] holder_A7c2, int[] holder_A8c2, int[] holder_A9c2, int[] holder_A10c2, int[] holder_A11c2, int[] holder_A12c2, int[] holder_A13c2, int[] holder_A14c2, int[] holder_A15c2, int[] holder_A16c2, int[] holder_V1c2, int[] holder_V2c2, int[] holder_V3c2, int[] holder_V4c2, int[] holder_V5c2, int[] holder_V6c2, int[] holder_V7c2, int[] holder_V8c2, int[] holder_V9c2, int[] holder_V10c2, int[] holder_V11c2, int[] holder_V12c2)
  {

            InitializeComponent();

            for (int i = 0; i <= 8; i++)
            {
                if (holder_B1c2 != null)
                {
                    holder_B1c[i] = holder_B1c2[i];
                    holder_B2c[i] = holder_B2c2[i];
                    holder_B3c[i] = holder_B3c2[i];
                    holder_B4c[i] = holder_B4c2[i];
                    holder_B5c[i] = holder_B5c2[i];
                    holder_B6c[i] = holder_B6c2[i];
                    holder_B7c[i] = holder_B7c2[i];
                    holder_B8c[i] = holder_B8c2[i];

                    holder_A1c[i] = holder_A1c2[i];
                    holder_A2c[i] = holder_A2c2[i];
                    holder_A3c[i] = holder_A3c2[i];
                    holder_A4c[i] = holder_A4c2[i];
                    holder_A5c[i] = holder_A5c2[i];
                    holder_A6c[i] = holder_A6c2[i];
                    holder_A7c[i] = holder_A7c2[i];
                    holder_A8c[i] = holder_A8c2[i];
                    holder_A9c[i] = holder_A9c2[i];
                    holder_A10c[i] = holder_A10c2[i];
                    holder_A11c[i] = holder_A11c2[i];
                    holder_A12c[i] = holder_A12c2[i];
                    holder_A13c[i] = holder_A13c2[i];
                    holder_A14c[i] = holder_A14c2[i];
                    holder_A15c[i] = holder_A15c2[i];
                    holder_A16c[i] = holder_A16c2[i];

                    holder_V1c[i] = holder_V1c2[i];
                    holder_V2c[i] = holder_V2c2[i];
                    holder_V3c[i] = holder_V3c2[i];
                    holder_V4c[i] = holder_V4c2[i];
                    holder_V5c[i] = holder_V5c2[i];
                    holder_V6c[i] = holder_V6c2[i];
                    holder_V7c[i] = holder_V7c2[i];
                    holder_V8c[i] = holder_V8c2[i];
                    holder_V9c[i] = holder_V9c2[i];
                    holder_V10c[i] = holder_V10c2[i];
                    holder_V11c[i] = holder_V11c2[i];
                    holder_V12c[i] = holder_V12c2[i];
                }
            }


            if (napaka_pogi_ko == true)
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (holder_B1s1 != null)
                    {
                        holder_B1c[i] = holder_B1s1[i];
                        holder_B2c[i] = holder_B2s1[i];
                        holder_B3c[i] = holder_B3s1[i];
                        holder_B4c[i] = holder_B4s1[i];
                        holder_B5c[i] = holder_B5s1[i];
                        holder_B6c[i] = holder_B6s1[i];
                        holder_B7c[i] = holder_B7s1[i];
                        holder_B8c[i] = holder_B8s1[i];

                        holder_A1c[i] = holder_A1s1[i];
                        holder_A2c[i] = holder_A2s1[i];
                        holder_A3c[i] = holder_A3s1[i];
                        holder_A4c[i] = holder_A4s1[i];
                        holder_A5c[i] = holder_A5s1[i];
                        holder_A6c[i] = holder_A6s1[i];
                        holder_A7c[i] = holder_A7s1[i];
                        holder_A8c[i] = holder_A8s1[i];
                        holder_A9c[i] = holder_A9s1[i];
                        holder_A10c[i] = holder_A10s1[i];
                        holder_A11c[i] = holder_A11s1[i];
                        holder_A12c[i] = holder_A12s1[i];
                        holder_A13c[i] = holder_A13s1[i];
                        holder_A14c[i] = holder_A14s1[i];
                        holder_A15c[i] = holder_A15s1[i];
                        holder_A16c[i] = holder_A16s1[i];

                        holder_V1c[i] = holder_V1s1[i];
                        holder_V2c[i] = holder_V2s1[i];
                        holder_V3c[i] = holder_V3s1[i];
                        holder_V4c[i] = holder_V4s1[i];
                        holder_V5c[i] = holder_V5s1[i];
                        holder_V6c[i] = holder_V6s1[i];
                        holder_V7c[i] = holder_V7s1[i];
                        holder_V8c[i] = holder_V8s1[i];
                        holder_V9c[i] = holder_V9s1[i];
                        holder_V10c[i] = holder_V10s1[i];
                        holder_V11c[i] = holder_V11s1[i];
                        holder_V12c[i] = holder_V12s1[i];
                    }
                }
            }
            else { 

            for (int i = 0; i <= 8; i++)
      {
                if (holder_B1s != null)
                {
                    holder_B1c[i] = holder_B1s[i];
                    holder_B2c[i] = holder_B2s[i];
                    holder_B3c[i] = holder_B3s[i];
                    holder_B4c[i] = holder_B4s[i];
                    holder_B5c[i] = holder_B5s[i];
                    holder_B6c[i] = holder_B6s[i];
                    holder_B7c[i] = holder_B7s[i];
                    holder_B8c[i] = holder_B8s[i];

                    holder_A1c[i] = holder_A1s[i];
                    holder_A2c[i] = holder_A2s[i];
                    holder_A3c[i] = holder_A3s[i];
                    holder_A4c[i] = holder_A4s[i];
                    holder_A5c[i] = holder_A5s[i];
                    holder_A6c[i] = holder_A6s[i];
                    holder_A7c[i] = holder_A7s[i];
                    holder_A8c[i] = holder_A8s[i];
                    holder_A9c[i] = holder_A9s[i];
                    holder_A10c[i] = holder_A10s[i];
                    holder_A11c[i] = holder_A11s[i];
                    holder_A12c[i] = holder_A12s[i];
                    holder_A13c[i] = holder_A13s[i];
                    holder_A14c[i] = holder_A14s[i];
                    holder_A15c[i] = holder_A15s[i];
                    holder_A16c[i] = holder_A16s[i];

                    holder_V1c[i] = holder_V1s[i];
                    holder_V2c[i] = holder_V2s[i];
                    holder_V3c[i] = holder_V3s[i];
                    holder_V4c[i] = holder_V4s[i];
                    holder_V5c[i] = holder_V5s[i];
                    holder_V6c[i] = holder_V6s[i];
                    holder_V7c[i] = holder_V7s[i];
                    holder_V8c[i] = holder_V8s[i];
                    holder_V9c[i] = holder_V9s[i];
                    holder_V10c[i] = holder_V10s[i];
                    holder_V11c[i] = holder_V11s[i];
                    holder_V12c[i] = holder_V12s[i];
                }
      }
            }
            for (int i = 0; i <= 8; i++)
            {
                if (transfer_B1s1 != null)
                {
                    holder_B1c[i] = transfer_B1s1[i];
                    holder_B2c[i] = transfer_B2s1[i];
                    holder_B3c[i] = transfer_B3s1[i];
                    holder_B4c[i] = transfer_B4s1[i];
                    holder_B5c[i] = transfer_B5s1[i];
                    holder_B6c[i] = transfer_B6s1[i];
                    holder_B7c[i] = transfer_B7s1[i];
                    holder_B8c[i] = transfer_B8s1[i];

                    holder_A1c[i] = transfer_A1s1[i];
                    holder_A2c[i] = transfer_A2s1[i];
                    holder_A3c[i] = transfer_A3s1[i];
                    holder_A4c[i] = transfer_A4s1[i];
                    holder_A5c[i] = transfer_A5s1[i];
                    holder_A6c[i] = transfer_A6s1[i];
                    holder_A7c[i] = transfer_A7s1[i];
                    holder_A8c[i] = transfer_A8s1[i];
                    holder_A9c[i] = transfer_A9s1[i];
                    holder_A10c[i] = transfer_A10s1[i];
                    holder_A11c[i] = transfer_A11s1[i];
                    holder_A12c[i] = transfer_A12s1[i];
                    holder_A13c[i] = transfer_A13s1[i];
                    holder_A14c[i] = transfer_A14s1[i];
                    holder_A15c[i] = transfer_A15s1[i];
                    holder_A16c[i] = transfer_A16s1[i];

                    holder_V1c[i] = transfer_V1s1[i];
                    holder_V2c[i] = transfer_V2s1[i];
                    holder_V3c[i] = transfer_V3s1[i];
                    holder_V4c[i] = transfer_V4s1[i];
                    holder_V5c[i] = transfer_V5s1[i];
                    holder_V6c[i] = transfer_V6s1[i];
                    holder_V7c[i] = transfer_V7s1[i];
                    holder_V8c[i] = transfer_V8s1[i];
                    holder_V9c[i] = transfer_V9s1[i];
                    holder_V10c[i] = transfer_V10s1[i];
                    holder_V11c[i] = transfer_V11s1[i];
                    holder_V12c[i] = transfer_V12s1[i];
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (holder_B1c != null)
                    {
                        holder_B1c1[i] = holder_B1c[i];
                        holder_B2c1[i] = holder_B2c[i];
                        holder_B3c1[i] = holder_B3c[i];
                        holder_B4c1[i] = holder_B4c[i];
                        holder_B5c1[i] = holder_B5c[i];
                        holder_B6c1[i] = holder_B6c[i];
                        holder_B7c1[i] = holder_B7c[i];
                        holder_B8c1[i] = holder_B8c[i];

                        holder_A1c1[i] = holder_A1c[i];
                        holder_A2c1[i] = holder_A2c[i];
                        holder_A3c1[i] = holder_A3c[i];
                        holder_A4c1[i] = holder_A4c[i];
                        holder_A5c1[i] = holder_A5c[i];
                        holder_A6c1[i] = holder_A6c[i];
                        holder_A7c1[i] = holder_A7c[i];
                        holder_A8c1[i] = holder_A8c[i];
                        holder_A9c1[i] = holder_A9c[i];
                        holder_A10c1[i] = holder_A10c[i];
                        holder_A11c1[i] = holder_A11c[i];
                        holder_A12c1[i] = holder_A12c[i];
                        holder_A13c1[i] = holder_A13c[i];
                        holder_A14c1[i] = holder_A14c[i];
                        holder_A15c1[i] = holder_A15c[i];
                        holder_A16c1[i] = holder_A16c[i];

                        holder_V1c1[i] = holder_V1c[i];
                        holder_V2c1[i] = holder_V2c[i];
                        holder_V3c1[i] = holder_V3c[i];
                        holder_V4c1[i] = holder_V4c[i];
                        holder_V5c1[i] = holder_V5c[i];
                        holder_V6c1[i] = holder_V6c[i];
                        holder_V7c1[i] = holder_V7c[i];
                        holder_V8c1[i] = holder_V8c[i];
                        holder_V9c1[i] = holder_V9c[i];
                        holder_V10c1[i] = holder_V10c[i];
                        holder_V11c1[i] = holder_V11c[i];
                        holder_V12c1[i] = holder_V12c[i];
                    }
                }
                Loginpage loginpage = new Loginpage(holder_B1c1, holder_B2c1, holder_B3c1, holder_B4c1, holder_B5c1, holder_B6c1, holder_B7c1, holder_B8c1, holder_A1c1, holder_A2c1, holder_A3c1, holder_A4c1, holder_A5c1, holder_A6c1, holder_A7c1, holder_A8c1, holder_A9c1, holder_A10c1, holder_A11c1, holder_A12c1, holder_A13c1, holder_A14c1, holder_A15c1, holder_A16c1, holder_V1c1, holder_V2c1, holder_V3c1, holder_V4c1, holder_V5c1, holder_V6c1, holder_V7c1, holder_V8c1, holder_V9c1, holder_V10c1, holder_V11c1, holder_V12c1);
                this.Hide();
                loginpage.ShowDialog();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_of_concert[0] = "Bini";

            Concert_Venue concert_Venue = new   Concert_Venue(name_of_concert, confirmname2, addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            name_of_concert[1] = "Parokya Ni Edgar";

            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert, confirmname2, addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            name_of_concert[2] = "SB19";

            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert, confirmname2,addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_A1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            name_of_concert[3] = "Bruno Mars";

            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert,  confirmname2,  addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_A1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            name_of_concert[4] = "Taylor Swift";

            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert,  confirmname2,  addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_A1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name_of_concert[5] = "Laufey";

            Concert_Venue concert_Venue = new Concert_Venue(name_of_concert,  confirmname2,  addorder, holder_seat, holder_schedule, holder_price, holder_quantity, holder_counter, total_holder, holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_A1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s
                 , holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
            this.Hide();
            concert_Venue.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
