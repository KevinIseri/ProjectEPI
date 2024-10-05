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
            pictureBox6 = new PictureBox();
            LabelSettingTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(NotificationDataGridView);
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 587);
            panel1.TabIndex = 0;
            // 
            // NotificationDataGridView
            // 
            NotificationDataGridView.AllowUserToAddRows = false;
            NotificationDataGridView.AllowUserToDeleteRows = false;
            NotificationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NotificationDataGridView.BackgroundColor = Color.FromArgb(37, 35, 78);
            NotificationDataGridView.BorderStyle = BorderStyle.None;
            NotificationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotificationDataGridView.Location = new Point(0, 0);
            NotificationDataGridView.Name = "NotificationDataGridView";
            NotificationDataGridView.ReadOnly = true;
            NotificationDataGridView.RowHeadersWidth = 21;
            NotificationDataGridView.Size = new Size(991, 587);
            NotificationDataGridView.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.bell_f;
            pictureBox6.Location = new Point(21, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(52, 27);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(126, 23);
            LabelSettingTitle.TabIndex = 19;
            LabelSettingTitle.Text = "Notificações";
            // 
            // NotificationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(pictureBox6);
            Controls.Add(LabelSettingTitle);
            Controls.Add(panel1);
            Name = "NotificationControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NotificationDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView NotificationDataGridView;
        private PictureBox pictureBox6;
        private Label LabelSettingTitle;
    }
}
