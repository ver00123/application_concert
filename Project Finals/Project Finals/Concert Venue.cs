using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.ComponentModel;
namespace Project_Finals
{

    public partial class Concert_Venue : Form
    {
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

        public int[] B1s = new int[9];
        public int[] B2s = new int[9];
        public int[] B3s = new int[9];
        public int[] B4s = new int[9];
        public int[] B5s = new int[9];
        public int[] B6s = new int[9];
        public int[] B7s = new int[9];
        public int[] B8s = new int[9];
        public int[] A1s = new int[9];
        public int[] A2s = new int[9];
        public int[] A3s = new int[9];
        public int[] A4s = new int[9];
        public int[] A5s = new int[9];
        public int[] A6s = new int[9];
        public int[] A7s = new int[9];
        public int[] A8s = new int[9];
        public int[] A9s = new int[9];
        public int[] A10s = new int[9];
        public int[] A11s = new int[9];
        public int[] A12s = new int[9];
        public int[] A13s = new int[9];
        public int[] A14s = new int[9];
        public int[] A15s = new int[9];
        public int[] A16s = new int[9];
        public int[] V1s = new int[9];
        public int[] V2s = new int[9];
        public int[] V3s = new int[9];
        public int[] V4s = new int[9];
        public int[] V5s = new int[9];
        public int[] V6s = new int[9];
        public int[] V7s = new int[9];
        public int[] V8s = new int[9];
        public int[] V9s = new int[9];
        public int[] V10s = new int[9];
        public int[] V11s = new int[9];
        public int[] V12s = new int[9];


        public int[] B1a = new int[9];
        public int[] B2a = new int[9];
        public int[] B3a = new int[9];
        public int[] B4a = new int[9];
        public int[] B5a = new int[9];
        public int[] B6a = new int[9];
        public int[] B7a = new int[9];
        public int[] B8a = new int[9];
        public int[] A1a = new int[9];
        public int[] A2a = new int[9];
        public int[] A3a = new int[9];
        public int[] A4a = new int[9];
        public int[] A5a = new int[9];
        public int[] A6a = new int[9];
        public int[] A7a = new int[9];
        public int[] A8a = new int[9];
        public int[] A9a = new int[9];
        public int[] A10a = new int[9];
        public int[] A11a = new int[9];
        public int[] A12a = new int[9];
        public int[] A13a = new int[9];
        public int[] A14a = new int[9];
        public int[] A15a = new int[9];
        public int[] A16a = new int[9];
        public int[] V1a = new int[9];
        public int[] V2a = new int[9];
        public int[] V3a = new int[9];
        public int[] V4a = new int[9];
        public int[] V5a = new int[9];
        public int[] V6a = new int[9];
        public int[] V7a = new int[9];
        public int[] V8a = new int[9];
        public int[] V9a = new int[9];
        public int[] V10a = new int[9];
        public int[] V11a = new int[9];
        public int[] V12a = new int[9];


        public int[] transfer_B1s = new int[9];
        public int[] transfer_B2s = new int[9];
        public int[] transfer_B3s = new int[9];
        public int[] transfer_B4s = new int[9];
        public int[] transfer_B5s = new int[9];
        public int[] transfer_B6s = new int[9];
        public int[] transfer_B7s = new int[9];
        public int[] transfer_B8s = new int[9];
        public int[] transfer_A1s = new int[9];
        public int[] transfer_A2s = new int[9];
        public int[] transfer_A3s = new int[9];
        public int[] transfer_A4s = new int[9];
        public int[] transfer_A5s = new int[9];
        public int[] transfer_A6s = new int[9];
        public int[] transfer_A7s = new int[9];
        public int[] transfer_A8s = new int[9];
        public int[] transfer_A9s = new int[9];
        public int[] transfer_A10s = new int[9];
        public int[] transfer_A11s = new int[9];
        public int[] transfer_A12s = new int[9];
        public int[] transfer_A13s = new int[9];
        public int[] transfer_A14s = new int[9];
        public int[] transfer_A15s = new int[9];
        public int[] transfer_A16s = new int[9];
        public int[] transfer_V1s = new int[9];
        public int[] transfer_V2s = new int[9];
        public int[] transfer_V3s = new int[9];
        public int[] transfer_V4s = new int[9];
        public int[] transfer_V5s = new int[9];
        public int[] transfer_V6s = new int[9];
        public int[] transfer_V7s = new int[9];
        public int[] transfer_V8s = new int[9];
        public int[] transfer_V9s = new int[9];
        public int[] transfer_V10s = new int[9];
        public int[] transfer_V11s = new int[9];
        public int[] transfer_V12s = new int[9];

        public int[] transfer_B1s1 = new int[9];
        public int[] transfer_B2s1 = new int[9];
        public int[] transfer_B3s1 = new int[9];
        public int[] transfer_B4s1 = new int[9];
        public int[] transfer_B5s1 = new int[9];
        public int[] transfer_B6s1 = new int[9];
        public int[] transfer_B7s1 = new int[9];
        public int[] transfer_B8s1 = new int[9];
        public int[] transfer_A1s1 = new int[9];
        public int[] transfer_A2s1 = new int[9];
        public int[] transfer_A3s1 = new int[9];
        public int[] transfer_A4s1 = new int[9];
        public int[] transfer_A5s1 = new int[9];
        public int[] transfer_A6s1 = new int[9];
        public int[] transfer_A7s1 = new int[9];
        public int[] transfer_A8s1 = new int[9];
        public int[] transfer_A9s1 = new int[9];
        public int[] transfer_A10s1 = new int[9];
        public int[] transfer_A11s1 = new int[9];
        public int[] transfer_A12s1 = new int[9];
        public int[] transfer_A13s1 = new int[9];
        public int[] transfer_A14s1 = new int[9];
        public int[] transfer_A15s1 = new int[9];
        public int[] transfer_A16s1 = new int[9];
        public int[] transfer_V1s1 = new int[9];
        public int[] transfer_V2s1 = new int[9];
        public int[] transfer_V3s1 = new int[9];
        public int[] transfer_V4s1 = new int[9];
        public int[] transfer_V5s1 = new int[9];
        public int[] transfer_V6s1 = new int[9];
        public int[] transfer_V7s1 = new int[9];
        public int[] transfer_V8s1 = new int[9];
        public int[] transfer_V9s1 = new int[9];
        public int[] transfer_V10s1 = new int[9];
        public int[] transfer_V11s1 = new int[9];
        public int[] transfer_V12s1 = new int[9];

        public string[] seatnames1 = new string[900];
        public string[] price_seat = new string[900];
        public string[] datetime = new string[900];
        public string[] quantity = new string[900];
        public int counterholder = 0;

        public string[] seatnames1_holder = new string[900];
        public string[] price_seat_holder = new string[900];
        public string[] datetime_holder = new string[900];
        public string[] quantity_holder = new string[900];

        public string[] seatnames = new string[100];

        public int total = 0;

        public int b_amount;
        public int a_amount;
        public int v_amount;

        public int seat_amountholder = 0;
        public string seatsnames;
        public string date_time;

        public bool comformation = false;
        public string confirmdescription;
        public string[] confirmtitle = new string[6];
        string[] name_of_concert1 = new string[6];
        public bool conformation_cons = false;

        public static Concert_Venue instance;
        private bool addorder;

        public bool holder_addconcert;
        public int MAX_VALUE = 15;

        private string[] confirmname2;
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
        private int[] holder_A1s1;
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
        private int[] holder_A1s2;
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
        private int[] holder_V1s;
        private int[] holder_A1s;

        private int[] holder_B1s1;
        private int[] holder_B2s1;
        private int[] holder_B3s1;
        private int[] holder_B4s1;
        private int[] holder_B5s1;
        private int[] holder_B6s1;
        private int[] holder_B7s1;
        private int[] holder_B8s1;
        private int[] holder_A2s1;
        private int[] holder_A3s1;
        private int[] holder_A4s1;
        private int[] holder_A5s1;
        private int[] holder_A6s1;
        private int[] holder_A7s1;
        private int[] holder_A8s1;
        private int[] holder_A9s1;
        private int[] holder_A10s1;
        private int[] holder_A11s1;
        private int[] holder_A12s1;
        private int[] holder_A13s1;
        private int[] holder_A14s1;
        private int[] holder_A15s1;
        private int[] holder_A16s1;
        private int[] holder_V1s1;
        private int[] holder_V2s1;
        private int[] holder_V3s1;
        private int[] holder_V4s1;
        private int[] holder_V5s1;
        private int[] holder_V6s1;
        private int[] holder_V7s1;
        private int[] holder_V8s1;
        private int[] holder_V9s1;
        private int[] holder_V10s1;
        private int[] holder_V11s1;
        private int[] holder_V12s1;
        private bool napaka_pogi_ko;

        public Concert_Venue(string[] name_of_concert, string[] confirmname2)
        {
            InitializeComponent();
            instance = this;

        }

