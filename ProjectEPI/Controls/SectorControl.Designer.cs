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
            panel2 = new Panel();
            FieldSectorId = new TextBox();
            LabelSectorId = new Label();
            LabelSectorName = new Label();
            FieldSectorName = new TextBox();
            ButtonClear = new Button();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(LabelGridSectorTitle);
            panel1.Controls.Add(SectorDataGridView);
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
            SectorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectorDataGridView.Location = new Point(21, 60);
            SectorDataGridView.Name = "SectorDataGridView";
            SectorDataGridView.ReadOnly = true;
            SectorDataGridView.Size = new Size(691, 111);
            SectorDataGridView.TabIndex = 0;
            SectorDataGridView.CellClick += DataGridView1CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(FieldSectorId);
            panel2.Controls.Add(LabelSectorId);
            panel2.Controls.Add(LabelSectorName);
            panel2.Controls.Add(FieldSectorName);
            panel2.Controls.Add(ButtonClear);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(40, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 202);
            panel2.TabIndex = 1;
            // 
            // FieldSectorId
            // 
            FieldSectorId.Location = new Point(48, 22);
            FieldSectorId.Name = "FieldSectorId";
            FieldSectorId.ReadOnly = true;
            FieldSectorId.Size = new Size(127, 23);
            FieldSectorId.TabIndex = 17;
            // 
            // LabelSectorId
            // 
            LabelSectorId.AutoSize = true;
            LabelSectorId.Location = new Point(22, 25);
            LabelSectorId.Name = "LabelSectorId";
            LabelSectorId.Size = new Size(20, 15);
            LabelSectorId.TabIndex = 16;
            LabelSectorId.Text = "Id:";
            // 
            // LabelSectorName
            // 
            LabelSectorName.AutoSize = true;
            LabelSectorName.Location = new Point(179, 25);
            LabelSectorName.Name = "LabelSectorName";
            LabelSectorName.Size = new Size(43, 15);
            LabelSectorName.TabIndex = 15;
            LabelSectorName.Text = "Nome:";
            // 
            // FieldTextName
            // 
            FieldSectorName.Location = new Point(225, 22);
            FieldSectorName.Name = "FieldTextName";
            FieldSectorName.Size = new Size(127, 23);
            FieldSectorName.TabIndex = 14;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(524, 137);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 13;
            ButtonClear.Text = "Limpar";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClearClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(129, 137);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(398, 137);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDeleteClick;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(262, 137);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // SectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SectorControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SectorDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView SectorDataGridView;
        private Button ButtonClear;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private TextBox FieldSectorId;
        private Label LabelSectorId;
        private Label LabelSectorName;
        private TextBox FieldSectorName;
        private Label LabelGridSectorTitle;
    }
}
