namespace Project_Finals
{
    partial class Loginpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Cross;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(156, 169);
            button1.Name = "button1";
            button1.Size = new Size(126, 35);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(123, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(123, 126);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(195, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 37);
            label1.TabIndex = 3;
            label1.Text = "LOG-IN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 4;
            label2.Text = "Username :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(290, 127);
            button2.Name = "button2";
            button2.Size = new Size(28, 26);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(290, 126);
            button3.Name = "button3";
            button3.Size = new Size(28, 27);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(415, 243);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "Loginpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in page";
            Load += Loginpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}
