namespace BookHaven.Presentation.Admin
{
    partial class SalesReportView
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnGenarate = new Button();
            btnExport = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 0;
            label1.Text = "Sales Reports";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(229, 135);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(209, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(628, 135);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(210, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(138, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(545, 143);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 4;
            label3.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(437, 91);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 5;
            label4.Text = "Select Date Range";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(848, 451);
            dataGridView1.TabIndex = 6;
            // 
            // btnGenarate
            // 
            btnGenarate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.Location = new Point(657, 654);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(113, 39);
            btnGenarate.TabIndex = 7;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = true;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(788, 654);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(125, 39);
            btnExport.TabIndex = 8;
            btnExport.Text = "Export As Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(384, 658);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 30);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 66);
            panel1.TabIndex = 10;
            // 
            // SalesReportView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(btnGenarate);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            DoubleBuffered = true;
            Name = "SalesReportView";
            Text = "SalesReportView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnGenarate;
        private Button btnExport;
        private Button btnBack;
        private Panel panel1;
    }
}