        public void mainvalue(int[] holder_B1c, int[] holder_B2c, int[] holder_B3c, int[] holder_B4c, int[] holder_B5c, int[] holder_B6c, int[] holder_B7c, int[] holder_B8c, int[] holder_A1c, int[] holder_A2c, int[] holder_A3c, int[] holder_A4c, int[] holder_A5c, int[] holder_A6c, int[] holder_A7c, int[] holder_A8c, int[] holder_A9c, int[] holder_A10c, int[] holder_A11c, int[] holder_A12c, int[] holder_A13c, int[] holder_A14c, int[] holder_A15c, int[] holder_A16c, int[] holder_V1c, int[] holder_V2c, int[] holder_V3c, int[] holder_V4c, int[] holder_V5c, int[] holder_V6c, int[] holder_V7c, int[] holder_V8c, int[] holder_V9c, int[] holder_V10c, int[] holder_V11c, int[] holder_V12c)
        {

            for (int i = 0; i <= 8; i++)
            {
                B1s[i] = holder_B1c[i];
                B2s[i] = holder_B2c[i];
                B3s[i] = holder_B3c[i];
                B4s[i] = holder_B4c[i];
                B5s[i] = holder_B5c[i];
                B6s[i] = holder_B6c[i];
                B7s[i] = holder_B7c[i];
                B8s[i] = holder_B8c[i];

                A1s[i] = holder_A1c[i];
                A2s[i] = holder_A2c[i];
                A3s[i] = holder_A3c[i];
                A4s[i] = holder_A4c[i];
                A5s[i] = holder_A5c[i];
                A6s[i] = holder_A6c[i];
                A7s[i] = holder_A7c[i];
                A8s[i] = holder_A8c[i];
                A9s[i] = holder_A9c[i];
                A10s[i] = holder_A10c[i];
                A11s[i] = holder_A11c[i];
                A12s[i] = holder_A12c[i];
                A13s[i] = holder_A13c[i];
                A14s[i] = holder_A14c[i];
                A15s[i] = holder_A15c[i];
                A16s[i] = holder_A16c[i];

                V1s[i] = holder_V1c[i];
                V2s[i] = holder_V2c[i];
                V3s[i] = holder_V3c[i];
                V4s[i] = holder_V4c[i];
                V5s[i] = holder_V5c[i];
                V6s[i] = holder_V6c[i];
                V7s[i] = holder_V7c[i];
                V8s[i] = holder_V8c[i];
                V9s[i] = holder_V9c[i];
                V10s[i] = holder_V10c[i];
                V11s[i] = holder_V11c[i];
                V12s[i] = holder_V12c[i];

                transfer_B1s1[i] = holder_B1c[i];
                transfer_B2s1[i] = holder_B2c[i];
                transfer_B3s1[i] = holder_B3c[i];
                transfer_B4s1[i] = holder_B4c[i];
                transfer_B5s1[i] = holder_B5c[i];
                transfer_B6s1[i] = holder_B6c[i];
                transfer_B7s1[i] = holder_B7c[i];
                transfer_B8s1[i] = holder_B8c[i];

                transfer_A1s1[i] = holder_A1c[i];
                transfer_A2s1[i] = holder_A2c[i];
                transfer_A3s1[i] = holder_A3c[i];
                transfer_A4s1[i] = holder_A4c[i];
                transfer_A5s1[i] = holder_A5c[i];
                transfer_A6s1[i] = holder_A6c[i];
                transfer_A7s1[i] = holder_A7c[i];
                transfer_A8s1[i] = holder_A8c[i];
                transfer_A9s1[i] = holder_A9c[i];
                transfer_A10s1[i] = holder_A10c[i];
                transfer_A11s1[i] = holder_A11c[i];
                transfer_A12s1[i] = holder_A12c[i];
                transfer_A13s1[i] = holder_A13c[i];
                transfer_A14s1[i] = holder_A14c[i];
                transfer_A15s1[i] = holder_A15c[i];
                transfer_A16s1[i] = holder_A16c[i];

                transfer_V1s1[i] = holder_V1c[i];
                transfer_V2s1[i] = holder_V2c[i];
                transfer_V3s1[i] = holder_V3c[i];
                transfer_V4s1[i] = holder_V4c[i];
                transfer_V5s1[i] = holder_V5c[i];
                transfer_V6s1[i] = holder_V6c[i];
                transfer_V7s1[i] = holder_V7c[i];
                transfer_V8s1[i] = holder_V8c[i];
                transfer_V9s1[i] = holder_V9c[i];
                transfer_V10s1[i] = holder_V10c[i];
                transfer_V11s1[i] = holder_V11c[i];
                transfer_V12s1[i] = holder_V12c[i];


            }


        }
        public void transfer()
        {
            for (int i = 0; i <= 8; i++)
            {
                transfer_B1s[i] = B1s[i];
                transfer_B2s[i] = B2s[i];
                transfer_B3s[i] = B3s[i];
                transfer_B4s[i] = B4s[i];
                transfer_B5s[i] = B5s[i];
                transfer_B6s[i] = B6s[i];
                transfer_B7s[i] = B7s[i];
                transfer_B8s[i] = B8s[i];

                transfer_A1s[i] = A1s[i];
                transfer_A2s[i] = A2s[i];
                transfer_A3s[i] = A3s[i];
                transfer_A4s[i] = A4s[i];
                transfer_A5s[i] = A5s[i];
                transfer_A6s[i] = A6s[i];
                transfer_A7s[i] = A7s[i];
                transfer_A8s[i] = A8s[i];
                transfer_A9s[i] = A9s[i];
                transfer_A10s[i] = A10s[i];
                transfer_A11s[i] = A11s[i];
                transfer_A12s[i] = A12s[i];
                transfer_A13s[i] = A13s[i];
                transfer_A14s[i] = A14s[i];
                transfer_A15s[i] = A15s[i];
                transfer_A16s[i] = A16s[i];

                transfer_V1s[i] = V1s[i];
                transfer_V2s[i] = V2s[i];
                transfer_V3s[i] = V3s[i];
                transfer_V4s[i] = V4s[i];
                transfer_V5s[i] = V5s[i];
                transfer_V6s[i] = V6s[i];
                transfer_V7s[i] = V7s[i];
                transfer_V8s[i] = V8s[i];
                transfer_V9s[i] = V9s[i];
                transfer_V10s[i] = V10s[i];
                transfer_V11s[i] = V11s[i];
                transfer_V12s[i] = V12s[i];

            }
        }

        public Concert_Venue(string[] name_of_concert, string[] confirmname2, bool addorder, string[] holder_seat, string[] holder_schedule, string[] holder_price, string[] holder_quantity, int holder_counter, int total_holder, int[] holder_B1s, int[] holder_B2s, int[] holder_B3s, int[] holder_B4s, int[] holder_B5s, int[] holder_B6s, int[] holder_B7s, int[] holder_B8s, int[] holder_A1s, int[] holder_A2s, int[] holder_A3s, int[] holder_A4s, int[] holder_A5s, int[] holder_A6s, int[] holder_A7s, int[] holder_A8s, int[] holder_A9s, int[] holder_A10s, int[] holder_A11s, int[] holder_A12s, int[] holder_A13s, int[] holder_A14s, int[] holder_A15s, int[] holder_A16s, int[] holder_V1s, int[] holder_V2s, int[] holder_V3s, int[] holder_V4s, int[] holder_V5s, int[] holder_V6s, int[] holder_V7s, int[] holder_V8s, int[] holder_V9s, int[] holder_V10s, int[] holder_V11s, int[] holder_V12s,
            int[] holder_B1c, int[] holder_B2c, int[] holder_B3c, int[] holder_B4c, int[] holder_B5c, int[] holder_B6c, int[] holder_B7c, int[] holder_B8c, int[] holder_A1c, int[] holder_A2c, int[] holder_A3c, int[] holder_A4c, int[] holder_A5c, int[] holder_A6c, int[] holder_A7c, int[] holder_A8c, int[] holder_A9c, int[] holder_A10c, int[] holder_A11c, int[] holder_A12c, int[] holder_A13c, int[] holder_A14c, int[] holder_A15c, int[] holder_A16c, int[] holder_V1c, int[] holder_V2c, int[] holder_V3c, int[] holder_V4c, int[] holder_V5c, int[] holder_V6c, int[] holder_V7c, int[] holder_V8c, int[] holder_V9c, int[] holder_V10c, int[] holder_V11c, int[] holder_V12c)
        {
            InitializeComponent();

            for (int i = 0; i <= 5; i++)
            {
                if (name_of_concert != null && i <= name_of_concert.Length)
                {
                    confirmtitle[i] = name_of_concert[i];

                }
            }
            comboBox1.Items.Clear();

            if (name_of_concert == null)
            {
                //add_container

                for (int i = 0; i <= 8; i++)
                {
                    B1s[i] = holder_B1s[i];
                    B2s[i] = holder_B2s[i];
                    B3s[i] = holder_B3s[i];
                    B4s[i] = holder_B4s[i];
                    B5s[i] = holder_B5s[i];
                    B6s[i] = holder_B6s[i];
                    B7s[i] = holder_B7s[i];
                    B8s[i] = holder_B8s[i];

                    A1s[i] = holder_A1s[i];
                    A2s[i] = holder_A2s[i];
                    A3s[i] = holder_A3s[i];
                    A4s[i] = holder_A4s[i];
                    A5s[i] = holder_A5s[i];
                    A6s[i] = holder_A6s[i];
                    A7s[i] = holder_A7s[i];
                    A8s[i] = holder_A8s[i];
                    A9s[i] = holder_A9s[i];
                    A10s[i] = holder_A10s[i];
                    A11s[i] = holder_A11s[i];
                    A12s[i] = holder_A12s[i];
                    A13s[i] = holder_A13s[i];
                    A14s[i] = holder_A14s[i];
                    A15s[i] = holder_A15s[i];
                    A16s[i] = holder_A16s[i];

                    V1s[i] = holder_V1s[i];
                    V2s[i] = holder_V2s[i];
                    V3s[i] = holder_V3s[i];
                    V4s[i] = holder_V4s[i];
                    V5s[i] = holder_V5s[i];
                    V6s[i] = holder_V6s[i];
                    V7s[i] = holder_V7s[i];
                    V8s[i] = holder_V8s[i];
                    V9s[i] = holder_V9s[i];
                    V10s[i] = holder_V10s[i];
                    V11s[i] = holder_V11s[i];
                    V12s[i] = holder_V12s[i];
                }

                bool pogi = true;

                int inr = 0;
                int fcku = 0;

                while (pogi)
                {

                    if (holder_seat[fcku] != null)
                    {

                        seatnames1[inr] = holder_seat[fcku];
                        datetime[inr] = holder_schedule[fcku];
                        price_seat[inr] = holder_price[fcku];
                        quantity[inr] = holder_quantity[fcku];

                        inr++;
                    }

                    fcku++;

                    if (fcku == 899)
                    {
                        break;
                    }

                }
                total = total_holder;

                counterholder = holder_counter;

                holder_addconcert = addorder;

                button40.Visible = false;
                ADD.Visible = true;
                button38.Visible = false;

                for (int i = 0; i <= 5; i++)
                {
                    if (confirmname2 != null && i <= confirmname2.Length)
                    {
                        confirmtitle[i] = confirmname2[i];
                    }

                }

                if (confirmname2[0] == "Bini")
                {
                    comboBox1.Items.Add("AUGUST 18, 8:00 PM");
                    comboBox1.Items.Add("AUGUST 19, 7:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 8500 Php");
                    listBox1.Items.Add("A.  SEATERS - 6000 Php");
                    listBox1.Items.Add("B.  SEATERS - 4000 Php");

                    b_amount = 4000;
                    a_amount = 6000;
                    v_amount = 8500;
                }
                else if (confirmname2[1] == "Parokya Ni Edgar")
                {
                    comboBox1.Items.Add("SEPTEMBER 22, 8:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 7500 Php");
                    listBox1.Items.Add("A.  SEATERS - 5000 Php");
                    listBox1.Items.Add("B.  SEATERS - 4000 Php");

                    b_amount = 4000;
                    a_amount = 5000;
                    v_amount = 7500;
                }
                else if (confirmname2[2] == "SB19")
                {
                    comboBox1.Items.Add("JANUARY 24, 7:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 9500 Php");
                    listBox1.Items.Add("A.  SEATERS - 8000 Php");
                    listBox1.Items.Add("B.  SEATERS - 7450 Php");

                    b_amount = 7450;
                    a_amount = 8000;
                    v_amount = 9500;
                }
                else if (confirmname2[3] == "Bruno Mars")
                {
                    comboBox1.Items.Add("MARCH 32, 6:00 PM");
                    comboBox1.Items.Add("NOVEMBER 11, 5:30 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 9500 Php");
                    listBox1.Items.Add("A.  SEATERS - 7038 Php");
                    listBox1.Items.Add("B.  SEATERS - 5750 Php");

                    b_amount = 5750;
                    a_amount = 7038;
                    v_amount = 9500;
                }
                else if (confirmname2[4] == "Taylor Swift")
                {
                    comboBox1.Items.Add("MARCH 30, 7:46 PM");
                    comboBox1.Items.Add("NOVEMBER 29, 8:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 12500 Php");
                    listBox1.Items.Add("A.  SEATERS - 10038 Php");
                    listBox1.Items.Add("B.  SEATERS - 8750 Php");

                    b_amount = 8750;
                    a_amount = 10038;
                    v_amount = 12500;
                }
                else if (confirmname2[5] == "Laufey")
                {
                    comboBox1.Items.Add("MAY 12, 6:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 10500 Php");
                    listBox1.Items.Add("A.  SEATERS - 9038 Php");
                    listBox1.Items.Add("B.  SEATERS - 7750 Php");

                    b_amount = 7750;
                    a_amount = 9038;
                    v_amount = 10500;
                }

            }
            else

            {

                mainvalue(holder_B1c, holder_B2c, holder_B3c, holder_B4c, holder_B5c, holder_B6c, holder_B7c, holder_B8c, holder_A1c, holder_A2c, holder_A3c, holder_A4c, holder_A5c, holder_A6c, holder_A7c, holder_A8c, holder_A9c, holder_A10c, holder_A11c, holder_A12c, holder_A13c, holder_A14c, holder_A15c, holder_A16c, holder_V1c, holder_V2c, holder_V3c, holder_V4c, holder_V5c, holder_V6c, holder_V7c, holder_V8c, holder_V9c, holder_V10c, holder_V11c, holder_V12c);
                if (name_of_concert[0] == "Bini")
                {
                    comboBox1.Items.Add("AUGUST 18, 8:00 PM");
                    comboBox1.Items.Add("AUGUST 19, 7:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 8500 Php");
                    listBox1.Items.Add("A.  SEATERS - 6000 Php");
                    listBox1.Items.Add("B.  SEATERS - 4000 Php");

                    b_amount = 4000;
                    a_amount = 6000;
                    v_amount = 8500;
                }
                else if (name_of_concert[1] == "Parokya Ni Edgar")
                {
                    comboBox1.Items.Add("SEPTEMBER 22, 8:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 7500 Php");
                    listBox1.Items.Add("A.  SEATERS - 5000 Php");
                    listBox1.Items.Add("B.  SEATERS - 4000 Php");

                    b_amount = 4000;
                    a_amount = 5000;
                    v_amount = 7500;
                }
                else if (name_of_concert[2] == "SB19")
                {
                    comboBox1.Items.Add("JANUARY 24, 7:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 9500 Php");
                    listBox1.Items.Add("A.  SEATERS - 8000 Php");
                    listBox1.Items.Add("B.  SEATERS - 7450 Php");

                    b_amount = 7450;
                    a_amount = 8000;
                    v_amount = 9500;
                }
                else if (name_of_concert[3] == "Bruno Mars")
                {
                    comboBox1.Items.Add("MARCH 32, 6:00 PM");
                    comboBox1.Items.Add("NOVEMBER 11, 5:30 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 9500 Php");
                    listBox1.Items.Add("A.  SEATERS - 7038 Php");
                    listBox1.Items.Add("B.  SEATERS - 5750 Php");

                    b_amount = 5750;
                    a_amount = 7038;
                    v_amount = 9500;
                }
                else if (name_of_concert[4] == "Taylor Swift")
                {
                    comboBox1.Items.Add("MARCH 30, 7:46 PM");
                    comboBox1.Items.Add("NOVEMBER 29, 8:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 12500 Php");
                    listBox1.Items.Add("A.  SEATERS - 10038 Php");
                    listBox1.Items.Add("B.  SEATERS - 8750 Php");

                    b_amount = 8750;
                    a_amount = 10038;
                    v_amount = 12500;

                }
                else if (name_of_concert[5] == "Laufey")
                {

                    comboBox1.Items.Add("MAY 12, 6:00 PM");

                    this.Controls.Add(comboBox1);

                    listBox1.Items.Add("VIP.  SEATERS - 10500 Php");
                    listBox1.Items.Add("A.  SEATERS - 9038 Php");
                    listBox1.Items.Add("B.  SEATERS - 7750 Php");

                    b_amount = 7750;
                    a_amount = 9038;
                    v_amount = 10500;

                }
            }

        }

