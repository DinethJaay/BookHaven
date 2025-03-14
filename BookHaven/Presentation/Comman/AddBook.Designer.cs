namespace BookHaven.Presentation.Comman
{
    partial class AddBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtIsbn = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbCategory = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnInventoryManagement = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(500, 127);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(500, 194);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(500, 264);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(500, 334);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(500, 403);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(500, 475);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(625, 127);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(309, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(625, 194);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(625, 264);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(309, 23);
            txtIsbn.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(625, 403);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(309, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(625, 475);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(309, 23);
            txtStock.TabIndex = 12;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(703, 574);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 37);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(834, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 37);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science Fiction", "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Historical", "Biography", "Self-Help", "Philosophy", "Psychology", "Health & Wellness", "Business", "Finance", "Technology", "Education", "Science", "Mathematics", "Poetry", "Drama", "Religion & Spirituality", "Travel", "Cookbooks", "Art & Photography", "Comics & Graphic Novels", "Children’s Books", "Young Adult", "Sports & Outdoors" });
            cmbCategory.Location = new Point(625, 331);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(309, 23);
            cmbCategory.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pngtree_open_book_icon_for_library_and_studying_in_head_vector_png_image_15477299_removebg_preview;
            pictureBox1.Location = new Point(44, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(29, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 548);
            panel1.TabIndex = 17;
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventoryManagement.Location = new Point(806, 647);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(128, 36);
            btnInventoryManagement.TabIndex = 0;
            btnInventoryManagement.Text = "Back to Inventory";
            btnInventoryManagement.UseVisualStyleBackColor = true;
            btnInventoryManagement.Click += btnInventoryManagement_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 70);
            panel2.TabIndex = 18;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnInventoryManagement);
            Controls.Add(pictureBox1);
            Controls.Add(cmbCategory);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtIsbn);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "AddBook";
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtIsbn;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbCategory;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnInventoryManagement;
        private Panel panel2;
    }
}