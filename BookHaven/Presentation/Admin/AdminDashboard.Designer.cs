namespace BookHaven.Presentation.Admin
{
    partial class AdminDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            Menu = new Label();
            menupicbox = new PictureBox();
            panel2 = new Panel();
            btndashboard = new Button();
            btnusers = new Button();
            btncustomers = new Button();
            btnsalestransaction = new Button();
            btnordermanagement = new Button();
            btnsuppliers = new Button();
            btnorderrequest = new Button();
            btnreporting = new Button();
            button1 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            Overview = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            lblmonthlySales = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblweeklySales = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lbldailySales = new Label();
            label2 = new Label();
            label1 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            lblmonthlyamount = new Label();
            label6 = new Label();
            panel9 = new Panel();
            totalweeklyamount = new Label();
            label8 = new Label();
            panel10 = new Panel();
            lbltotaldailyamount = new Label();
            label10 = new Label();
            label11 = new Label();
            panel11 = new Panel();
            panel12 = new Panel();
            lblcompletedorders = new Label();
            label7 = new Label();
            panel13 = new Panel();
            lblpendingorders = new Label();
            label12 = new Label();
            panel14 = new Panel();
            lbltotalorders = new Label();
            label14 = new Label();
            label15 = new Label();
            panel15 = new Panel();
            panel19 = new Panel();
            lblmostselling = new Label();
            label24 = new Label();
            panel17 = new Panel();
            lbltotalbooks = new Label();
            label19 = new Label();
            panel16 = new Panel();
            lbltotalsuppliers = new Label();
            label17 = new Label();
            panel18 = new Panel();
            lbltotalcustomers = new Label();
            label21 = new Label();
            label22 = new Label();
            panel20 = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel19.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            panel18.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnusers);
            sidebar.Controls.Add(btncustomers);
            sidebar.Controls.Add(btnsalestransaction);
            sidebar.Controls.Add(btnordermanagement);
            sidebar.Controls.Add(btnsuppliers);
            sidebar.Controls.Add(btnorderrequest);
            sidebar.Controls.Add(btnreporting);
            sidebar.Controls.Add(button1);
            sidebar.Location = new Point(0, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(242, 729);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Menu);
            panel1.Controls.Add(menupicbox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 100);
            panel1.TabIndex = 1;
            // 
            // Menu
            // 
            Menu.AutoSize = true;
            Menu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.White;
            Menu.Location = new Point(85, 31);
            Menu.Name = "Menu";
            Menu.Size = new Size(77, 32);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // menupicbox
            // 
            menupicbox.Image = Properties.Resources.menu1;
            menupicbox.Location = new Point(23, 27);
            menupicbox.Name = "menupicbox";
            menupicbox.Size = new Size(36, 39);
            menupicbox.SizeMode = PictureBoxSizeMode.Zoom;
            menupicbox.TabIndex = 1;
            menupicbox.TabStop = false;
            menupicbox.Click += menupicbox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btndashboard);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 56);
            panel2.TabIndex = 2;
            // 
            // btndashboard
            // 
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.ForeColor = Color.White;
            btndashboard.Image = (Image)resources.GetObject("btndashboard.Image");
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 3);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(30, 0, 0, 0);
            btndashboard.Size = new Size(252, 53);
            btndashboard.TabIndex = 3;
            btndashboard.Text = "                     Book Management";
            btndashboard.TextAlign = ContentAlignment.MiddleLeft;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnusers
            // 
            btnusers.FlatAppearance.BorderSize = 0;
            btnusers.FlatStyle = FlatStyle.Flat;
            btnusers.ForeColor = Color.White;
            btnusers.Image = (Image)resources.GetObject("btnusers.Image");
            btnusers.ImageAlign = ContentAlignment.MiddleLeft;
            btnusers.Location = new Point(3, 171);
            btnusers.Name = "btnusers";
            btnusers.Padding = new Padding(30, 0, 0, 0);
            btnusers.Size = new Size(252, 53);
            btnusers.TabIndex = 4;
            btnusers.Text = "                     Users";
            btnusers.TextAlign = ContentAlignment.MiddleLeft;
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click;
            // 
            // btncustomers
            // 
            btncustomers.FlatAppearance.BorderSize = 0;
            btncustomers.FlatStyle = FlatStyle.Flat;
            btncustomers.ForeColor = Color.White;
            btncustomers.Image = (Image)resources.GetObject("btncustomers.Image");
            btncustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btncustomers.Location = new Point(3, 230);
            btncustomers.Name = "btncustomers";
            btncustomers.Padding = new Padding(30, 0, 0, 0);
            btncustomers.Size = new Size(252, 53);
            btncustomers.TabIndex = 4;
            btncustomers.Text = "                     Customers";
            btncustomers.TextAlign = ContentAlignment.MiddleLeft;
            btncustomers.UseVisualStyleBackColor = false;
            btncustomers.Click += btncustomers_Click;
            // 
            // btnsalestransaction
            // 
            btnsalestransaction.FlatAppearance.BorderSize = 0;
            btnsalestransaction.FlatStyle = FlatStyle.Flat;
            btnsalestransaction.ForeColor = Color.White;
            btnsalestransaction.Image = (Image)resources.GetObject("btnsalestransaction.Image");
            btnsalestransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.Location = new Point(3, 289);
            btnsalestransaction.Name = "btnsalestransaction";
            btnsalestransaction.Padding = new Padding(30, 0, 0, 0);
            btnsalestransaction.Size = new Size(252, 53);
            btnsalestransaction.TabIndex = 4;
            btnsalestransaction.Text = "                     Sales Transaction";
            btnsalestransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnsalestransaction.UseVisualStyleBackColor = false;
            btnsalestransaction.Click += btnsalestransaction_Click;
            // 
            // btnordermanagement
            // 
            btnordermanagement.FlatAppearance.BorderSize = 0;
            btnordermanagement.FlatStyle = FlatStyle.Flat;
            btnordermanagement.ForeColor = Color.White;
            btnordermanagement.Image = (Image)resources.GetObject("btnordermanagement.Image");
            btnordermanagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.Location = new Point(3, 348);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Padding = new Padding(30, 0, 0, 0);
            btnordermanagement.Size = new Size(252, 53);
            btnordermanagement.TabIndex = 4;
            btnordermanagement.Text = "                     Order Management";
            btnordermanagement.TextAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnsuppliers
            // 
            btnsuppliers.FlatAppearance.BorderSize = 0;
            btnsuppliers.FlatStyle = FlatStyle.Flat;
            btnsuppliers.ForeColor = Color.White;
            btnsuppliers.Image = (Image)resources.GetObject("btnsuppliers.Image");
            btnsuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.Location = new Point(3, 407);
            btnsuppliers.Name = "btnsuppliers";
            btnsuppliers.Padding = new Padding(30, 0, 0, 0);
            btnsuppliers.Size = new Size(252, 53);
            btnsuppliers.TabIndex = 4;
            btnsuppliers.Text = "                    Suppliers";
            btnsuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnsuppliers.UseVisualStyleBackColor = false;
            btnsuppliers.Click += btnsuppliers_Click;
            // 
            // btnorderrequest
            // 
            btnorderrequest.FlatAppearance.BorderSize = 0;
            btnorderrequest.FlatStyle = FlatStyle.Flat;
            btnorderrequest.ForeColor = Color.White;
            btnorderrequest.Image = (Image)resources.GetObject("btnorderrequest.Image");
            btnorderrequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.Location = new Point(3, 466);
            btnorderrequest.Name = "btnorderrequest";
            btnorderrequest.Padding = new Padding(30, 0, 0, 0);
            btnorderrequest.Size = new Size(252, 53);
            btnorderrequest.TabIndex = 5;
            btnorderrequest.Text = "                     Order Request";
            btnorderrequest.TextAlign = ContentAlignment.MiddleLeft;
            btnorderrequest.UseVisualStyleBackColor = false;
            btnorderrequest.Click += btnorderrequest_Click;
            // 
            // btnreporting
            // 
            btnreporting.FlatAppearance.BorderSize = 0;
            btnreporting.FlatStyle = FlatStyle.Flat;
            btnreporting.ForeColor = Color.White;
            btnreporting.Image = (Image)resources.GetObject("btnreporting.Image");
            btnreporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnreporting.Location = new Point(3, 525);
            btnreporting.Name = "btnreporting";
            btnreporting.Padding = new Padding(30, 0, 0, 0);
            btnreporting.Size = new Size(252, 53);
            btnreporting.TabIndex = 6;
            btnreporting.Text = "                     Reporting and Analytics";
            btnreporting.TextAlign = ContentAlignment.MiddleLeft;
            btnreporting.UseVisualStyleBackColor = false;
            btnreporting.Click += btnreporting_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 584);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(252, 53);
            button1.TabIndex = 7;
            button1.Text = "                     Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebarTimer_Tick;
            // 
            // Overview
            // 
            Overview.AutoSize = true;
            Overview.BackColor = Color.Transparent;
            Overview.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Overview.ForeColor = SystemColors.Control;
            Overview.Location = new Point(229, 12);
            Overview.Name = "Overview";
            Overview.Size = new Size(304, 40);
            Overview.TabIndex = 1;
            Overview.Text = "Dashboard Overview";
            Overview.Click += Overview_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(261, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(735, 140);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblmonthlySales);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(513, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 5;
            // 
            // lblmonthlySales
            // 
            lblmonthlySales.AutoSize = true;
            lblmonthlySales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmonthlySales.Location = new Point(73, 24);
            lblmonthlySales.Name = "lblmonthlySales";
            lblmonthlySales.Size = new Size(63, 25);
            lblmonthlySales.TabIndex = 8;
            lblmonthlySales.Text = "label7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 72);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 8;
            label4.Text = "Monthly Sales";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblweeklySales);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(268, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 4;
            // 
            // lblweeklySales
            // 
            lblweeklySales.AutoSize = true;
            lblweeklySales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblweeklySales.Location = new Point(67, 24);
            lblweeklySales.Name = "lblweeklySales";
            lblweeklySales.Size = new Size(63, 25);
            lblweeklySales.TabIndex = 7;
            lblweeklySales.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 72);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 7;
            label3.Text = "Weekly Sales";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbldailySales);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(24, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 3;
            // 
            // lbldailySales
            // 
            lbldailySales.AutoSize = true;
            lbldailySales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldailySales.Location = new Point(71, 24);
            lbldailySales.Name = "lbldailySales";
            lbldailySales.Size = new Size(63, 25);
            lbldailySales.TabIndex = 3;
            lbldailySales.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 72);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 6;
            label2.Text = "Daily Sales";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 3;
            label1.Text = "Sales Count Overview";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(261, 232);
            panel7.Name = "panel7";
            panel7.Size = new Size(735, 140);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblmonthlyamount);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(513, 24);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 100);
            panel8.TabIndex = 5;
            // 
            // lblmonthlyamount
            // 
            lblmonthlyamount.AutoSize = true;
            lblmonthlyamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmonthlyamount.Location = new Point(73, 24);
            lblmonthlyamount.Name = "lblmonthlyamount";
            lblmonthlyamount.Size = new Size(63, 25);
            lblmonthlyamount.TabIndex = 8;
            lblmonthlyamount.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 72);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 8;
            label6.Text = "Monthly Total";
            // 
            // panel9
            // 
            panel9.Controls.Add(totalweeklyamount);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(268, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 100);
            panel9.TabIndex = 4;
            // 
            // totalweeklyamount
            // 
            totalweeklyamount.AutoSize = true;
            totalweeklyamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalweeklyamount.Location = new Point(67, 24);
            totalweeklyamount.Name = "totalweeklyamount";
            totalweeklyamount.Size = new Size(63, 25);
            totalweeklyamount.TabIndex = 7;
            totalweeklyamount.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(56, 72);
            label8.Name = "label8";
            label8.Size = new Size(85, 17);
            label8.TabIndex = 7;
            label8.Text = "Weekly Total";
            // 
            // panel10
            // 
            panel10.Controls.Add(lbltotaldailyamount);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(24, 24);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 100);
            panel10.TabIndex = 3;
            // 
            // lbltotaldailyamount
            // 
            lbltotaldailyamount.AutoSize = true;
            lbltotaldailyamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotaldailyamount.Location = new Point(71, 24);
            lbltotaldailyamount.Name = "lbltotaldailyamount";
            lbltotaldailyamount.Size = new Size(63, 25);
            lbltotaldailyamount.TabIndex = 3;
            lbltotaldailyamount.Text = "label5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(63, 72);
            label10.Name = "label10";
            label10.Size = new Size(74, 17);
            label10.TabIndex = 6;
            label10.Text = "Daily Total ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 4);
            label11.Name = "label11";
            label11.Size = new Size(164, 21);
            label11.TabIndex = 3;
            label11.Text = "Total Sales Amounts";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(label15);
            panel11.Location = new Point(261, 391);
            panel11.Name = "panel11";
            panel11.Size = new Size(735, 140);
            panel11.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.Controls.Add(lblcompletedorders);
            panel12.Controls.Add(label7);
            panel12.Location = new Point(513, 24);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 100);
            panel12.TabIndex = 5;
            // 
            // lblcompletedorders
            // 
            lblcompletedorders.AutoSize = true;
            lblcompletedorders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcompletedorders.Location = new Point(73, 24);
            lblcompletedorders.Name = "lblcompletedorders";
            lblcompletedorders.Size = new Size(63, 25);
            lblcompletedorders.TabIndex = 8;
            lblcompletedorders.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 72);
            label7.Name = "label7";
            label7.Size = new Size(119, 17);
            label7.TabIndex = 8;
            label7.Text = "Completed Orders";
            label7.Click += label7_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(lblpendingorders);
            panel13.Controls.Add(label12);
            panel13.Location = new Point(268, 24);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 100);
            panel13.TabIndex = 4;
            // 
            // lblpendingorders
            // 
            lblpendingorders.AutoSize = true;
            lblpendingorders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpendingorders.Location = new Point(67, 24);
            lblpendingorders.Name = "lblpendingorders";
            lblpendingorders.Size = new Size(63, 25);
            lblpendingorders.TabIndex = 7;
            lblpendingorders.Text = "label6";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(52, 72);
            label12.Name = "label12";
            label12.Size = new Size(103, 17);
            label12.TabIndex = 7;
            label12.Text = "Pending Orders";
            // 
            // panel14
            // 
            panel14.Controls.Add(lbltotalorders);
            panel14.Controls.Add(label14);
            panel14.Location = new Point(24, 24);
            panel14.Name = "panel14";
            panel14.Size = new Size(200, 100);
            panel14.TabIndex = 3;
            // 
            // lbltotalorders
            // 
            lbltotalorders.AutoSize = true;
            lbltotalorders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalorders.Location = new Point(71, 24);
            lbltotalorders.Name = "lbltotalorders";
            lbltotalorders.Size = new Size(63, 25);
            lbltotalorders.TabIndex = 3;
            lbltotalorders.Text = "label5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(63, 72);
            label14.Name = "label14";
            label14.Size = new Size(82, 17);
            label14.TabIndex = 6;
            label14.Text = "Total Orders";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 4);
            label15.Name = "label15";
            label15.Size = new Size(137, 21);
            label15.TabIndex = 3;
            label15.Text = "Orders Overview";
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.Control;
            panel15.Controls.Add(panel19);
            panel15.Controls.Add(panel17);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(label22);
            panel15.Location = new Point(261, 546);
            panel15.Name = "panel15";
            panel15.Size = new Size(735, 140);
            panel15.TabIndex = 8;
            panel15.Paint += panel15_Paint;
            // 
            // panel19
            // 
            panel19.Controls.Add(lblmostselling);
            panel19.Controls.Add(label24);
            panel19.Location = new Point(572, 24);
            panel19.Name = "panel19";
            panel19.Size = new Size(137, 100);
            panel19.TabIndex = 9;
            // 
            // lblmostselling
            // 
            lblmostselling.AutoSize = true;
            lblmostselling.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmostselling.Location = new Point(39, 24);
            lblmostselling.Name = "lblmostselling";
            lblmostselling.Size = new Size(63, 25);
            lblmostselling.TabIndex = 3;
            lblmostselling.Text = "label5";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(15, 71);
            label24.Name = "label24";
            label24.Size = new Size(117, 17);
            label24.TabIndex = 6;
            label24.Text = "Most Selling Book";
            // 
            // panel17
            // 
            panel17.Controls.Add(lbltotalbooks);
            panel17.Controls.Add(label19);
            panel17.Location = new Point(391, 24);
            panel17.Name = "panel17";
            panel17.Size = new Size(137, 100);
            panel17.TabIndex = 8;
            // 
            // lbltotalbooks
            // 
            lbltotalbooks.AutoSize = true;
            lbltotalbooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalbooks.Location = new Point(39, 24);
            lbltotalbooks.Name = "lbltotalbooks";
            lbltotalbooks.Size = new Size(63, 25);
            lbltotalbooks.TabIndex = 3;
            lbltotalbooks.Text = "label5";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(27, 71);
            label19.Name = "label19";
            label19.Size = new Size(78, 17);
            label19.TabIndex = 6;
            label19.Text = "Total Books";
            // 
            // panel16
            // 
            panel16.Controls.Add(lbltotalsuppliers);
            panel16.Controls.Add(label17);
            panel16.Location = new Point(210, 24);
            panel16.Name = "panel16";
            panel16.Size = new Size(137, 100);
            panel16.TabIndex = 7;
            // 
            // lbltotalsuppliers
            // 
            lbltotalsuppliers.AutoSize = true;
            lbltotalsuppliers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalsuppliers.Location = new Point(39, 24);
            lbltotalsuppliers.Name = "lbltotalsuppliers";
            lbltotalsuppliers.Size = new Size(63, 25);
            lbltotalsuppliers.TabIndex = 3;
            lbltotalsuppliers.Text = "label5";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(15, 71);
            label17.Name = "label17";
            label17.Size = new Size(96, 17);
            label17.TabIndex = 6;
            label17.Text = "Total Suppliers";
            // 
            // panel18
            // 
            panel18.Controls.Add(lbltotalcustomers);
            panel18.Controls.Add(label21);
            panel18.Location = new Point(24, 24);
            panel18.Name = "panel18";
            panel18.Size = new Size(137, 100);
            panel18.TabIndex = 3;
            panel18.Paint += panel18_Paint;
            // 
            // lbltotalcustomers
            // 
            lbltotalcustomers.AutoSize = true;
            lbltotalcustomers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalcustomers.Location = new Point(39, 24);
            lbltotalcustomers.Name = "lbltotalcustomers";
            lbltotalcustomers.Size = new Size(63, 25);
            lbltotalcustomers.TabIndex = 3;
            lbltotalcustomers.Text = "label5";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(15, 71);
            label21.Name = "label21";
            label21.Size = new Size(106, 17);
            label21.TabIndex = 6;
            label21.Text = "Total Customers";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 4);
            label22.Name = "label22";
            label22.Size = new Size(142, 21);
            label22.TabIndex = 3;
            label22.Text = "System Overview";
            // 
            // panel20
            // 
            panel20.BackColor = SystemColors.ActiveCaptionText;
            panel20.Controls.Add(Overview);
            panel20.Location = new Point(242, 2);
            panel20.Name = "panel20";
            panel20.Size = new Size(766, 64);
            panel20.TabIndex = 9;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel20);
            Controls.Add(panel15);
            Controls.Add(panel11);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            DoubleBuffered = true;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button btndashboard;
        private Button btnusers;
        private Button btncustomers;
        private Button btnsalestransaction;
        private Button btnordermanagement;
        private Button btnsuppliers;
        private Button btnorderrequest;
        private Button btnreporting;
        private PictureBox menupicbox;
        private Label Menu;
        private System.Windows.Forms.Timer sidebartimer;
        private Button button1;
        private Label Overview;
        private Panel panel3;
        private Label label1;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private Label lblmonthlySales;
        private Label lblweeklySales;
        private Label lbldailySales;
        private Panel panel7;
        private Panel panel8;
        private Label lblmonthlyamount;
        private Label label6;
        private Panel panel9;
        private Label totalweeklyamount;
        private Label label8;
        private Panel panel10;
        private Label lbltotaldailyamount;
        private Label label10;
        private Label label11;
        private Panel panel11;
        private Panel panel12;
        private Label lblcompletedorders;
        private Label label7;
        private Panel panel13;
        private Label lblpendingorders;
        private Label label12;
        private Panel panel14;
        private Label lbltotalorders;
        private Label label14;
        private Label label15;
        private Panel panel15;
        private Panel panel18;
        private Label lbltotalcustomers;
        private Label label21;
        private Label label22;
        private Panel panel17;
        private Label lbltotalbooks;
        private Label label19;
        private Panel panel16;
        private Label lbltotalsuppliers;
        private Label label17;
        private Panel panel19;
        private Label lblmostselling;
        private Label label24;
        private Panel panel20;
    }
}