        private void Concert_Venue_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void box1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box4_Load(object sender, EventArgs e)
        {

        }

        private void box8_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void box43_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void box44_Load(object sender, EventArgs e)
        {

        }

        private void box46_Load(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            concerts_tickets concerts_Tickets = new concerts_tickets(holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1,
                 holder_B1s1, holder_B2s1, holder_B3s1, holder_B4s1, holder_B5s1, holder_B6s1, holder_B7s1, holder_B8s1, holder_A1s1, holder_A2s1, holder_A3s1, holder_A4s1, holder_A5s1, holder_A6s1, holder_A7s1, holder_A8s1, holder_A9s1, holder_A10s1, holder_A11s1, holder_A12s1, holder_A13s1, holder_A14s1, holder_A15s1, holder_A16s1, holder_V1s1, holder_V2s1, holder_V3s1, holder_V4s1, holder_V5s1, holder_V6s1, holder_V7s1, holder_V8s1, holder_V9s1, holder_V10s1, holder_V11s1, holder_V12s1,
                 napaka_pogi_ko,
                 holder_B1c2, holder_B2c2, holder_B3c2, holder_B4c2, holder_B5c2, holder_B6c2, holder_B7c2, holder_B8c2, holder_A1c2, holder_A2c2, holder_A3c2, holder_A4c2, holder_A5c2, holder_A6c2, holder_A7c2, holder_A8c2, holder_A9c2, holder_A10c2, holder_A11c2, holder_A12c2, holder_A13c2, holder_A14c2, holder_A15c2, holder_A16c2, holder_V1c2, holder_V2c2, holder_V3c2, holder_V4c2, holder_V5c2, holder_V6c2, holder_V7c2, holder_V8c2, holder_V9c2, holder_V10c2, holder_V11c2, holder_V12c2);
            this.Hide();
            concerts_Tickets.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button40_Click(object sender, EventArgs e)
        {
            if (total == 0 || comformation == false || (comboBox1.Text != "AUGUST 18, 8:00 PM" && comboBox1.Text != "AUGUST 19, 7:00 PM" && comboBox1.Text != "SEPTEMBER 22, 8:00 PM" && comboBox1.Text != "JANUARY 24, 7:00 PM" && comboBox1.Text != "MARCH 32, 6:00 PM" && comboBox1.Text != "NOVEMBER 11, 5:30 PM" && comboBox1.Text != "MARCH 30, 7:46 PM" && comboBox1.Text != "NOVEMBER 29, 8:00 PM" && comboBox1.Text != "MAY 12, 6:00 PM" && comboBox1.Text != string.Empty))

            {
                if (comformation == false && (comboBox1.Text == "AUGUST 18, 8:00 PM" || comboBox1.Text == "AUGUST 19, 7:00 PM" || comboBox1.Text == "SEPTEMBER 22, 8:00 PM" || comboBox1.Text == "JANUARY 24, 7:00 PM" || comboBox1.Text == "MARCH 32, 6:00 PM" || comboBox1.Text == "NOVEMBER 11, 5:30 PM" || comboBox1.Text == "MARCH 30, 7:46 PM" || comboBox1.Text == "NOVEMBER 29, 8:00 PM" || comboBox1.Text == "MAY 12, 6:00 PM" || comboBox1.Text == string.Empty))
                {
                    MessageBox.Show("Please select seats first, and make sure you complete the confoirmation", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please select seats first, and make sure you complete the confoirmation", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                transfer();

                PAYMENT form = new PAYMENT(total, confirmtitle, datetime, price_seat, seatnames1, quantity, counterholder, transfer_B1s, transfer_B2s, transfer_B3s, transfer_B4s, transfer_B5s, transfer_B6s, transfer_B7s, transfer_B8s, transfer_A1s, transfer_A2s, transfer_A3s, transfer_A4s, transfer_A5s, transfer_A6s, transfer_A7s, transfer_A8s, transfer_A9s, transfer_A10s, transfer_A11s, transfer_A12s, transfer_A13s, transfer_A14s, transfer_A15s, transfer_A16s, transfer_V1s, transfer_V2s, transfer_V3s, transfer_V4s, transfer_V5s, transfer_V6s, transfer_V7s, transfer_V8s, transfer_V9s, transfer_V10s, transfer_V11s, transfer_V12s
                    , transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1);
                this.Hide();
                form.ShowDialog();
            }
        }


        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (A7.Checked)
            {
                seatnames[14] = "A7";
                comboBox3.Items.Add("A7");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[14] = string.Empty;
                comboBox3.Items.Remove("A7");
                this.Controls.Add(comboBox3);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (B1.Checked)
            {
                seatnames[0] = "B1";
                comboBox3.Items.Add("B1");
                this.Controls.Add(comboBox3);
            }
            else
            {


                seatnames[0] = string.Empty;
                comboBox3.Items.Remove("B1");
                this.Controls.Add(comboBox3);
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (V3.Checked)
            {
                seatnames[26] = "V3";
                comboBox3.Items.Add("V3");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[26] = string.Empty;
                comboBox3.Items.Remove("V3");
                this.Controls.Add(comboBox3);


            }
        }


        private void A6_CheckedChanged(object sender, EventArgs e)
        {
            if (A6.Checked)
            {
                seatnames[13] = "A6";
                comboBox3.Items.Add("A6");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[13] = string.Empty;
                comboBox3.Items.Remove("A6");
                this.Controls.Add(comboBox3);

            }
        }

        private void A12_CheckedChanged(object sender, EventArgs e)
        {
            if (A12.Checked)
            {
                seatnames[19] = "A12";
                comboBox3.Items.Add("A12");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[19] = string.Empty;
                comboBox3.Items.Remove("A12");
                this.Controls.Add(comboBox3);

            }
        }

        private void B2_CheckedChanged(object sender, EventArgs e)
        {
            if (B2.Checked)
            {
                seatnames[1] = "B2";
                comboBox3.Items.Add("B2");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[1] = string.Empty;
                comboBox3.Items.Remove("B2");
                this.Controls.Add(comboBox3);

            }
        }

        private void A1_CheckedChanged(object sender, EventArgs e)
        {

            if (A1.Checked)
            {
                seatnames[8] = "A1";
                comboBox3.Items.Add("A1");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[8] = string.Empty;
                comboBox3.Items.Remove("A1");
                this.Controls.Add(comboBox3);

            }

        }

        private void A2_CheckedChanged(object sender, EventArgs e)
        {
            if (A2.Checked)
            {
                seatnames[9] = "A2";
                comboBox3.Items.Add("A2");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[9] = string.Empty;
                comboBox3.Items.Remove("A2");
                this.Controls.Add(comboBox3);

            }
        }

        private void A3_CheckedChanged(object sender, EventArgs e)
        {
            if (A3.Checked)
            {
                seatnames[10] = "A3";
                comboBox3.Items.Add("A3");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[10] = string.Empty;
                comboBox3.Items.Remove("A3");
                this.Controls.Add(comboBox3);

            }
        }

        private void A4_CheckedChanged(object sender, EventArgs e)
        {
            if (A4.Checked)
            {
                seatnames[11] = "A4";
                comboBox3.Items.Add("A4");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[11] = string.Empty;
                comboBox3.Items.Remove("A4");
                this.Controls.Add(comboBox3);

            }
        }

        private void A5_CheckedChanged(object sender, EventArgs e)
        {
            if (A5.Checked)
            {
                seatnames[12] = "A5";
                comboBox3.Items.Add("A5");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[12] = string.Empty;
                comboBox3.Items.Remove("A5");
                this.Controls.Add(comboBox3);

            }
        }

        private void A8_CheckedChanged(object sender, EventArgs e)
        {
            if (A8.Checked)
            {
                seatnames[15] = "A8";
                comboBox3.Items.Add("A8");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[15] = string.Empty;
                comboBox3.Items.Remove("A8");
                this.Controls.Add(comboBox3);

            }
        }

        private void A9_CheckedChanged(object sender, EventArgs e)
        {
            if (A9.Checked)
            {
                seatnames[16] = "A9";
                comboBox3.Items.Add("A9");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[16] = string.Empty;
                comboBox3.Items.Remove("A9");
                this.Controls.Add(comboBox3);

            }
        }

        private void A10_CheckedChanged(object sender, EventArgs e)
        {
            if (A10.Checked)
            {
                seatnames[17] = "A10";
                comboBox3.Items.Add("A10");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[17] = string.Empty;
                comboBox3.Items.Remove("A10");
                this.Controls.Add(comboBox3);

            }
        }

        private void A11_CheckedChanged(object sender, EventArgs e)
        {
            if (A11.Checked)
            {
                seatnames[18] = "A11";
                comboBox3.Items.Add("A11");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[18] = string.Empty;
                comboBox3.Items.Remove("A11");
                this.Controls.Add(comboBox3);

            }
        }

        private void box9_Load(object sender, EventArgs e)
        {

        }

        private void A13_CheckedChanged(object sender, EventArgs e)
        {
            if (A13.Checked)
            {
                seatnames[20] = "A13";
                comboBox3.Items.Add("A13");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[20] = string.Empty;
                comboBox3.Items.Remove("A13");
                this.Controls.Add(comboBox3);

            }
        }

        private void A14_CheckedChanged(object sender, EventArgs e)
        {
            if (A14.Checked)
            {
                seatnames[21] = "A14";
                comboBox3.Items.Add("A14");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[21] = string.Empty;
                comboBox3.Items.Remove("A14");
                this.Controls.Add(comboBox3);

            }
        }

        private void A15_CheckedChanged(object sender, EventArgs e)
        {
            if (A15.Checked)
            {
                seatnames[22] = "A15";
                comboBox3.Items.Add("A15");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[22] = string.Empty;
                comboBox3.Items.Remove("A15");
                this.Controls.Add(comboBox3);

            }
        }

        private void A16_CheckedChanged(object sender, EventArgs e)
        {
            if (A16.Checked)
            {
                seatnames[23] = "A16";
                comboBox3.Items.Add("A16");
                this.Controls.Add(comboBox3);
            }
            else
            {
                seatnames[23] = string.Empty;
                comboBox3.Items.Remove("A16");
                this.Controls.Add(comboBox3);

            }
        }

        private void B3_CheckedChanged(object sender, EventArgs e)
        {
            if (B3.Checked)
            {
                seatnames[2] = "B3";
                comboBox3.Items.Add("B3");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[2] = string.Empty;
                comboBox3.Items.Remove("B3");
                this.Controls.Add(comboBox3);

            }
        }

        private void B4_CheckedChanged(object sender, EventArgs e)
        {
            if (B4.Checked)
            {
                seatnames[3] = "B4";
                comboBox3.Items.Add("B4");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[3] = string.Empty;
                comboBox3.Items.Remove("B4");
                this.Controls.Add(comboBox3);

            }
        }

        private void B5_CheckedChanged(object sender, EventArgs e)
        {
            if (B5.Checked)
            {
                seatnames[4] = "B5";
                comboBox3.Items.Add("B5");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[4] = string.Empty;
                comboBox3.Items.Remove("B5");
                this.Controls.Add(comboBox3);

            }
        }

        private void B6_CheckedChanged(object sender, EventArgs e)
        {
            if (B6.Checked)
            {
                seatnames[5] = "B6";
                comboBox3.Items.Add("B6");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[5] = string.Empty;
                comboBox3.Items.Remove("B6");
                this.Controls.Add(comboBox3);

            }
        }

        private void B7_CheckedChanged(object sender, EventArgs e)
        {
            if (B7.Checked)
            {
                seatnames[6] = "B7";
                comboBox3.Items.Add("B7");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[6] = string.Empty;
                comboBox3.Items.Remove("B7");
                this.Controls.Add(comboBox3);

            }
        }

        private void B8_CheckedChanged(object sender, EventArgs e)
        {
            if (B8.Checked)
            {
                seatnames[7] = "B8";
                comboBox3.Items.Add("B8");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[7] = string.Empty;
                comboBox3.Items.Remove("B8");
                this.Controls.Add(comboBox3);

            }
        }

        private void V1_CheckedChanged(object sender, EventArgs e)
        {


            if (V1.Checked)
            {
                seatnames[24] = "V1";
                comboBox3.Items.Add("V1");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[24] = string.Empty;
                comboBox3.Items.Remove("V1");
                this.Controls.Add(comboBox3);

            }
        }

        private void V2_CheckedChanged(object sender, EventArgs e)
        {
            if (V2.Checked)
            {
                seatnames[25] = "V2";
                comboBox3.Items.Add("V2");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[25] = string.Empty;
                comboBox3.Items.Remove("V2");
                this.Controls.Add(comboBox3);

            }

        }

        private void V4_CheckedChanged(object sender, EventArgs e)
        {
            if (V4.Checked)
            {
                seatnames[27] = "V4";
                comboBox3.Items.Add("V4");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[27] = string.Empty;
                comboBox3.Items.Remove("V4");
                this.Controls.Add(comboBox3);

            }
        }

        private void V5_CheckedChanged(object sender, EventArgs e)
        {
            if (V5.Checked)
            {
                seatnames[28] = "V5";
                comboBox3.Items.Add("V5");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[28] = string.Empty;
                comboBox3.Items.Remove("V5");
                this.Controls.Add(comboBox3);

            }
        }

        private void V6_CheckedChanged(object sender, EventArgs e)
        {
            if (V6.Checked)
            {
                seatnames[29] = "V6";
                comboBox3.Items.Add("V6");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[29] = string.Empty;
                comboBox3.Items.Remove("V6");
                this.Controls.Add(comboBox3);

            }
        }

        private void V7_CheckedChanged(object sender, EventArgs e)
        {
            if (V7.Checked)
            {
                seatnames[30] = "V7";
                comboBox3.Items.Add("V7");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[30] = string.Empty;
                comboBox3.Items.Remove("V7");
                this.Controls.Add(comboBox3);

            }
        }

        private void V8_CheckedChanged(object sender, EventArgs e)
        {
            if (V8.Checked)
            {
                seatnames[31] = "V8";
                comboBox3.Items.Add("V8");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[31] = string.Empty;
                comboBox3.Items.Remove("V8");
                this.Controls.Add(comboBox3);

            }
        }

        private void V9_CheckedChanged(object sender, EventArgs e)
        {
            if (V9.Checked)
            {
                seatnames[32] = "V9";
                comboBox3.Items.Add("V9");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[32] = string.Empty;
                comboBox3.Items.Remove("V9");
                this.Controls.Add(comboBox3);

            }
        }

        private void V10_CheckedChanged(object sender, EventArgs e)
        {
            if (V10.Checked)
            {
                seatnames[33] = "V10";
                comboBox3.Items.Add("V10");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[33] = string.Empty;
                comboBox3.Items.Remove("V10");
                this.Controls.Add(comboBox3);
            }
        }

        private void V11_CheckedChanged(object sender, EventArgs e)
        {
            if (V11.Checked)
            {
                seatnames[34] = "V11";
                comboBox3.Items.Add("V11");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[34] = string.Empty;
                comboBox3.Items.Remove("V11");
                this.Controls.Add(comboBox3);

            }
        }

        private void V12_CheckedChanged(object sender, EventArgs e)
        {
            if (V12.Checked)
            {
                seatnames[35] = "V12";
                comboBox3.Items.Add("V12");
                this.Controls.Add(comboBox3);

            }
            else
            {
                seatnames[35] = string.Empty;
                comboBox3.Items.Remove("V12");
                this.Controls.Add(comboBox3);

            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void condition_seatavailable()
        {


            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();

                //B SECTIONS

                for (int i = 0; i < B1s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }


                // A SECTIONS


                for (int i = 0; i < A1s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[0]; i++)
                {

                    if (i! <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[0]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();

                //B SECTIONS

                for (int i = 0; i < B1s[1]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }

                // A SECTIONS

                for (int i = 0; i < A1s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
            else if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();

                // B SECTIONS

                for (int i = 0; i < B1s[2]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[2]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }
                // A SECTIONS

                for (int i = 0; i < A1s[2]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[2]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[2]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[2]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[2]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }
            }
            else if (comboBox1.Text == "JANUARY 24, 7:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[3]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }
                // A SECTIONS

                for (int i = 0; i < A1s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[3]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[3]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
            else if (comboBox1.Text == "MARCH 32, 6:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[4]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }

                // A SECTIONS

                for (int i = 0; i < A1s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[4]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[4]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[5]; i++)
                {
                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[1]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }

                // A SECTIONS

                for (int i = 0; i < A1s[5]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[5]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[5]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[5]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[5]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }


            }
            else if (comboBox1.Text == "MARCH 30, 7:46 PM")
            {

                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[6]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }

                // A SECTIONS

                for (int i = 0; i < A1s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[6]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[6]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[7]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }
                // A SECTIONS

                for (int i = 0; i < A1s[7]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[7]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[7]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[7]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[7]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }


            }
            else if (comboBox1.Text == "MAY 12, 6:00 PM")
            {
                dataGridView1.Rows.Clear();
                listofseats();
                for (int i = 0; i < B1s[8]; i++)
                {

                    if (i <= 14)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B2s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B3s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B4s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B5s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B6s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B7s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = string.Empty;
                    }
                }
                for (int i = 0; i < B8s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = string.Empty;
                    }
                }
                // A SECTIONS

                for (int i = 0; i < A1s[8]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A2s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A3s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[10].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A4s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[11].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A5s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[12].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A6s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[13].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A7s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[14].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A8s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[15].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A9s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[16].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A10s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[17].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A11s[8]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[18].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A12s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[19].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A13s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[20].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A14s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[21].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A15s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[22].Value = string.Empty;
                    }
                }
                for (int i = 0; i < A16s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[23].Value = string.Empty;
                    }
                }

                //V SECTIONS

                for (int i = 0; i < V1s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[24].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V2s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[25].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V3s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[26].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V4s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[27].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V5s[8]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[28].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V6s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[29].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V7s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[30].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V8s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[31].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V9s[8]; i++)
                {
                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[32].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V10s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[33].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V11s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[34].Value = string.Empty;
                    }
                }
                for (int i = 0; i < V12s[8]; i++)
                {

                    if (i <= 14)
                    {
                        dataGridView1.Rows[i].Cells[35].Value = string.Empty;
                    }
                }

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            condition_seatavailable();
        }

        private void box42_Load(object sender, EventArgs e)
        {
        }
        public void to_datagrid()
        {
            date_time = comboBox1.Text;
            seatsnames = comboBox3.Text;

            //to datagrid

            seatnames1_holder[counterholder] = seatsnames;
            price_seat_holder[counterholder] = Convert.ToString(seat_amountholder);
            datetime_holder[counterholder] = date_time;
            quantity_holder[counterholder] = textBox1.Text;

            seatnames1[counterholder] = seatnames1_holder[counterholder];
            price_seat[counterholder] = price_seat_holder[counterholder];
            datetime[counterholder] = datetime_holder[counterholder];
            quantity[counterholder] = quantity_holder[counterholder];

            counterholder++;

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void box11_Load(object sender, EventArgs e)
        {

        }

        private void box22_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
            }
            else
            {
                listBox1.Visible = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {

            transfer();

            PAYMENT pAYMENT = new PAYMENT(total, confirmtitle, datetime, price_seat, seatnames1, quantity, counterholder, transfer_B1s, transfer_B2s, transfer_B3s, transfer_B4s, transfer_B5s, transfer_B6s, transfer_B7s, transfer_B8s, transfer_A1s, transfer_A2s, transfer_A3s, transfer_A4s, transfer_A5s, transfer_A6s, transfer_A7s, transfer_A8s, transfer_A9s, transfer_A10s, transfer_A11s, transfer_A12s, transfer_A13s, transfer_A14s, transfer_A15s, transfer_A16s, transfer_V1s, transfer_V2s, transfer_V3s, transfer_V4s, transfer_V5s, transfer_V6s, transfer_V7s, transfer_V8s, transfer_V9s, transfer_V10s, transfer_V11s, transfer_V12s
                , transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1);
            this.Hide();
            pAYMENT.ShowDialog();

        }
        public void listofseats()
        {
            dataGridView1.Rows.Add("Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1", "Seat 1");
            dataGridView1.Rows.Add("Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2", "Seat 2");
            dataGridView1.Rows.Add("Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3", "Seat 3");
            dataGridView1.Rows.Add("Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4", "Seat 4");
            dataGridView1.Rows.Add("Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5", "Seat 5");
            dataGridView1.Rows.Add("Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6", "Seat 6");
            dataGridView1.Rows.Add("Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7", "Seat 7");
            dataGridView1.Rows.Add("Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8", "Seat 8");
            dataGridView1.Rows.Add("Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9", "Seat 9");
            dataGridView1.Rows.Add("Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10", "Seat 10");
            dataGridView1.Rows.Add("Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11", "Seat 11");
            dataGridView1.Rows.Add("Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12", "Seat 12");
            dataGridView1.Rows.Add("Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13", "Seat 13");
            dataGridView1.Rows.Add("Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14", "Seat 14");
            dataGridView1.Rows.Add("Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15", "Seat 15");

        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            //controling panel
            if (panel1.Visible == false)
            {

                panel1.Visible = true;

            }
            else
            {
                panel1.Visible = false;
            }


        }
        private void box17_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                textBox1.Text = string.Empty;

            }
            else
            {
                if (int.Parse(textBox1.Text) > MAX_VALUE)
                {
                    textBox1.Text = Convert.ToString(MAX_VALUE);
                }
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                textBox1.MaxLength = 2;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void box47_Load(object sender, EventArgs e)
        {

        }

        private void box4_Load_1(object sender, EventArgs e)
        {

        }

        private void seats2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null || (comboBox1.Text != "AUGUST 18, 8:00 PM" && comboBox1.Text != "AUGUST 19, 7:00 PM" && comboBox1.Text != "SEPTEMBER 22, 8:00 PM" && comboBox1.Text != "JANUARY 24, 7:00 PM" && comboBox1.Text != "MARCH 32, 6:00 PM" && comboBox1.Text != "NOVEMBER 11, 5:30 PM" && comboBox1.Text != "MARCH 30, 7:46 PM" && comboBox1.Text != "NOVEMBER 29, 8:00 PM" && comboBox1.Text != "MAY 12, 6:00 PM") || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select seats for Date And Time", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                if (textBox1.Text == "0")
                {

                    MessageBox.Show("Please Enter a quantity for the tickets", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {


                    //B1   

                    if (B1.Checked && comboBox3.Text == seatnames[0])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B1s[0] += Convert.ToInt32(textBox1.Text);
                                if (B1s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount;
                                    to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    B1s[0] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B1s[1] += Convert.ToInt32(textBox1.Text);
                                if (B1s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount;
                                    to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    B1s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B1s[2] += Convert.ToInt32(textBox1.Text);
                                if (B1s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount;
                                    to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    B1s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B1s[3] += Convert.ToInt32(textBox1.Text);
                                if (B1s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B1s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B1s[4] += Convert.ToInt32(textBox1.Text);
                                if (B1s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B1s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B1s[5] += Convert.ToInt32(textBox1.Text);
                                if (B1s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B1s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {

                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B1s[6] += Convert.ToInt32(textBox1.Text);
                                if (B1s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B1s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B1s[7] += Convert.ToInt32(textBox1.Text);
                                if (B1s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    B1s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B1s[8] += Convert.ToInt32(textBox1.Text);
                                if (B1s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B1s[8] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }

                        B1.Checked = false;
                    }

                    //B2    
                    else if (B2.Checked && comboBox3.Text == seatnames[1])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B2s[0] += Convert.ToInt32(textBox1.Text);
                                if (B2s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B2s[1] += Convert.ToInt32(textBox1.Text);
                                if (B2s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B2s[2] += Convert.ToInt32(textBox1.Text);
                                if (B2s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B2s[3] += Convert.ToInt32(textBox1.Text);
                                if (B2s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B2s[4] += Convert.ToInt32(textBox1.Text);
                                if (B2s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[4] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B2s[5] += Convert.ToInt32(textBox1.Text);
                                if (B2s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {

                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B2s[6] += Convert.ToInt32(textBox1.Text);
                                if (B2s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B2s[7] += Convert.ToInt32(textBox1.Text);
                                if (B2s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[7] -= Convert.ToInt32(textBox1.Text);

                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B2s[8] += Convert.ToInt32(textBox1.Text);
                                if (B2s[8] <= 15)
                                {

                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B2s[8] -= Convert.ToInt32(textBox1.Text);

                                }

                            }

                        }

                        B2.Checked = false;
                    }
                    //B3    

                    else if (B3.Checked && comboBox3.Text == seatnames[2])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B3s[0] += Convert.ToInt32(textBox1.Text);
                                if (B3s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B3s[1] += Convert.ToInt32(textBox1.Text);
                                if (B3s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {
                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B3s[2] += Convert.ToInt32(textBox1.Text);
                                if (B3s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B3s[3] += Convert.ToInt32(textBox1.Text);
                                if (B3s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B3s[4] += Convert.ToInt32(textBox1.Text);
                                if (B3s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[4] -= Convert.ToInt32(textBox1.Text);

                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B3s[5] += Convert.ToInt32(textBox1.Text);
                                if (B3s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {

                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B3s[6] += Convert.ToInt32(textBox1.Text);
                                if (B3s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B3s[7] += Convert.ToInt32(textBox1.Text);
                                if (B3s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B3s[8] += Convert.ToInt32(textBox1.Text);
                                if (B3s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B3s[8] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }

                        B3.Checked = false;
                    }

                    //B4
                    else if (B4.Checked && comboBox3.Text == seatnames[3])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B4s[0] += Convert.ToInt32(textBox1.Text);
                                if (B4s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B4s[1] += Convert.ToInt32(textBox1.Text);
                                if (B4s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B4s[2] += Convert.ToInt32(textBox1.Text);
                                if (B4s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B4s[3] += Convert.ToInt32(textBox1.Text);
                                if (B4s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B4s[4] += Convert.ToInt32(textBox1.Text);
                                if (B4s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B4s[5] += Convert.ToInt32(textBox1.Text);
                                if (B4s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B4s[6] += Convert.ToInt32(textBox1.Text);
                                if (B4s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B4s[7] += Convert.ToInt32(textBox1.Text);
                                if (B4s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B4s[8] += Convert.ToInt32(textBox1.Text);
                                if (B4s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B4s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }

                        B4.Checked = false;
                    }

                    //B5

                    else if (B5.Checked && comboBox3.Text == seatnames[4])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B5s[0] += Convert.ToInt32(textBox1.Text);
                                if (B5s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B5s[1] += Convert.ToInt32(textBox1.Text);
                                if (B5s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B5s[2] += Convert.ToInt32(textBox1.Text);
                                if (B5s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    B5s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B5s[3] += Convert.ToInt32(textBox1.Text);
                                if (B5s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B5s[4] += Convert.ToInt32(textBox1.Text);
                                if (B5s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B5s[5] += Convert.ToInt32(textBox1.Text);
                                if (B5s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B5s[6] += Convert.ToInt32(textBox1.Text);
                                if (B5s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[6] -= Convert.ToInt32(textBox1.Text);

                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B5s[7] += Convert.ToInt32(textBox1.Text);
                                if (B5s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B5s[8] += Convert.ToInt32(textBox1.Text);
                                if (B5s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B5s[8] -= Convert.ToInt32(textBox1.Text);

                                }
                            }

                        }


                        B5.Checked = false;
                    }

                    //B6
                    else if (B6.Checked && comboBox3.Text == seatnames[5])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B6s[0] += Convert.ToInt32(textBox1.Text);
                                if (B6s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B6s[1] += Convert.ToInt32(textBox1.Text);
                                if (B6s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B6s[2] += Convert.ToInt32(textBox1.Text);
                                if (B6s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B6s[3] += Convert.ToInt32(textBox1.Text);
                                if (B6s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B6s[4] += Convert.ToInt32(textBox1.Text);
                                if (B6s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B6s[5] += Convert.ToInt32(textBox1.Text);
                                if (B6s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B6s[6] += Convert.ToInt32(textBox1.Text);
                                if (B6s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B6s[7] += Convert.ToInt32(textBox1.Text);
                                if (B6s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B6s[8] += Convert.ToInt32(textBox1.Text);
                                if (B6s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B6s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        B6.Checked = false;
                    }

                    //B7
                    else if (B7.Checked && comboBox3.Text == seatnames[6])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B7s[0] += Convert.ToInt32(textBox1.Text);
                                if (B7s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {

                                B7s[1] += Convert.ToInt32(textBox1.Text);
                                if (B7s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B7s[2] += Convert.ToInt32(textBox1.Text);

                                if (B7s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B7s[3] += Convert.ToInt32(textBox1.Text);

                                if (B7s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {

                                B7s[4] += Convert.ToInt32(textBox1.Text);
                                if (B7s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[4] -= Convert.ToInt32(textBox1.Text);

                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {

                                B7s[5] += Convert.ToInt32(textBox1.Text);
                                if (B7s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B7s[6] += Convert.ToInt32(textBox1.Text);

                                if (B7s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {

                                B7s[7] += Convert.ToInt32(textBox1.Text);
                                if (B7s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B7s[8] += Convert.ToInt32(textBox1.Text);

                                if (B7s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B7s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }

                        B7.Checked = false;
                    }

                    //B8
                    else if (B8.Checked && comboBox3.Text == seatnames[7])
                    {

                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                B8s[0] += Convert.ToInt32(textBox1.Text);
                                if (B8s[0] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                B8s[1] += Convert.ToInt32(textBox1.Text);
                                if (B8s[1] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                B8s[2] += Convert.ToInt32(textBox1.Text);
                                if (B8s[2] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                B8s[3] += Convert.ToInt32(textBox1.Text);
                                if (B8s[3] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                B8s[4] += Convert.ToInt32(textBox1.Text);
                                if (B8s[4] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                B8s[5] += Convert.ToInt32(textBox1.Text);
                                if (B8s[5] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                B8s[6] += Convert.ToInt32(textBox1.Text);
                                if (B8s[6] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                B8s[7] += Convert.ToInt32(textBox1.Text);
                                if (B8s[7] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                B8s[8] += Convert.ToInt32(textBox1.Text);
                                if (B8s[8] <= 15)
                                {
                                    seat_amountholder = b_amount;
                                    total += Convert.ToInt32(textBox1.Text) * b_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    B8s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }

                        B8.Checked = false;
                    }

                    //A1
                    else if (A1.Checked && comboBox3.Text == seatnames[8])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A1s[0] += Convert.ToInt32(textBox1.Text);
                                if (A1s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A1s[1] += Convert.ToInt32(textBox1.Text);
                                if (A1s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A1s[2] += Convert.ToInt32(textBox1.Text);
                                if (A1s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A1s[3] += Convert.ToInt32(textBox1.Text);
                                if (A1s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A1s[4] += Convert.ToInt32(textBox1.Text);
                                if (A1s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A1s[5] += Convert.ToInt32(textBox1.Text);
                                if (A1s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A1s[6] += Convert.ToInt32(textBox1.Text);
                                if (A1s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A1s[7] += Convert.ToInt32(textBox1.Text);
                                if (A1s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A1s[8] += Convert.ToInt32(textBox1.Text);
                                if (A1s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A1s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }


                        A1.Checked = false;
                    }

                    //A2
                    else if (A2.Checked && comboBox3.Text == seatnames[9])
                    {

                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A2s[0] += Convert.ToInt32(textBox1.Text);
                                if (A2s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A2s[1] += Convert.ToInt32(textBox1.Text);
                                if (A2s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A2s[2] += Convert.ToInt32(textBox1.Text);
                                if (A2s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A2s[3] += Convert.ToInt32(textBox1.Text);
                                if (A2s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A2s[4] += Convert.ToInt32(textBox1.Text);
                                if (A2s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A2s[5] += Convert.ToInt32(textBox1.Text);
                                if (A2s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A2s[6] += Convert.ToInt32(textBox1.Text);
                                if (A2s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A2s[7] += Convert.ToInt32(textBox1.Text);
                                if (A2s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A2s[8] += Convert.ToInt32(textBox1.Text);
                                if (A2s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A2s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }

                        A2.Checked = false;
                    }

                    //A3
                    else if (A3.Checked && comboBox3.Text == seatnames[10])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A3s[0] += Convert.ToInt32(textBox1.Text);
                                if (A3s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A3s[1] += Convert.ToInt32(textBox1.Text);
                                if (A3s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A3s[2] += Convert.ToInt32(textBox1.Text);
                                if (A3s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A3s[3] += Convert.ToInt32(textBox1.Text);
                                if (A3s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A3s[4] += Convert.ToInt32(textBox1.Text);
                                if (A3s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A3s[5] += Convert.ToInt32(textBox1.Text);
                                if (A3s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A3s[6] += Convert.ToInt32(textBox1.Text);
                                if (A3s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A3s[7] += Convert.ToInt32(textBox1.Text);
                                if (A3s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A3s[8] += Convert.ToInt32(textBox1.Text);
                                if (A3s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A3s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }

                        A3.Checked = false;
                    }

                    //A4
                    else if (A4.Checked && comboBox3.Text == seatnames[11])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A4s[0] += Convert.ToInt32(textBox1.Text);
                                if (A4s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A4s[1] += Convert.ToInt32(textBox1.Text);
                                if (A4s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A4s[2] += Convert.ToInt32(textBox1.Text);
                                if (A4s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A4s[3] += Convert.ToInt32(textBox1.Text);
                                if (A4s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A4s[4] += Convert.ToInt32(textBox1.Text);
                                if (A4s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A4s[5] += Convert.ToInt32(textBox1.Text);
                                if (A4s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A4s[6] += Convert.ToInt32(textBox1.Text);
                                if (A4s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A4s[7] += Convert.ToInt32(textBox1.Text);
                                if (A4s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A4s[8] += Convert.ToInt32(textBox1.Text);
                                if (A4s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A4s[8] -= Convert.ToInt32(textBox1.Text);

                                }
                            }

                        }

                        A4.Checked = false;
                    }

                    //A5
                    else if (A5.Checked && comboBox3.Text == seatnames[12])
                    {

                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A5s[0] += Convert.ToInt32(textBox1.Text);
                                if (A5s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A5s[1] += Convert.ToInt32(textBox1.Text);
                                if (A5s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A5s[2] += Convert.ToInt32(textBox1.Text);
                                if (A5s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A5s[3] += Convert.ToInt32(textBox1.Text);
                                if (A5s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A5s[4] += Convert.ToInt32(textBox1.Text);
                                if (A5s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A5s[5] += Convert.ToInt32(textBox1.Text);
                                if (A5s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A5s[6] += Convert.ToInt32(textBox1.Text);
                                if (A5s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A5s[7] += Convert.ToInt32(textBox1.Text);
                                if (A5s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A5s[8] += Convert.ToInt32(textBox1.Text);
                                if (A5s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A5s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }

                        A5.Checked = false;
                    }

                    //A6
                    else if (A6.Checked && comboBox3.Text == seatnames[13])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A6s[0] += Convert.ToInt32(textBox1.Text);
                                if (A6s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A6s[1] += Convert.ToInt32(textBox1.Text);
                                if (A6s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    A6s[1] -= Convert.ToInt32(textBox1.Text);

                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A6s[2] += Convert.ToInt32(textBox1.Text);
                                if (A6s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A6s[3] += Convert.ToInt32(textBox1.Text);
                                if (A6s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A6s[4] += Convert.ToInt32(textBox1.Text);
                                if (A6s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A6s[5] += Convert.ToInt32(textBox1.Text);
                                if (A6s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A6s[6] += Convert.ToInt32(textBox1.Text);
                                if (A6s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A6s[7] += Convert.ToInt32(textBox1.Text);
                                if (A6s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A6s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A6s[8] += Convert.ToInt32(textBox1.Text);
                                if (A6s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                                    A6s[8] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        A6.Checked = false;
                    }

                    //A7
                    else if (A7.Checked && comboBox3.Text == seatnames[14])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A7s[0] += Convert.ToInt32(textBox1.Text);
                                if (A7s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A7s[1] += Convert.ToInt32(textBox1.Text);
                                if (A7s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A7s[2] += Convert.ToInt32(textBox1.Text);
                                if (A7s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A7s[3] += Convert.ToInt32(textBox1.Text);
                                if (A7s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A7s[4] += Convert.ToInt32(textBox1.Text);
                                if (A7s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A7s[5] += Convert.ToInt32(textBox1.Text);
                                if (A7s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A7s[6] += Convert.ToInt32(textBox1.Text);
                                if (A7s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[6] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A7s[7] += Convert.ToInt32(textBox1.Text);
                                if (A7s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A7s[8] += Convert.ToInt32(textBox1.Text);
                                if (A7s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A7s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        A7.Checked = false;
                    }

                    //A8
                    else if (A8.Checked && comboBox3.Text == seatnames[15])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A8s[0] += Convert.ToInt32(textBox1.Text);
                                if (A8s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A8s[1] += Convert.ToInt32(textBox1.Text);
                                if (A8s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A8s[2] += Convert.ToInt32(textBox1.Text);
                                if (A8s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A8s[3] += Convert.ToInt32(textBox1.Text);
                                if (A8s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A8s[4] += Convert.ToInt32(textBox1.Text);
                                if (A8s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A8s[5] += Convert.ToInt32(textBox1.Text);
                                if (A8s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A8s[6] += Convert.ToInt32(textBox1.Text);
                                if (A8s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A8s[7] += Convert.ToInt32(textBox1.Text);
                                if (A8s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A8s[8] += Convert.ToInt32(textBox1.Text);
                                if (A8s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A8s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        A8.Checked = false;

                    }

                    //A9
                    else if (A9.Checked && comboBox3.Text == seatnames[16])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A9s[0] += Convert.ToInt32(textBox1.Text);
                                if (A9s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A9s[1] += Convert.ToInt32(textBox1.Text);
                                if (A9s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A9s[2] += Convert.ToInt32(textBox1.Text);
                                if (A9s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A9s[3] += Convert.ToInt32(textBox1.Text);
                                if (A9s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A9s[4] += Convert.ToInt32(textBox1.Text);
                                if (A9s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A9s[5] += Convert.ToInt32(textBox1.Text);
                                if (A9s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A9s[6] += Convert.ToInt32(textBox1.Text);
                                if (A9s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A9s[7] += Convert.ToInt32(textBox1.Text);
                                if (A9s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A9s[8] += Convert.ToInt32(textBox1.Text);
                                if (A9s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A9s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        A9.Checked = false;
                    }

                    //A10
                    else if (A10.Checked && comboBox3.Text == seatnames[17])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A10s[0] += Convert.ToInt32(textBox1.Text);
                                if (A10s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A10s[1] += Convert.ToInt32(textBox1.Text);
                                if (A10s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A10s[2] += Convert.ToInt32(textBox1.Text);
                                if (A10s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A10s[3] += Convert.ToInt32(textBox1.Text);
                                if (A10s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    A10s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A10s[4] += Convert.ToInt32(textBox1.Text);
                                if (A10s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A10s[5] += Convert.ToInt32(textBox1.Text);
                                if (A10s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A10s[6] += Convert.ToInt32(textBox1.Text);
                                if (A10s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A10s[7] += Convert.ToInt32(textBox1.Text);
                                if (A10s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                                    A10s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A10s[8] += Convert.ToInt32(textBox1.Text);
                                if (A10s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A10s[8] -= Convert.ToInt32(textBox1.Text);

                                }

                            }

                        }
                        A10.Checked = false;
                    }

                    //A11
                    else if (A11.Checked && comboBox3.Text == seatnames[18])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A11s[0] += Convert.ToInt32(textBox1.Text);
                                if (A11s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A11s[1] += Convert.ToInt32(textBox1.Text);
                                if (A11s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A11s[2] += Convert.ToInt32(textBox1.Text);
                                if (A11s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A11s[3] += Convert.ToInt32(textBox1.Text);
                                if (A11s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A11s[4] += Convert.ToInt32(textBox1.Text);
                                if (A11s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A11s[5] += Convert.ToInt32(textBox1.Text);
                                if (A11s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A11s[6] += Convert.ToInt32(textBox1.Text);
                                if (A11s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A11s[7] += Convert.ToInt32(textBox1.Text);
                                if (A11s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A11s[8] += Convert.ToInt32(textBox1.Text);
                                if (A11s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A11s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        A11.Checked = false;
                    }

                    //A12
                    else if (A12.Checked && comboBox3.Text == seatnames[19])
                    {

                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A12s[0] += Convert.ToInt32(textBox1.Text);
                                if (A12s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A12s[1] += Convert.ToInt32(textBox1.Text);
                                if (A12s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A12s[2] += Convert.ToInt32(textBox1.Text);
                                if (A12s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A12s[3] += Convert.ToInt32(textBox1.Text);
                                if (A12s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A12s[4] += Convert.ToInt32(textBox1.Text);
                                if (A12s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A12s[5] += Convert.ToInt32(textBox1.Text);
                                if (A12s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A12s[6] += Convert.ToInt32(textBox1.Text);
                                if (A12s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A12s[7] += Convert.ToInt32(textBox1.Text);
                                if (A12s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A12s[8] += Convert.ToInt32(textBox1.Text);
                                if (A12s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A12s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        A12.Checked = false;
                    }

                    //A13
                    else if (A13.Checked && comboBox3.Text == seatnames[20])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A13s[0] += Convert.ToInt32(textBox1.Text);
                                if (A13s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A13s[1] += Convert.ToInt32(textBox1.Text);
                                if (A13s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A13s[2] += Convert.ToInt32(textBox1.Text);
                                if (A13s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A13s[3] += Convert.ToInt32(textBox1.Text);
                                if (A13s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A13s[4] += Convert.ToInt32(textBox1.Text);
                                if (A13s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A13s[5] += Convert.ToInt32(textBox1.Text);
                                if (A13s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A13s[6] += Convert.ToInt32(textBox1.Text);
                                if (A13s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A13s[7] += Convert.ToInt32(textBox1.Text);
                                if (A13s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A13s[8] += Convert.ToInt32(textBox1.Text);
                                if (A13s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A13s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        A13.Checked = false;
                    }

                    //A14
                    else if (A14.Checked && comboBox3.Text == seatnames[21])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A14s[0] += Convert.ToInt32(textBox1.Text);
                                if (A14s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A14s[1] += Convert.ToInt32(textBox1.Text);
                                if (A14s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A14s[2] += Convert.ToInt32(textBox1.Text);
                                if (A14s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A14s[3] += Convert.ToInt32(textBox1.Text);
                                if (A14s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    A14s[3] -= Convert.ToInt32(textBox1.Text);

                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A14s[4] += Convert.ToInt32(textBox1.Text);
                                if (A14s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A14s[5] += Convert.ToInt32(textBox1.Text);
                                if (A14s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A14s[6] += Convert.ToInt32(textBox1.Text);
                                if (A14s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A14s[7] += Convert.ToInt32(textBox1.Text);
                                if (A14s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A14s[8] += Convert.ToInt32(textBox1.Text);
                                if (A14s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A14s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }

                        A14.Checked = false;
                    }

                    //A15
                    else if (A15.Checked && comboBox3.Text == seatnames[22])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A15s[0] += Convert.ToInt32(textBox1.Text);
                                if (A15s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A15s[1] += Convert.ToInt32(textBox1.Text);
                                if (A15s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A15s[2] += Convert.ToInt32(textBox1.Text);
                                if (A15s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A15s[3] += Convert.ToInt32(textBox1.Text);
                                if (A15s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A15s[4] += Convert.ToInt32(textBox1.Text);
                                if (A15s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A15s[5] += Convert.ToInt32(textBox1.Text);
                                if (A15s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A15s[6] += Convert.ToInt32(textBox1.Text);
                                if (A15s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A15s[7] += Convert.ToInt32(textBox1.Text);
                                if (A15s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A15s[8] += Convert.ToInt32(textBox1.Text);
                                if (A15s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A15s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }

                        A15.Checked = false;
                    }

                    //A16
                    else if (A16.Checked && comboBox3.Text == seatnames[23])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                A16s[0] += Convert.ToInt32(textBox1.Text);
                                if (A16s[0] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                A16s[1] += Convert.ToInt32(textBox1.Text);
                                if (A16s[1] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                A16s[2] += Convert.ToInt32(textBox1.Text);
                                if (A16s[2] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                A16s[3] += Convert.ToInt32(textBox1.Text);
                                if (A16s[3] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                A16s[4] += Convert.ToInt32(textBox1.Text);
                                if (A16s[4] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                A16s[5] += Convert.ToInt32(textBox1.Text);
                                if (A16s[5] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                A16s[6] += Convert.ToInt32(textBox1.Text);
                                if (A16s[6] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                A16s[7] += Convert.ToInt32(textBox1.Text);
                                if (A16s[7] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                A16s[8] += Convert.ToInt32(textBox1.Text);
                                if (A16s[8] <= 15)
                                {
                                    seat_amountholder = a_amount;
                                    total += Convert.ToInt32(textBox1.Text) * a_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    A16s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        A16.Checked = false;
                    }

                    //V1
                    else if (V1.Checked && comboBox3.Text == seatnames[24])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V1s[0] += Convert.ToInt32(textBox1.Text);
                                if (V1s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V1s[1] += Convert.ToInt32(textBox1.Text);
                                if (V1s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {

                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V1s[2] += Convert.ToInt32(textBox1.Text);
                                if (V1s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V1s[3] += Convert.ToInt32(textBox1.Text);
                                if (V1s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V1s[4] += Convert.ToInt32(textBox1.Text);
                                if (V1s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V1s[5] += Convert.ToInt32(textBox1.Text);
                                if (V1s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V1s[6] += Convert.ToInt32(textBox1.Text);
                                if (V1s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V1s[7] += Convert.ToInt32(textBox1.Text);
                                if (V1s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V1s[8] += Convert.ToInt32(textBox1.Text);
                                if (V1s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V1s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        V1.Checked = false;
                    }

                    //V2
                    else if (V2.Checked && comboBox3.Text == seatnames[25])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V2s[0] += Convert.ToInt32(textBox1.Text);
                                if (V2s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V2s[1] += Convert.ToInt32(textBox1.Text);
                                if (V2s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V2s[2] += Convert.ToInt32(textBox1.Text);
                                if (V2s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V2s[3] += Convert.ToInt32(textBox1.Text);
                                if (V2s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V2s[4] += Convert.ToInt32(textBox1.Text);
                                if (V2s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V2s[5] += Convert.ToInt32(textBox1.Text);
                                if (V2s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V2s[6] += Convert.ToInt32(textBox1.Text);
                                if (V2s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V2s[7] += Convert.ToInt32(textBox1.Text);
                                if (V2s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V2s[8] += Convert.ToInt32(textBox1.Text);
                                if (V2s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V2s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }

                        V2.Checked = false;
                    }

                    //V3
                    else if (V3.Checked && comboBox3.Text == seatnames[26])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V3s[0] += Convert.ToInt32(textBox1.Text);
                                if (V3s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V3s[1] += Convert.ToInt32(textBox1.Text);
                                if (V3s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V3s[2] += Convert.ToInt32(textBox1.Text);
                                if (V3s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V3s[3] += Convert.ToInt32(textBox1.Text);
                                if (V3s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V3s[4] += Convert.ToInt32(textBox1.Text);
                                if (V3s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V3s[5] += Convert.ToInt32(textBox1.Text);
                                if (V3s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V3s[6] += Convert.ToInt32(textBox1.Text);
                                if (V3s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V3s[7] += Convert.ToInt32(textBox1.Text);
                                if (V3s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V3s[8] += Convert.ToInt32(textBox1.Text);
                                if (V3s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V3s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        V3.Checked = false;
                    }

                    //V4
                    else if (V4.Checked && comboBox3.Text == seatnames[27])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V4s[0] += Convert.ToInt32(textBox1.Text);
                                if (V4s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V4s[1] += Convert.ToInt32(textBox1.Text);
                                if (V4s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V4s[2] += Convert.ToInt32(textBox1.Text);
                                if (V4s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V4s[3] += Convert.ToInt32(textBox1.Text);
                                if (V4s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V4s[4] += Convert.ToInt32(textBox1.Text);
                                if (V4s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V4s[5] += Convert.ToInt32(textBox1.Text);
                                if (V4s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V4s[6] += Convert.ToInt32(textBox1.Text);
                                if (V4s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V4s[7] += Convert.ToInt32(textBox1.Text);
                                if (V4s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V4s[8] += Convert.ToInt32(textBox1.Text);
                                if (V4s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V4s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V4.Checked = false;
                    }

                    //V5
                    else if (V5.Checked && comboBox3.Text == seatnames[28])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {

                                V5s[0] += Convert.ToInt32(textBox1.Text);
                                if (V5s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V5s[1] += Convert.ToInt32(textBox1.Text);
                                if (V5s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V5s[2] += Convert.ToInt32(textBox1.Text);
                                if (V5s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V5s[3] += Convert.ToInt32(textBox1.Text);
                                if (V5s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V5s[4] += Convert.ToInt32(textBox1.Text);
                                if (V5s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V5s[5] += Convert.ToInt32(textBox1.Text);
                                if (V5s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V5s[6] += Convert.ToInt32(textBox1.Text);
                                if (V5s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V5s[7] += Convert.ToInt32(textBox1.Text);
                                if (V5s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V5s[8] += Convert.ToInt32(textBox1.Text);
                                if (V5s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V5s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V5.Checked = false;
                    }

                    //V6
                    else if (V6.Checked && comboBox3.Text == seatnames[29])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V6s[0] += Convert.ToInt32(textBox1.Text);
                                if (V6s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V6s[1] += Convert.ToInt32(textBox1.Text);
                                if (V6s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V6s[2] += Convert.ToInt32(textBox1.Text);
                                if (V6s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V6s[3] += Convert.ToInt32(textBox1.Text);
                                if (V6s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V6s[4] += Convert.ToInt32(textBox1.Text);
                                if (V6s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    V6s[4] -= Convert.ToInt32(textBox1.Text);

                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V6s[5] += Convert.ToInt32(textBox1.Text);
                                if (V6s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V6s[6] += Convert.ToInt32(textBox1.Text);
                                if (V6s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V6s[7] += Convert.ToInt32(textBox1.Text);
                                if (V6s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V6s[8] += Convert.ToInt32(textBox1.Text);
                                if (V6s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V6s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        V6.Checked = false;
                    }

                    //V7
                    else if (V7.Checked && comboBox3.Text == seatnames[30])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V7s[0] += Convert.ToInt32(textBox1.Text);
                                if (V7s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V7s[1] += Convert.ToInt32(textBox1.Text);
                                if (V7s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[1] -= Convert.ToInt32(textBox1.Text);

                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V7s[2] += Convert.ToInt32(textBox1.Text);
                                if (V7s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V7s[3] += Convert.ToInt32(textBox1.Text);
                                if (V7s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V7s[4] += Convert.ToInt32(textBox1.Text);
                                if (V7s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V7s[5] += Convert.ToInt32(textBox1.Text);
                                if (V7s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V7s[6] += Convert.ToInt32(textBox1.Text);
                                if (V7s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V7s[7] += Convert.ToInt32(textBox1.Text);
                                if (V7s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V7s[8] += Convert.ToInt32(textBox1.Text);
                                if (V7s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V7s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V7.Checked = false;
                    }

                    //V8
                    else if (V8.Checked && comboBox3.Text == seatnames[31])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V8s[0] += Convert.ToInt32(textBox1.Text);
                                if (V8s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V8s[1] += Convert.ToInt32(textBox1.Text);
                                if (V8s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V8s[2] += Convert.ToInt32(textBox1.Text);
                                if (V8s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V8s[3] += Convert.ToInt32(textBox1.Text);
                                if (V8s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V8s[4] += Convert.ToInt32(textBox1.Text);
                                if (V8s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V8s[5] += Convert.ToInt32(textBox1.Text);
                                if (V8s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V8s[6] += Convert.ToInt32(textBox1.Text);
                                if (V8s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V8s[7] += Convert.ToInt32(textBox1.Text);
                                if (V8s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[7] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V8s[8] += Convert.ToInt32(textBox1.Text);
                                if (V8s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V8s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V8.Checked = true;
                    }

                    //V9
                    else if (V9.Checked && comboBox3.Text == seatnames[32])
                    {

                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V9s[0] += Convert.ToInt32(textBox1.Text);
                                if (V9s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V9s[1] += Convert.ToInt32(textBox1.Text);
                                if (V9s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[1] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V9s[2] += Convert.ToInt32(textBox1.Text);
                                if (V9s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[2] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V9s[3] += Convert.ToInt32(textBox1.Text);
                                if (V9s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V9s[4] += Convert.ToInt32(textBox1.Text);
                                if (V9s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V9s[5] += Convert.ToInt32(textBox1.Text);
                                if (V9s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V9s[6] += Convert.ToInt32(textBox1.Text);
                                if (V9s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[6] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V9s[7] += Convert.ToInt32(textBox1.Text);
                                if (V9s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V9s[8] += Convert.ToInt32(textBox1.Text);
                                if (V9s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V9s[8] -= Convert.ToInt32(textBox1.Text);
                                }


                            }

                        }
                        V9.Checked = false;
                    }

                    //V10
                    else if (V10.Checked && comboBox3.Text == seatnames[33])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V10s[0] += Convert.ToInt32(textBox1.Text);
                                if (V10s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[0] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V10s[1] += Convert.ToInt32(textBox1.Text);
                                if (V10s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V10s[2] += Convert.ToInt32(textBox1.Text);
                                if (V10s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V10s[3] += Convert.ToInt32(textBox1.Text);
                                if (V10s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V10s[4] += Convert.ToInt32(textBox1.Text);
                                if (V10s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[4] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V10s[5] += Convert.ToInt32(textBox1.Text);
                                if (V10s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V10s[6] += Convert.ToInt32(textBox1.Text);
                                if (V10s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V10s[7] += Convert.ToInt32(textBox1.Text);
                                if (V10s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V10s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V10s[8] += Convert.ToInt32(textBox1.Text);
                                if (V10s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    V10s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V10.Checked = false;
                    }

                    //V11
                    else if (V11.Checked && comboBox3.Text == seatnames[34])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V11s[0] += Convert.ToInt32(textBox1.Text);
                                if (V11s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[0] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V11s[1] += Convert.ToInt32(textBox1.Text);
                                if (V11s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V11s[2] += Convert.ToInt32(textBox1.Text);
                                if (V11s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V11s[3] += Convert.ToInt32(textBox1.Text);
                                if (V11s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[3] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V11s[4] += Convert.ToInt32(textBox1.Text);
                                if (V11s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[4] -= Convert.ToInt32(textBox1.Text);
                                }


                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V11s[5] += Convert.ToInt32(textBox1.Text);
                                if (V11s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[5] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {


                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V11s[6] += Convert.ToInt32(textBox1.Text);
                                if (V11s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[6] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V11s[7] += Convert.ToInt32(textBox1.Text);
                                if (V11s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }


                        }
                        else if (confirmtitle[5] == "Laufey")
                        {

                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V11s[8] += Convert.ToInt32(textBox1.Text);
                                if (V11s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V11s[8] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        V11.Checked = false;
                    }

                    //V12
                    else if (V12.Checked && comboBox3.Text == seatnames[35])
                    {
                        if (confirmtitle[0] == "Bini")
                        {
                            if (comboBox1.Text == "AUGUST 18, 8:00 PM")
                            {
                                V12s[0] += Convert.ToInt32(textBox1.Text);
                                if (V12s[0] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[0] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "AUGUST 19, 7:00 PM")
                            {
                                V12s[1] += Convert.ToInt32(textBox1.Text);
                                if (V12s[1] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[1] -= Convert.ToInt32(textBox1.Text);
                                }

                            }

                        }
                        else if (confirmtitle[1] == "Parokya Ni Edgar")
                        {

                            if (comboBox1.Text == "SEPTEMBER 22, 8:00 PM")
                            {
                                V12s[2] += Convert.ToInt32(textBox1.Text);
                                if (V12s[2] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[2] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[2] == "SB19")
                        {
                            if (comboBox1.Text == "JANUARY 24, 7:00 PM")
                            {
                                V12s[3] += Convert.ToInt32(textBox1.Text);
                                if (V12s[3] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[3] -= Convert.ToInt32(textBox1.Text);
                                }

                            }


                        }
                        else if (confirmtitle[3] == "Bruno Mars")
                        {
                            if (comboBox1.Text == "MARCH 32, 6:00 PM")
                            {
                                V12s[4] += Convert.ToInt32(textBox1.Text);
                                if (V12s[4] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[4] -= Convert.ToInt32(textBox1.Text);
                                }

                            }
                            else if (comboBox1.Text == "NOVEMBER 11, 5:30 PM")
                            {
                                V12s[5] += Convert.ToInt32(textBox1.Text);
                                if (V12s[5] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[5] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[4] == "Taylor Swift")
                        {
                            if (comboBox1.Text == "MARCH 30, 7:46 PM")
                            {
                                V12s[6] += Convert.ToInt32(textBox1.Text);
                                if (V12s[6] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[6] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                            else if (comboBox1.Text == "NOVEMBER 29, 8:00 PM")
                            {
                                V12s[7] += Convert.ToInt32(textBox1.Text);
                                if (V12s[7] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[7] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        else if (confirmtitle[5] == "Laufey")
                        {
                            if (comboBox1.Text == "MAY 12, 6:00 PM")
                            {
                                V12s[8] += Convert.ToInt32(textBox1.Text);
                                if (V12s[8] <= 15)
                                {
                                    seat_amountholder = v_amount;
                                    total += Convert.ToInt32(textBox1.Text) * v_amount; to_datagrid();
                                }
                                else
                                {
                                    MessageBox.Show("OUT OF ORDER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    V12s[8] -= Convert.ToInt32(textBox1.Text);
                                }
                            }
                        }
                        V12.Checked = false;
                    }

                    //clearing boxes

                    comboBox1.Text = string.Empty;
                    comboBox3.Items.Remove(comboBox3.Text);
                    textBox1.Text = string.Empty;

                    this.Controls.Add(comboBox3);

                    comboBox3.Text = string.Empty;

                    if (comboBox3.Items.Count == 0)
                    {
                        comboBox3.Text = string.Empty;
                        comformation = true;
                    }
                }

                textBox1.Text = string.Empty;
            }
        }
    }
}