namespace Project_Finals
{
    public partial class Loginpage : Form
    {
        public static Loginpage instance;

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

        private bool napaka_pogi_ko;

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

        public int[] holder_B1c2 = new int[9];
        public int[] holder_B2c2 = new int[9];
        public int[] holder_B3c2 = new int[9];
        public int[] holder_B4c2 = new int[9];
        public int[] holder_B5c2 = new int[9];
        public int[] holder_B6c2 = new int[9];
        public int[] holder_B7c2 = new int[9];
        public int[] holder_B8c2 = new int[9];

        public int[] holder_A1c2 = new int[9];
        public int[] holder_A2c2 = new int[9];
        public int[] holder_A3c2 = new int[9];
        public int[] holder_A4c2 = new int[9];
        public int[] holder_A5c2 = new int[9];
        public int[] holder_A6c2 = new int[9];
        public int[] holder_A7c2 = new int[9];
        public int[] holder_A8c2 = new int[9];
        public int[] holder_A9c2 = new int[9];
        public int[] holder_A10c2 = new int[9];
        public int[] holder_A11c2 = new int[9];
        public int[] holder_A12c2 = new int[9];
        public int[] holder_A13c2 = new int[9];
        public int[] holder_A14c2 = new int[9];
        public int[] holder_A15c2 = new int[9];
        public int[] holder_A16c2 = new int[9];

        public int[] holder_V1c2 = new int[9];
        public int[] holder_V2c2 = new int[9];
        public int[] holder_V3c2 = new int[9];
        public int[] holder_V4c2 = new int[9];
        public int[] holder_V5c2 = new int[9];
        public int[] holder_V6c2 = new int[9];
        public int[] holder_V7c2 = new int[9];
        public int[] holder_V8c2 = new int[9];
        public int[] holder_V9c2 = new int[9];
        public int[] holder_V10c2 = new int[9];
        public int[] holder_V11c2 = new int[9];
        public int[] holder_V12c2 = new int[9];
        private int[] holder_A1s1;

