namespace ProjectEPI.Controls
{
    partial class SectorControl
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
            SectorDataGridView = new DataGridView();
            pictureBox6 = new PictureBox();
            LabelSettingTitle = new Label();
            pictureBox1 = new PictureBox();
            Edit = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(SectorDataGridView);
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 587);
            panel1.TabIndex = 0;
            // 
            // SectorDataGridView
            // 
            SectorDataGridView.AllowUserToAddRows = false;
            SectorDataGridView.AllowUserToDeleteRows = false;
            SectorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SectorDataGridView.BackgroundColor = Color.FromArgb(37, 35, 78);
            SectorDataGridView.BorderStyle = BorderStyle.None;
            SectorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectorDataGridView.Columns.AddRange(new DataGridViewColumn[] { Edit });
            SectorDataGridView.Location = new Point(0, 0);
            SectorDataGridView.Name = "SectorDataGridView";
            SectorDataGridView.ReadOnly = true;
            SectorDataGridView.RowHeadersWidth = 21;
            SectorDataGridView.Size = new Size(991, 587);
            SectorDataGridView.TabIndex = 0;
            SectorDataGridView.CellClick += DataGridView1CellClick;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.industry_alt;
            pictureBox6.Location = new Point(21, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(52, 27);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(82, 23);
            LabelSettingTitle.TabIndex = 29;
            LabelSettingTitle.Text = "Setores";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.addbtn;
            pictureBox1.Location = new Point(140, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBoxAddClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit_pencil;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // SectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(LabelSettingTitle);
            Controls.Add(panel1);
            Name = "SectorControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView SectorDataGridView;
        private PictureBox pictureBox6;
        private Label LabelSettingTitle;
        private PictureBox pictureBox1;
        private DataGridViewImageColumn Edit;
    }
}
