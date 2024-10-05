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
            Edit = new DataGridViewImageColumn();
            pictureBox6 = new PictureBox();
            LabelSettingTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MonitorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(MonitorDataGridView);
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 587);
            panel1.TabIndex = 0;
            // 
            // MonitorDataGridView
            // 
            MonitorDataGridView.AllowUserToAddRows = false;
            MonitorDataGridView.AllowUserToDeleteRows = false;
            MonitorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MonitorDataGridView.BackgroundColor = Color.FromArgb(37, 35, 78);
            MonitorDataGridView.BorderStyle = BorderStyle.None;
            MonitorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonitorDataGridView.Columns.AddRange(new DataGridViewColumn[] { Edit });
            MonitorDataGridView.Location = new Point(0, 0);
            MonitorDataGridView.Name = "MonitorDataGridView";
            MonitorDataGridView.ReadOnly = true;
            MonitorDataGridView.RowHeadersWidth = 21;
            MonitorDataGridView.Size = new Size(991, 587);
            MonitorDataGridView.TabIndex = 1;
            MonitorDataGridView.CellClick += DataGridView1CellClick;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.grid_edit_icon;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.pulse_f;
            pictureBox6.Location = new Point(21, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(53, 27);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(83, 23);
            LabelSettingTitle.TabIndex = 14;
            LabelSettingTitle.Text = "Monitor";
            // 
            // MonitorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(pictureBox6);
            Controls.Add(LabelSettingTitle);
            Controls.Add(panel1);
            Name = "MonitorControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MonitorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView MonitorDataGridView;
        private DataGridViewImageColumn Edit;
        private PictureBox pictureBox6;
        private Label LabelSettingTitle;
    }
}
