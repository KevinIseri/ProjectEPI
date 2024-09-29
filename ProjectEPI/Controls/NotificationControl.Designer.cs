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
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            LabelSettingTitle = new Label();
            panel5 = new Panel();
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
            NotificationDataGridView.Size = new Size(991, 587);
            NotificationDataGridView.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(1023, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 165);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 20);
            panel3.TabIndex = 23;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.bell_f;
            pictureBox6.Location = new Point(19, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 272);
            panel2.TabIndex = 20;
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(52, 30);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(126, 23);
            LabelSettingTitle.TabIndex = 19;
            LabelSettingTitle.Text = "Notificações";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(0, 675);
            panel5.Name = "panel5";
            panel5.Size = new Size(1043, 20);
            panel5.TabIndex = 24;
            // 
            // NotificationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox6);
            Controls.Add(panel2);
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
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Label LabelSettingTitle;
        private Panel panel5;
    }
}
