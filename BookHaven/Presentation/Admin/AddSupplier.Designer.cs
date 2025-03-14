namespace BookHaven.Presentation.Admin
{
    partial class AddSupplier
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
            dtgsupplier = new DataGridView();
            label2 = new Label();
            txtsuppliername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtsupplierphonenumber = new TextBox();
            label5 = new Label();
            txtsupplieremail = new TextBox();
            label6 = new Label();
            txtsupplieraddress = new TextBox();
            btnaddsupplier = new Button();
            btnupdatesupplier = new Button();
            btndelete = new Button();
            btnclear = new Button();
            cmbsupplier = new ComboBox();
            label7 = new Label();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(374, 41);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management";
            label1.Click += label1_Click;
            // 
            // dtgsupplier
            // 
            dtgsupplier.BackgroundColor = SystemColors.ControlLightLight;
            dtgsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplier.Location = new Point(29, 156);
            dtgsupplier.Name = "dtgsupplier";
            dtgsupplier.Size = new Size(963, 227);
            dtgsupplier.TabIndex = 1;
            dtgsupplier.CellContentClick += dtgsupplier_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(452, 397);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 2;
            label2.Text = "Create Supplier";
            // 
            // txtsuppliername
            // 
            txtsuppliername.Location = new Point(402, 451);
            txtsuppliername.Name = "txtsuppliername";
            txtsuppliername.Size = new Size(322, 23);
            txtsuppliername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(286, 454);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(286, 557);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 6;
            label4.Text = "PhoneNumber";
            // 
            // txtsupplierphonenumber
            // 
            txtsupplierphonenumber.Location = new Point(402, 549);
            txtsupplierphonenumber.Name = "txtsupplierphonenumber";
            txtsupplierphonenumber.Size = new Size(322, 23);
            txtsupplierphonenumber.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(286, 508);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 8;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // txtsupplieremail
            // 
            txtsupplieremail.Location = new Point(402, 500);
            txtsupplieremail.Name = "txtsupplieremail";
            txtsupplieremail.Size = new Size(322, 23);
            txtsupplieremail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(286, 606);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // txtsupplieraddress
            // 
            txtsupplieraddress.Location = new Point(402, 598);
            txtsupplieraddress.Name = "txtsupplieraddress";
            txtsupplieraddress.Size = new Size(322, 23);
            txtsupplieraddress.TabIndex = 9;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.BackgroundImageLayout = ImageLayout.Zoom;
            btnaddsupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddsupplier.Location = new Point(402, 657);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(117, 41);
            btnaddsupplier.TabIndex = 11;
            btnaddsupplier.Text = "Save";
            btnaddsupplier.UseVisualStyleBackColor = true;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // btnupdatesupplier
            // 
            btnupdatesupplier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatesupplier.Location = new Point(566, 657);
            btnupdatesupplier.Name = "btnupdatesupplier";
            btnupdatesupplier.Size = new Size(116, 41);
            btnupdatesupplier.TabIndex = 12;
            btnupdatesupplier.Text = "Update";
            btnupdatesupplier.UseVisualStyleBackColor = true;
            btnupdatesupplier.Click += btnupdatesupplier_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(713, 657);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(113, 41);
            btndelete.TabIndex = 13;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(859, 657);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(112, 41);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(731, 106);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(261, 23);
            cmbsupplier.TabIndex = 15;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(646, 111);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 16;
            label7.Text = "Search";
            label7.Click += label7_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(232, 657);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(127, 41);
            btnDashboard.TabIndex = 17;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnDashboard);
            Controls.Add(label7);
            Controls.Add(cmbsupplier);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdatesupplier);
            Controls.Add(btnaddsupplier);
            Controls.Add(label6);
            Controls.Add(txtsupplieraddress);
            Controls.Add(label5);
            Controls.Add(txtsupplieremail);
            Controls.Add(label4);
            Controls.Add(txtsupplierphonenumber);
            Controls.Add(label3);
            Controls.Add(txtsuppliername);
            Controls.Add(label2);
            Controls.Add(dtgsupplier);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "AddSupplier";
            Text = "AddSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtgsupplier;
        private Label label2;
        private TextBox txtsuppliername;
        private Label label3;
        private Label label4;
        private TextBox txtsupplierphonenumber;
        private Label label5;
        private TextBox txtsupplieremail;
        private Label label6;
        private TextBox txtsupplieraddress;
        private Button btnaddsupplier;
        private Button btnupdatesupplier;
        private Button btndelete;
        private Button btnclear;
        private ComboBox cmbsupplier;
        private Label label7;
        private Button btnDashboard;
    }
}