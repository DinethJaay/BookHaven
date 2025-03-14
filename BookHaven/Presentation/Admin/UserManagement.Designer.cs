namespace BookHaven.Presentation.Admin
{
    partial class UserManagement
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
            backpic = new PictureBox();
            label1 = new Label();
            datagridviewuser = new DataGridView();
            button1 = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            label2 = new Label();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            label3 = new Label();
            txtphone = new TextBox();
            label4 = new Label();
            txtidnum = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbgender = new ComboBox();
            label8 = new Label();
            dobpicker = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewuser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(backpic);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 87);
            panel1.TabIndex = 0;
            // 
            // backpic
            // 
            backpic.Image = Properties.Resources.left_arrow_10117838;
            backpic.Location = new Point(886, 27);
            backpic.Name = "backpic";
            backpic.Size = new Size(72, 33);
            backpic.SizeMode = PictureBoxSizeMode.Zoom;
            backpic.TabIndex = 1;
            backpic.TabStop = false;
            backpic.Click += backpic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // datagridviewuser
            // 
            datagridviewuser.BackgroundColor = SystemColors.ControlLightLight;
            datagridviewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewuser.Location = new Point(35, 155);
            datagridviewuser.Name = "datagridviewuser";
            datagridviewuser.Size = new Size(929, 236);
            datagridviewuser.TabIndex = 1;
            datagridviewuser.CellContentClick += datagridviewuser_CellContentClick;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._4288270;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(849, 105);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(844, 633);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(115, 44);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(680, 633);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(115, 44);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(35, 420);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(35, 455);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(284, 23);
            txtfirstname.TabIndex = 7;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(356, 455);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(284, 23);
            txtlastname.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(356, 420);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(35, 523);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 23);
            txtphone.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(35, 488);
            label4.Name = "label4";
            label4.Size = new Size(106, 16);
            label4.TabIndex = 10;
            label4.Text = "Phone Number:";
            // 
            // txtidnum
            // 
            txtidnum.Location = new Point(35, 591);
            txtidnum.Name = "txtidnum";
            txtidnum.Size = new Size(284, 23);
            txtidnum.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(35, 556);
            label5.Name = "label5";
            label5.Size = new Size(112, 16);
            label5.TabIndex = 12;
            label5.Text = "Identity Number:";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(680, 455);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(284, 23);
            txtaddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(680, 420);
            label6.Name = "label6";
            label6.Size = new Size(61, 16);
            label6.TabIndex = 14;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(680, 490);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Male", "Female" });
            cmbgender.Location = new Point(680, 520);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(284, 23);
            cmbgender.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(356, 488);
            label8.Name = "label8";
            label8.Size = new Size(39, 16);
            label8.TabIndex = 18;
            label8.Text = "DOB:";
            // 
            // dobpicker
            // 
            dobpicker.Location = new Point(356, 520);
            dobpicker.Name = "dobpicker";
            dobpicker.Size = new Size(284, 23);
            dobpicker.TabIndex = 19;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(dobpicker);
            Controls.Add(label8);
            Controls.Add(cmbgender);
            Controls.Add(label7);
            Controls.Add(txtaddress);
            Controls.Add(label6);
            Controls.Add(txtidnum);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(txtlastname);
            Controls.Add(label3);
            Controls.Add(txtfirstname);
            Controls.Add(label2);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(button1);
            Controls.Add(datagridviewuser);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView datagridviewuser;
        private Button button1;
        private Button btndelete;
        private Button btnupdate;
        private Label label2;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label label3;
        private TextBox txtphone;
        private Label label4;
        private TextBox txtidnum;
        private Label label5;
        private TextBox txtaddress;
        private Label label6;
        private Label label7;
        private ComboBox cmbgender;
        private Label label8;
        private DateTimePicker dobpicker;
        private PictureBox backpic;
    }
}