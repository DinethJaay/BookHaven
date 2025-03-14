namespace BookHaven.Presentation.Comman
{
    partial class OrderManage
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
            label1 = new Label();
            label2 = new Label();
            cmbsearchorder = new ComboBox();
            btnaddneworder = new Button();
            btnaddnewcustomer = new Button();
            dtgorder = new DataGridView();
            btndelete = new Button();
            btnupdate = new Button();
            cmborderstatus = new ComboBox();
            label3 = new Label();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(263, 41);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(319, 119);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Order";
            // 
            // cmbsearchorder
            // 
            cmbsearchorder.FormattingEnabled = true;
            cmbsearchorder.Location = new Point(423, 116);
            cmbsearchorder.Name = "cmbsearchorder";
            cmbsearchorder.Size = new Size(232, 23);
            cmbsearchorder.TabIndex = 2;
            cmbsearchorder.SelectedIndexChanged += cmbsearchorder_SelectedIndexChanged;
            // 
            // btnaddneworder
            // 
            btnaddneworder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddneworder.Location = new Point(821, 93);
            btnaddneworder.Name = "btnaddneworder";
            btnaddneworder.Size = new Size(87, 66);
            btnaddneworder.TabIndex = 3;
            btnaddneworder.Text = "Add New Order";
            btnaddneworder.UseVisualStyleBackColor = true;
            btnaddneworder.Click += btnaddneworder_Click;
            // 
            // btnaddnewcustomer
            // 
            btnaddnewcustomer.BackgroundImage = Properties.Resources._4288270;
            btnaddnewcustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnaddnewcustomer.Location = new Point(914, 93);
            btnaddnewcustomer.Name = "btnaddnewcustomer";
            btnaddnewcustomer.Size = new Size(82, 66);
            btnaddnewcustomer.TabIndex = 4;
            btnaddnewcustomer.UseVisualStyleBackColor = true;
            btnaddnewcustomer.Click += btnaddnewcustomer_Click;
            // 
            // dtgorder
            // 
            dtgorder.BackgroundColor = SystemColors.ControlLightLight;
            dtgorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgorder.Location = new Point(12, 169);
            dtgorder.Name = "dtgorder";
            dtgorder.Size = new Size(984, 350);
            dtgorder.TabIndex = 5;
            dtgorder.CellContentClick += dtgorder_CellContentClick;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(562, 611);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(93, 36);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(420, 611);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(92, 36);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // cmborderstatus
            // 
            cmborderstatus.FormattingEnabled = true;
            cmborderstatus.Items.AddRange(new object[] { "Pending", "Completed", "Canceled" });
            cmborderstatus.Location = new Point(420, 547);
            cmborderstatus.Name = "cmborderstatus";
            cmborderstatus.Size = new Size(235, 23);
            cmborderstatus.TabIndex = 8;
            cmborderstatus.SelectedIndexChanged += cmborderstatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(316, 550);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Order Status";
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(821, 669);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 38);
            btnDashboard.TabIndex = 10;
            btnDashboard.Text = "DashBoard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // OrderManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnDashboard);
            Controls.Add(label3);
            Controls.Add(cmborderstatus);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(dtgorder);
            Controls.Add(btnaddnewcustomer);
            Controls.Add(btnaddneworder);
            Controls.Add(cmbsearchorder);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "OrderManage";
            Text = "OrderManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsearchorder;
        private Button btnaddneworder;
        private Button btnaddnewcustomer;
        private DataGridView dtgorder;
        private Button btndelete;
        private Button btnupdate;
        private ComboBox cmborderstatus;
        private Label label3;
        private Button btnDashboard;
    }
}