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
            LabelGridSectorTitle = new Label();
            SectorDataGridView = new DataGridView();
            ButtonAdd = new Button();
            Edit = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(LabelGridSectorTitle);
            panel1.Controls.Add(SectorDataGridView);
            panel1.Controls.Add(ButtonAdd);
            panel1.Location = new Point(40, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 202);
            panel1.TabIndex = 0;
            // 
            // LabelGridSectorTitle
            // 
            LabelGridSectorTitle.AutoSize = true;
            LabelGridSectorTitle.Font = new Font("Tahoma", 14F);
            LabelGridSectorTitle.Location = new Point(21, 20);
            LabelGridSectorTitle.Name = "LabelGridSectorTitle";
            LabelGridSectorTitle.Size = new Size(72, 23);
            LabelGridSectorTitle.TabIndex = 2;
            LabelGridSectorTitle.Text = "Setores";
            // 
            // SectorDataGridView
            // 
            SectorDataGridView.AllowUserToAddRows = false;
            SectorDataGridView.AllowUserToDeleteRows = false;
            SectorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SectorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectorDataGridView.Columns.AddRange(new DataGridViewColumn[] { Edit });
            SectorDataGridView.Location = new Point(21, 60);
            SectorDataGridView.Name = "SectorDataGridView";
            SectorDataGridView.ReadOnly = true;
            SectorDataGridView.RowHeadersWidth = 21;
            SectorDataGridView.Size = new Size(311, 111);
            SectorDataGridView.TabIndex = 0;
            SectorDataGridView.CellClick += DataGridView1CellClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(116, 20);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.grid_edit_icon;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // SectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SectorControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView SectorDataGridView;
        private Button ButtonAdd;
        private Label LabelGridSectorTitle;
        private DataGridViewImageColumn Edit;
    }
}
