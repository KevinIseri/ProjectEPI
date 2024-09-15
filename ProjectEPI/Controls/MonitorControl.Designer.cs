namespace ProjectEPI.Controls
{
    partial class MonitorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LabelGridMonitorTitle = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(LabelGridMonitorTitle);
            panel1.Location = new Point(77, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 461);
            panel1.TabIndex = 0;
            // 
            // LabelGridMonitorTitle
            // 
            LabelGridMonitorTitle.AutoSize = true;
            LabelGridMonitorTitle.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelGridMonitorTitle.Location = new Point(25, 20);
            LabelGridMonitorTitle.Name = "LabelGridMonitorTitle";
            LabelGridMonitorTitle.Size = new Size(73, 23);
            LabelGridMonitorTitle.TabIndex = 0;
            LabelGridMonitorTitle.Text = "Monitor";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(694, 343);
            dataGridView1.TabIndex = 1;
            // 
            // MonitorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MonitorControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelGridMonitorTitle;
        private DataGridView dataGridView1;
    }
}
