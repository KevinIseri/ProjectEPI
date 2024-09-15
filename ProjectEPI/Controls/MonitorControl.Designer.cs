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
            MonitorDataGridView = new DataGridView();
            LabelGridMonitorTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MonitorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(MonitorDataGridView);
            panel1.Controls.Add(LabelGridMonitorTitle);
            panel1.Location = new Point(21, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 461);
            panel1.TabIndex = 0;
            // 
            // MonitorDataGridView
            // 
            MonitorDataGridView.AllowUserToAddRows = false;
            MonitorDataGridView.AllowUserToDeleteRows = false;
            MonitorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonitorDataGridView.Location = new Point(25, 77);
            MonitorDataGridView.Name = "MonitorDataGridView";
            MonitorDataGridView.ReadOnly = true;
            MonitorDataGridView.Size = new Size(813, 343);
            MonitorDataGridView.TabIndex = 1;
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
            // MonitorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MonitorControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MonitorDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelGridMonitorTitle;
        private DataGridView MonitorDataGridView;
    }
}
