namespace BookHaven.Presentation.Comman
{
    partial class ReportDashboard
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
            btnSalesReport = new Button();
            btnBestBooksSelling = new Button();
            btnInventoryStatus = new Button();
            panel1 = new Panel();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(532, 41);
            label1.TabIndex = 0;
            label1.Text = "Report Management Dashboard";
            // 
            // btnSalesReport
            // 
            btnSalesReport.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.Location = new Point(278, 169);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(497, 100);
            btnSalesReport.TabIndex = 1;
            btnSalesReport.Text = "Sales Summery";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnBestBooksSelling
            // 
            btnBestBooksSelling.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBestBooksSelling.Location = new Point(278, 314);
            btnBestBooksSelling.Name = "btnBestBooksSelling";
            btnBestBooksSelling.Size = new Size(497, 100);
            btnBestBooksSelling.TabIndex = 2;
            btnBestBooksSelling.Text = "Best Books Selling";
            btnBestBooksSelling.UseVisualStyleBackColor = true;
            btnBestBooksSelling.Click += btnBestBooksSelling_Click;
            // 
            // btnInventoryStatus
            // 
            btnInventoryStatus.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventoryStatus.Location = new Point(278, 462);
            btnInventoryStatus.Name = "btnInventoryStatus";
            btnInventoryStatus.Size = new Size(497, 100);
            btnInventoryStatus.TabIndex = 3;
            btnInventoryStatus.Text = "Inventory Status";
            btnInventoryStatus.UseVisualStyleBackColor = true;
            btnInventoryStatus.Click += btnInventoryStatus_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 66);
            panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(422, 610);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 42);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReportDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(btnInventoryStatus);
            Controls.Add(btnBestBooksSelling);
            Controls.Add(btnSalesReport);
            DoubleBuffered = true;
            Name = "ReportDashboard";
            Text = "ReportDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSalesReport;
        private Button btnBestBooksSelling;
        private Button btnInventoryStatus;
        private Panel panel1;
        private Button btnBack;
    }
}