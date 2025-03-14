namespace BookHaven.Presentation.Admin
{
    partial class SupplierOrderForm
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
            cmbsupplier = new ComboBox();
            dtgsupplierorder = new DataGridView();
            btnplaceorder = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtnewstock = new TextBox();
            btnupdatestatus = new Button();
            dtgorderreq = new DataGridView();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgorderreq).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(477, 41);
            label1.TabIndex = 0;
            label1.Text = "Supplier Order Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(304, 101);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 1;
            label2.Text = "Search Supplier";
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(411, 98);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(348, 23);
            cmbsupplier.TabIndex = 2;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // dtgsupplierorder
            // 
            dtgsupplierorder.BackgroundColor = SystemColors.ControlLightLight;
            dtgsupplierorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplierorder.Location = new Point(150, 139);
            dtgsupplierorder.Name = "dtgsupplierorder";
            dtgsupplierorder.Size = new Size(710, 158);
            dtgsupplierorder.TabIndex = 3;
            dtgsupplierorder.CellContentClick += dtgsupplierorder_CellContentClick;
            // 
            // btnplaceorder
            // 
            btnplaceorder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplaceorder.Location = new Point(734, 496);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(124, 43);
            btnplaceorder.TabIndex = 4;
            btnplaceorder.Text = "Place Order";
            btnplaceorder.UseVisualStyleBackColor = true;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Approved", "Delivered", "Cancelled" });
            comboBox1.Location = new Point(498, 528);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(347, 529);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 5;
            label3.Text = "Order Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(347, 486);
            label4.Name = "label4";
            label4.Size = new Size(131, 17);
            label4.TabIndex = 7;
            label4.Text = "Enter Stock Amount";
            // 
            // txtnewstock
            // 
            txtnewstock.Location = new Point(498, 485);
            txtnewstock.Name = "txtnewstock";
            txtnewstock.Size = new Size(197, 23);
            txtnewstock.TabIndex = 8;
            // 
            // btnupdatestatus
            // 
            btnupdatestatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatestatus.Location = new Point(534, 573);
            btnupdatestatus.Name = "btnupdatestatus";
            btnupdatestatus.Size = new Size(132, 39);
            btnupdatestatus.TabIndex = 9;
            btnupdatestatus.Text = "Update";
            btnupdatestatus.UseVisualStyleBackColor = true;
            btnupdatestatus.Click += btnupdatestatus_Click;
            // 
            // dtgorderreq
            // 
            dtgorderreq.BackgroundColor = SystemColors.ControlLightLight;
            dtgorderreq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgorderreq.Location = new Point(150, 311);
            dtgorderreq.Name = "dtgorderreq";
            dtgorderreq.Size = new Size(710, 157);
            dtgorderreq.TabIndex = 10;
            dtgorderreq.CellContentClick += dtgorderreq_CellContentClick;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(734, 569);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(124, 43);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // SupplierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            ClientSize = new Size(1008, 689);
            Controls.Add(btnDashboard);
            Controls.Add(dtgorderreq);
            Controls.Add(btnupdatestatus);
            Controls.Add(txtnewstock);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(btnplaceorder);
            Controls.Add(dtgsupplierorder);
            Controls.Add(cmbsupplier);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SupplierOrderForm";
            Text = "SupplierOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgorderreq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsupplier;
        private DataGridView dtgsupplierorder;
        private Button btnplaceorder;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox txtnewstock;
        private Button btnupdatestatus;
        private DataGridView dtgorderreq;
        private Button btnDashboard;
    }
}