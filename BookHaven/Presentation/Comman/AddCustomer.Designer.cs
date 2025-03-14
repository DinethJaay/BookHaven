namespace BookHaven.Presentation.Comman
{
    partial class AddCustomer
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtPhoneNumber = new TextBox();
            cmbGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtZipCode = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblFirstName = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnBacktoCustomerManagement = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtFirstName = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtZipCode);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(29, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 548);
            panel1.TabIndex = 35;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._4288270;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.pngtree_open_book_icon_for_library_and_studying_in_head_vector_png_image_15477299;
            pictureBox1.Location = new Point(36, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 396);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(596, 171);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(309, 23);
            txtPhoneNumber.TabIndex = 42;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(597, 267);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(309, 23);
            cmbGender.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(597, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 23);
            dateTimePicker1.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(485, 360);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 39;
            label10.Text = "City";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(485, 315);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 38;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(485, 267);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 37;
            label8.Text = "Gender";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(596, 407);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(309, 23);
            txtZipCode.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(485, 407);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 25;
            label7.Text = "Zip Code";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(596, 357);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(309, 23);
            txtCity.TabIndex = 35;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(596, 307);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(309, 23);
            txtAddress.TabIndex = 34;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(596, 81);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(309, 23);
            txtLastName.TabIndex = 27;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(485, 222);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 24;
            label6.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(596, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(485, 179);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 23;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(485, 135);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 22;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(485, 89);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 21;
            label3.Text = "LastName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.Control;
            lblFirstName.Location = new Point(485, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "FirstName";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 70);
            panel2.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(247, 41);
            label1.TabIndex = 0;
            label1.Text = "Add Customer";
            // 
            // btnBacktoCustomerManagement
            // 
            btnBacktoCustomerManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBacktoCustomerManagement.Location = new Point(661, 670);
            btnBacktoCustomerManagement.Name = "btnBacktoCustomerManagement";
            btnBacktoCustomerManagement.Size = new Size(274, 36);
            btnBacktoCustomerManagement.TabIndex = 19;
            btnBacktoCustomerManagement.Text = "Back to Customer Management";
            btnBacktoCustomerManagement.UseVisualStyleBackColor = true;
            btnBacktoCustomerManagement.Click += btnBacktoCustomerManagement_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(834, 597);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 37);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(703, 597);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 37);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(625, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 23);
            txtFirstName.TabIndex = 26;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(365, 670);
            button1.Name = "button1";
            button1.Size = new Size(261, 36);
            button1.TabIndex = 37;
            button1.Text = "Back to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(button1);
            Controls.Add(btnBacktoCustomerManagement);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFirstName);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "AddCustomer";
            Text = "AddCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtZipCode;
        private Label label7;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label lblFirstName;
        private Button btnBacktoCustomerManagement;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtFirstName;
        private ComboBox cmbGender;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPhoneNumber;
        private PictureBox pictureBox1;
        private Button button1;
    }
}