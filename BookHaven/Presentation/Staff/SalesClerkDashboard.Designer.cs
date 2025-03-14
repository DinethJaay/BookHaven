namespace BookHaven.Presentation.Staff
{
    partial class SalesClerkDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesClerkDashboard));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            Menu = new Label();
            menupicbox = new PictureBox();
            panel2 = new Panel();
            btndashboard = new Button();
            btncustomers = new Button();
            btnsalestransaction = new Button();
            btnordermanagement = new Button();
            btnreporting = new Button();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            lblweeklySales = new Label();
            label3 = new Label();
            panel7 = new Panel();
            lbldailySales = new Label();
            label2 = new Label();
            label5 = new Label();
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
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel19.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            panel18.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btncustomers);
            sidebar.Controls.Add(btnsalestransaction);
            sidebar.Controls.Add(btnordermanagement);
            sidebar.Controls.Add(btnreporting);
            sidebar.Controls.Add(button1);
            sidebar.Location = new Point(1, 1);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(240, 729);
            sidebar.TabIndex = 1;
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
            // btncustomers
            // 
            btncustomers.FlatAppearance.BorderSize = 0;
            btncustomers.FlatStyle = FlatStyle.Flat;
            btncustomers.ForeColor = Color.White;
            btncustomers.Image = (Image)resources.GetObject("btncustomers.Image");
            btncustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btncustomers.Location = new Point(3, 171);
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
            btnsalestransaction.Location = new Point(3, 230);
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
            btnordermanagement.Location = new Point(3, 289);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Padding = new Padding(30, 0, 0, 0);
            btnordermanagement.Size = new Size(252, 53);
            btnordermanagement.TabIndex = 4;
            btnordermanagement.Text = "                     Order Management";
            btnordermanagement.TextAlign = ContentAlignment.MiddleLeft;
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnreporting
            // 
            btnreporting.FlatAppearance.BorderSize = 0;
            btnreporting.FlatStyle = FlatStyle.Flat;
            btnreporting.ForeColor = Color.White;
            btnreporting.Image = (Image)resources.GetObject("btnreporting.Image");
            btnreporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnreporting.Location = new Point(3, 348);
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
            button1.Location = new Point(3, 407);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(252, 53);
            button1.TabIndex = 7;
            button1.Text = "                     Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(228, 15);
            label1.Name = "label1";
            label1.Size = new Size(357, 41);
            label1.TabIndex = 2;
            label1.Text = "Dashboard Overview";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(241, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(766, 69);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(259, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(735, 140);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblweeklySales);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(405, 25);
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
            label3.Location = new Point(43, 72);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 7;
            label3.Text = "Daily Total Amount";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lbldailySales);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(158, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 3;
            // 
            // lbldailySales
            // 
            lbldailySales.AutoSize = true;
            lbldailySales.BackColor = Color.Transparent;
            lbldailySales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldailySales.Location = new Point(80, 24);
            lbldailySales.Name = "lbldailySales";
            lbldailySales.Size = new Size(63, 25);
            lbldailySales.TabIndex = 3;
            lbldailySales.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 72);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 6;
            label2.Text = "Daily Sales Count";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 3;
            label5.Text = "Sales Overview";
            label5.Click += label5_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(label15);
            panel11.Location = new Point(259, 295);
            panel11.Name = "panel11";
            panel11.Size = new Size(735, 140);
            panel11.TabIndex = 8;
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
            panel15.Controls.Add(panel19);
            panel15.Controls.Add(panel17);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(label22);
            panel15.Location = new Point(259, 484);
            panel15.Name = "panel15";
            panel15.Size = new Size(735, 140);
            panel15.TabIndex = 9;
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
            // SalesClerkDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel15);
            Controls.Add(panel11);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            DoubleBuffered = true;
            Name = "SalesClerkDashboard";
            Text = "SalesClerkDashboard";
            Load += SalesClerkDashboard_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menupicbox).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label Menu;
        private PictureBox menupicbox;
        private Panel panel2;
        private Button btndashboard;
        private Button btncustomers;
        private Button btnsalestransaction;
        private Button btnordermanagement;
        private Button btnreporting;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblweeklySales;
        private Label label3;
        private Panel panel7;
        private Label lbldailySales;
        private Label label2;
        private Label label5;
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
        private Panel panel19;
        private Label lblmostselling;
        private Label label24;
        private Panel panel17;
        private Label lbltotalbooks;
        private Label label19;
        private Panel panel16;
        private Label lbltotalsuppliers;
        private Label label17;
        private Panel panel18;
        private Label lbltotalcustomers;
        private Label label21;
        private Label label22;
        private Button button1;
    }
}