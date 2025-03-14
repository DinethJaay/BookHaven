namespace BookHaven.Presentation.Staff
{
    partial class SalesReportDaily
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
            dgvDailySales = new DataGridView();
            btnExport = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(312, 41);
            label1.TabIndex = 0;
            label1.Text = "Daily Sales Report";
            // 
            // dgvDailySales
            // 
            dgvDailySales.BackgroundColor = SystemColors.ControlLightLight;
            dgvDailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDailySales.Location = new Point(80, 122);
            dgvDailySales.Name = "dgvDailySales";
            dgvDailySales.Size = new Size(838, 497);
            dgvDailySales.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(798, 645);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 35);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(405, 652);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 74);
            panel1.TabIndex = 4;
            // 
            // SalesReportDaily
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(dgvDailySales);
            DoubleBuffered = true;
            Name = "SalesReportDaily";
            Text = "SalesReportDaily";
            Load += SalesReportDaily_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvDailySales;
        private Button btnExport;
        private Button btnBack;
        private Panel panel1;
    }
}