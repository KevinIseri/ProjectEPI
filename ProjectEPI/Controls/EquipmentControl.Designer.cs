namespace ProjectEPI.Controls
{
    partial class EquipmentControl
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
            EquipmentDataGridView = new DataGridView();
            Edit = new DataGridViewImageColumn();
            pictureBox6 = new PictureBox();
            LabelSettingTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(EquipmentDataGridView);
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 587);
            panel1.TabIndex = 5;
            // 
            // EquipmentDataGridView
            // 
            EquipmentDataGridView.AllowUserToAddRows = false;
            EquipmentDataGridView.AllowUserToDeleteRows = false;
            EquipmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EquipmentDataGridView.BackgroundColor = Color.FromArgb(37, 35, 78);
            EquipmentDataGridView.BorderStyle = BorderStyle.None;
            EquipmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Edit });
            EquipmentDataGridView.Location = new Point(0, 0);
            EquipmentDataGridView.Name = "EquipmentDataGridView";
            EquipmentDataGridView.ReadOnly = true;
            EquipmentDataGridView.RowHeadersWidth = 21;
            EquipmentDataGridView.Size = new Size(991, 587);
            EquipmentDataGridView.TabIndex = 0;
            EquipmentDataGridView.CellClick += DataGridView1CellClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit_pencil;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.headphones;
            pictureBox6.Location = new Point(21, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(51, 27);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(145, 23);
            LabelSettingTitle.TabIndex = 24;
            LabelSettingTitle.Text = "Equipamentos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.addbtn;
            pictureBox1.Location = new Point(200, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBoxAddClick;
            // 
            // EquipmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Controls.Add(LabelSettingTitle);
            Name = "EquipmentControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView EquipmentDataGridView;
        private PictureBox pictureBox6;
        private Label LabelSettingTitle;
        private DataGridViewImageColumn Edit;
        private PictureBox pictureBox1;
    }
}
