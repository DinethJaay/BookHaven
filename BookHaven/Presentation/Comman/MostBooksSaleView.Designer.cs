namespace BookHaven.Presentation.Comman
{
    partial class MostBooksSaleView
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
            btnGenarate = new Button();
            dataGridView1 = new DataGridView();
            btnExport = new Button();
            panel1 = new Panel();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(283, 41);
            label1.TabIndex = 0;
            label1.Text = "Most Sold Books";
            // 
            // btnGenarate
            // 
            btnGenarate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.Location = new Point(683, 632);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(113, 33);
            btnGenarate.TabIndex = 1;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = true;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(861, 475);
            dataGridView1.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(818, 632);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(114, 33);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 64);
            panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(412, 637);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 28);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MostBooksSaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(btnExport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            DoubleBuffered = true;
            Name = "MostBooksSaleView";
            Text = "MostBooksSaleView";
            Load += MostBooksSaleView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnGenarate;
        private DataGridView dataGridView1;
        private Button btnExport;
        private Panel panel1;
        private Button btnBack;
    }
}