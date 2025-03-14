namespace BookHaven.Presentation.Comman
{
    partial class BookInventoryViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInventoryViewForm));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtsearch = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtIsbn = new TextBox();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            btnAddBook = new Button();
            label8 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(486, 41);
            label1.TabIndex = 0;
            label1.Text = "Book Inventory Management";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 286);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(599, 131);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(265, 23);
            txtsearch.TabIndex = 2;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(233, 23);
            txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(56, 23);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtIsbn);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(66, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 246);
            panel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(696, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 41);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(565, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 41);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(479, 23);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(479, 76);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 13;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(479, 129);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(56, 129);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(56, 71);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(565, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(233, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(142, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(233, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtIsbn
            // 
            txtIsbn.Enabled = false;
            txtIsbn.Location = new Point(565, 68);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(233, 23);
            txtIsbn.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(142, 68);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(233, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(565, 15);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(233, 23);
            txtAuthor.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Transparent;
            btnAddBook.BackgroundImage = (Image)resources.GetObject("btnAddBook.BackgroundImage");
            btnAddBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBook.Location = new Point(817, 76);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(45, 38);
            btnAddBook.TabIndex = 6;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(522, 134);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 7;
            label8.Text = "Search";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 70);
            panel2.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(394, 184);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 41);
            btnBack.TabIndex = 17;
            btnBack.Text = "Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BookInventoryViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(label8);
            Controls.Add(btnAddBook);
            Controls.Add(panel1);
            Controls.Add(txtsearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "BookInventoryViewForm";
            Text = "BookInventoryViewForm";
            Load += BookInventoryViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private TextBox txtTitle;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtIsbn;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddBook;
        private Label label8;
        private Panel panel2;
        private Button btnBack;
    }
}