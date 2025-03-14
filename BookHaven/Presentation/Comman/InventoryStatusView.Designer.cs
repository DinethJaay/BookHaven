namespace BookHaven.Presentation.Comman
{
    partial class InventoryStatusView
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
            btnexport = new Button();
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
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(284, 41);
            label1.TabIndex = 0;
            label1.Text = "Inventory Status";
            // 
            // btnGenarate
            // 
            btnGenarate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.Location = new Point(401, 610);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(105, 37);
            btnGenarate.TabIndex = 1;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = true;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(229, 471);
            dataGridView1.TabIndex = 2;
            // 
            // btnexport
            // 
            btnexport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexport.Location = new Point(519, 610);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(111, 37);
            btnexport.TabIndex = 3;
            btnexport.Text = "Export To Excel";
            btnexport.UseVisualStyleBackColor = true;
            btnexport.Click += btnexport_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(438, 673);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 75);
            panel1.TabIndex = 5;
            // 
            // InventoryStatusView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.normal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnexport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            DoubleBuffered = true;
            Name = "InventoryStatusView";
            Text = "InventoryStatusView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnGenarate;
        private DataGridView dataGridView1;
        private Button btnexport;
        private Button btnBack;
        private Panel panel1;
    }
}