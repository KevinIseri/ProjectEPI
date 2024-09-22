namespace ProjectEPI.Controls
{
    partial class NotificationControl
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
            NotificationDataGridView = new DataGridView();
            LabelGridMonitorTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(NotificationDataGridView);
            panel1.Controls.Add(LabelGridMonitorTitle);
            panel1.Location = new Point(30, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 495);
            panel1.TabIndex = 0;
            // 
            // NotificationDataGridView
            // 
            NotificationDataGridView.AllowUserToAddRows = false;
            NotificationDataGridView.AllowUserToDeleteRows = false;
            NotificationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotificationDataGridView.Location = new Point(24, 69);
            NotificationDataGridView.Name = "NotificationDataGridView";
            NotificationDataGridView.ReadOnly = true;
            NotificationDataGridView.Size = new Size(777, 364);
            NotificationDataGridView.TabIndex = 2;
            NotificationDataGridView.CellClick += DataGridView1CellClick;
            // 
            // LabelGridMonitorTitle
            // 
            LabelGridMonitorTitle.AutoSize = true;
            LabelGridMonitorTitle.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelGridMonitorTitle.Location = new Point(24, 19);
            LabelGridMonitorTitle.Name = "LabelGridMonitorTitle";
            LabelGridMonitorTitle.Size = new Size(109, 23);
            LabelGridMonitorTitle.TabIndex = 1;
            LabelGridMonitorTitle.Text = "Notificações";
            // 
            // NotificationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "NotificationControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelGridMonitorTitle;
        private DataGridView NotificationDataGridView;
    }
}
