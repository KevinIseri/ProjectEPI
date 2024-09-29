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
            ButtonAdd = new Button();
            panel1 = new Panel();
            LabelGridEquipmentTitle = new Label();
            EquipmentDataGridView = new DataGridView();
            Edit = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(204, 23);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ButtonAdd);
            panel1.Controls.Add(LabelGridEquipmentTitle);
            panel1.Controls.Add(EquipmentDataGridView);
            panel1.Location = new Point(14, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 205);
            panel1.TabIndex = 5;
            // 
            // LabelGridEquipmentTitle
            // 
            LabelGridEquipmentTitle.AutoSize = true;
            LabelGridEquipmentTitle.Font = new Font("Tahoma", 14F);
            LabelGridEquipmentTitle.Location = new Point(21, 20);
            LabelGridEquipmentTitle.Name = "LabelGridEquipmentTitle";
            LabelGridEquipmentTitle.Size = new Size(129, 23);
            LabelGridEquipmentTitle.TabIndex = 2;
            LabelGridEquipmentTitle.Text = "Equipamentos";
            // 
            // EquipmentDataGridView
            // 
            EquipmentDataGridView.AllowUserToAddRows = false;
            EquipmentDataGridView.AllowUserToDeleteRows = false;
            EquipmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EquipmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Edit });
            EquipmentDataGridView.Location = new Point(21, 60);
            EquipmentDataGridView.Name = "EquipmentDataGridView";
            EquipmentDataGridView.ReadOnly = true;
            EquipmentDataGridView.RowHeadersWidth = 21;
            EquipmentDataGridView.Size = new Size(968, 111);
            EquipmentDataGridView.TabIndex = 0;
            EquipmentDataGridView.CellClick += DataGridView1CellClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.grid_edit_icon;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 5;
            // 
            // EquipmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EquipmentControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonAdd;
        private Panel panel1;
        private Label LabelGridEquipmentTitle;
        private DataGridView EquipmentDataGridView;
        private DataGridViewImageColumn Edit;
    }
}
