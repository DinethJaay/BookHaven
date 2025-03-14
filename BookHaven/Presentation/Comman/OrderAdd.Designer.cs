namespace BookHaven.Presentation.Comman
{
    partial class OrderAdd
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
            lblname = new Label();
            label1 = new Label();
            cmbsearchphone = new ComboBox();
            cmbsearchbook = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dtgcustomerdeatils = new DataGridView();
            dtgsearchbook = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtbookqunity = new TextBox();
            txtbookprice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblsubtotal = new Label();
            chkdiliverydetails = new CheckedListBox();
            txtaddress = new TextBox();
            label7 = new Label();
            btnorder = new Button();
            btnmanageorder = new Button();
            label8 = new Label();
            label9 = new Label();
            btnback = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblname);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 78);
            panel1.TabIndex = 0;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = SystemColors.Control;
            lblname.Location = new Point(23, 19);
            lblname.Name = "lblname";
            lblname.Size = new Size(186, 41);
            lblname.TabIndex = 0;
            lblname.Text = "Add Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(181, 112);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Customer";
            // 
            // cmbsearchphone
            // 
            cmbsearchphone.FormattingEnabled = true;
            cmbsearchphone.Location = new Point(304, 109);
            cmbsearchphone.Name = "cmbsearchphone";
            cmbsearchphone.Size = new Size(184, 23);
            cmbsearchphone.TabIndex = 2;
            cmbsearchphone.SelectedIndexChanged += cmbsearchphone_SelectedIndexChanged;
            // 
            // cmbsearchbook
            // 
            cmbsearchbook.FormattingEnabled = true;
            cmbsearchbook.Location = new Point(713, 103);
            cmbsearchbook.Name = "cmbsearchbook";
            cmbsearchbook.Size = new Size(192, 23);
            cmbsearchbook.TabIndex = 3;
            cmbsearchbook.SelectedIndexChanged += cmbsearchbook_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(628, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Search Book";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._4288270;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(911, 85);
            button1.Name = "button1";
            button1.Size = new Size(85, 47);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgcustomerdeatils
            // 
            dtgcustomerdeatils.BackgroundColor = SystemColors.ControlLightLight;
            dtgcustomerdeatils.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcustomerdeatils.Location = new Point(12, 141);
            dtgcustomerdeatils.Name = "dtgcustomerdeatils";
            dtgcustomerdeatils.Size = new Size(476, 102);
            dtgcustomerdeatils.TabIndex = 6;
            dtgcustomerdeatils.CellContentClick += dtgcustomerdeatils_CellContentClick;
            // 
            // dtgsearchbook
            // 
            dtgsearchbook.BackgroundColor = SystemColors.ControlLightLight;
            dtgsearchbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsearchbook.Location = new Point(514, 138);
            dtgsearchbook.Name = "dtgsearchbook";
            dtgsearchbook.Size = new Size(484, 105);
            dtgsearchbook.TabIndex = 7;
            dtgsearchbook.CellContentClick += dtgsearchbook_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(412, 273);
            label3.Name = "label3";
            label3.Size = new Size(216, 37);
            label3.TabIndex = 8;
            label3.Text = "Order Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(371, 335);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "Book Quntity";
            // 
            // txtbookqunity
            // 
            txtbookqunity.Location = new Point(458, 334);
            txtbookqunity.Name = "txtbookqunity";
            txtbookqunity.Size = new Size(242, 23);
            txtbookqunity.TabIndex = 10;
            txtbookqunity.TextChanged += txtbookqunity_TextChanged;
            // 
            // txtbookprice
            // 
            txtbookprice.Location = new Point(458, 387);
            txtbookprice.Name = "txtbookprice";
            txtbookprice.Size = new Size(242, 23);
            txtbookprice.TabIndex = 12;
            txtbookprice.TextChanged += txtbookprice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(371, 387);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(745, 350);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 13;
            label6.Text = "Sub Total";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.BackColor = Color.Transparent;
            lblsubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsubtotal.ForeColor = Color.Red;
            lblsubtotal.Location = new Point(868, 350);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(37, 21);
            lblsubtotal.TabIndex = 14;
            lblsubtotal.Text = "123";
            // 
            // chkdiliverydetails
            // 
            chkdiliverydetails.FormattingEnabled = true;
            chkdiliverydetails.Items.AddRange(new object[] { "PickUp", "Dilivery" });
            chkdiliverydetails.Location = new Point(458, 545);
            chkdiliverydetails.Name = "chkdiliverydetails";
            chkdiliverydetails.Size = new Size(80, 40);
            chkdiliverydetails.TabIndex = 15;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(458, 496);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(242, 23);
            txtaddress.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(371, 504);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 16;
            label7.Text = "Address";
            // 
            // btnorder
            // 
            btnorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorder.Location = new Point(412, 647);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(117, 34);
            btnorder.TabIndex = 18;
            btnorder.Text = "Place Order";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // btnmanageorder
            // 
            btnmanageorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmanageorder.Location = new Point(571, 647);
            btnmanageorder.Name = "btnmanageorder";
            btnmanageorder.Size = new Size(129, 34);
            btnmanageorder.TabIndex = 19;
            btnmanageorder.Text = "Manage Order";
            btnmanageorder.UseVisualStyleBackColor = true;
            btnmanageorder.Click += btnmanageorder_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(371, 545);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 20;
            label8.Text = "Order Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(412, 445);
            label9.Name = "label9";
            label9.Size = new Size(216, 21);
            label9.TabIndex = 21;
            label9.Text = "Enter Address and the Type";
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(745, 647);
            btnback.Name = "btnback";
            btnback.Size = new Size(171, 34);
            btnback.TabIndex = 22;
            btnback.Text = "Dashboard";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnback);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnmanageorder);
            Controls.Add(btnorder);
            Controls.Add(txtaddress);
            Controls.Add(label7);
            Controls.Add(chkdiliverydetails);
            Controls.Add(lblsubtotal);
            Controls.Add(label6);
            Controls.Add(txtbookprice);
            Controls.Add(label5);
            Controls.Add(txtbookqunity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtgsearchbook);
            Controls.Add(dtgcustomerdeatils);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbsearchbook);
            Controls.Add(cmbsearchphone);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "OrderAdd";
            Text = "OrderAdd";
            Load += OrderAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblname;
        private Label label1;
        private ComboBox cmbsearchphone;
        private ComboBox cmbsearchbook;
        private Label label2;
        private Button button1;
        private DataGridView dtgcustomerdeatils;
        private DataGridView dtgsearchbook;
        private Label label3;
        private Label label4;
        private TextBox txtbookqunity;
        private TextBox txtbookprice;
        private Label label5;
        private Label label6;
        private Label lblsubtotal;
        private CheckedListBox chkdiliverydetails;
        private TextBox txtaddress;
        private Label label7;
        private Button btnorder;
        private Button btnmanageorder;
        private Label label8;
        private Label label9;
        private Button btnback;
    }
}