        public Loginpage()
        {
            InitializeComponent();
            instance = this;
        }
        public Loginpage(int[] holder_B1c1, int[] holder_B2c1, int[] holder_B3c1, int[] holder_B4c1, int[] holder_B5c1, int[] holder_B6c1, int[] holder_B7c1, int[] holder_B8c1, int[] holder_A1c1, int[] holder_A2c1, int[] holder_A3c1, int[] holder_A4c1, int[] holder_A5c1, int[] holder_A6c1, int[] holder_A7c1, int[] holder_A8c1, int[] holder_A9c1, int[] holder_A10c1, int[] holder_A11c1, int[] holder_A12c1, int[] holder_A13c1, int[] holder_A14c1, int[] holder_A15c1, int[] holder_A16c1, int[] holder_V1c1, int[] holder_V2c1, int[] holder_V3c1, int[] holder_V4c1, int[] holder_V5c1, int[] holder_V6c1, int[] holder_V7c1, int[] holder_V8c1, int[] holder_V9c1, int[] holder_V10c1, int[] holder_V11c1, int[] holder_V12c1)
        {
            InitializeComponent();
            for (int i = 0; i <= 8; i++)
            {
                if (holder_B1c1 != null)
                {
                    holder_B1c2[i] = holder_B1c1[i];
                    holder_B2c2[i] = holder_B2c1[i];
                    holder_B3c2[i] = holder_B3c1[i];
                    holder_B4c2[i] = holder_B4c1[i];
                    holder_B5c2[i] = holder_B5c1[i];
                    holder_B6c2[i] = holder_B6c1[i];
                    holder_B7c2[i] = holder_B7c1[i];
                    holder_B8c2[i] = holder_B8c1[i];

                    holder_A1c2[i] = holder_A1c1[i];
                    holder_A2c2[i] = holder_A2c1[i];
                    holder_A3c2[i] = holder_A3c1[i];
                    holder_A4c2[i] = holder_A4c1[i];
                    holder_A5c2[i] = holder_A5c1[i];
                    holder_A6c2[i] = holder_A6c1[i];
                    holder_A7c2[i] = holder_A7c1[i];
                    holder_A8c2[i] = holder_A8c1[i];
                    holder_A9c2[i] = holder_A9c1[i];
                    holder_A10c2[i] = holder_A10c1[i];
                    holder_A11c2[i] = holder_A11c1[i];
                    holder_A12c2[i] = holder_A12c1[i];
                    holder_A13c2[i] = holder_A13c1[i];
                    holder_A14c2[i] = holder_A14c1[i];
                    holder_A15c2[i] = holder_A15c1[i];
                    holder_A16c2[i] = holder_A16c1[i];

                    holder_V1c2[i] = holder_V1c1[i];
                    holder_V2c2[i] = holder_V2c1[i];
                    holder_V3c2[i] = holder_V3c1[i];
                    holder_V4c2[i] = holder_V4c1[i];
                    holder_V5c2[i] = holder_V5c1[i];
                    holder_V6c2[i] = holder_V6c1[i];
                    holder_V7c2[i] = holder_V7c1[i];
                    holder_V8c2[i] = holder_V8c1[i];
                    holder_V9c2[i] = holder_V9c1[i];
                    holder_V10c2[i] = holder_V10c1[i];
                    holder_V11c2[i] = holder_V11c1[i];
                    holder_V12c2[i] = holder_V12c1[i];
                }
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {

                concerts_tickets form1 = new concerts_tickets(holder_B1s, holder_B2s, holder_B3s, holder_B4s, holder_B5s, holder_B6s, holder_B7s, holder_B8s, holder_A1s, holder_A2s, holder_A3s, holder_A4s, holder_A5s, holder_A6s, holder_A7s, holder_A8s, holder_A9s, holder_A10s, holder_A11s, holder_A12s, holder_A13s, holder_A14s, holder_A15s, holder_A16s, holder_V1s, holder_V2s, holder_V3s, holder_V4s, holder_V5s, holder_V6s, holder_V7s, holder_V8s, holder_V9s, holder_V10s, holder_V11s, holder_V12s,
                transfer_B1s1, transfer_B2s1, transfer_B3s1, transfer_B4s1, transfer_B5s1, transfer_B6s1, transfer_B7s1, transfer_B8s1, transfer_A1s1, transfer_A2s1, transfer_A3s1, transfer_A4s1, transfer_A5s1, transfer_A6s1, transfer_A7s1, transfer_A8s1, transfer_A9s1, transfer_A10s1, transfer_A11s1, transfer_A12s1, transfer_A13s1, transfer_A14s1, transfer_A15s1, transfer_A16s1, transfer_V1s1, transfer_V2s1, transfer_V3s1, transfer_V4s1, transfer_V5s1, transfer_V6s1, transfer_V7s1, transfer_V8s1, transfer_V9s1, transfer_V10s1, transfer_V11s1, transfer_V12s1,
                 holder_B1s1, holder_B2s1, holder_B3s1, holder_B4s1, holder_B5s1, holder_B6s1, holder_B7s1, holder_B8s1, holder_A1s1, holder_A2s1, holder_A3s1, holder_A4s1, holder_A5s1, holder_A6s1, holder_A7s1, holder_A8s1, holder_A9s1, holder_A10s1, holder_A11s1, holder_A12s1, holder_A13s1, holder_A14s1, holder_A15s1, holder_A16s1, holder_V1s1, holder_V2s1, holder_V3s1, holder_V4s1, holder_V5s1, holder_V6s1, holder_V7s1, holder_V8s1, holder_V9s1, holder_V10s1, holder_V11s1, holder_V12s1,
                 napaka_pogi_ko, holder_B1c2, holder_B2c2, holder_B3c2, holder_B4c2, holder_B5c2, holder_B6c2, holder_B7c2, holder_B8c2, holder_A1c2, holder_A2c2, holder_A3c2, holder_A4c2, holder_A5c2, holder_A6c2, holder_A7c2, holder_A8c2, holder_A9c2, holder_A10c2, holder_A11c2, holder_A12c2, holder_A13c2, holder_A14c2, holder_A15c2, holder_A16c2, holder_V1c2, holder_V2c2, holder_V3c2, holder_V4c2, holder_V5c2, holder_V6c2, holder_V7c2, holder_V8c2, holder_V9c2, holder_V10c2, holder_V11c2, holder_V12c2);
                this.Hide();
                form1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Incorrect input", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {

                button3.BringToFront();
                textBox2.PasswordChar = '*';

            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '*')
            {

                button2.BringToFront();
                textBox2.PasswordChar = '\0';

            }


        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {


        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
