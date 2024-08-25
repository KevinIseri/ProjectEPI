namespace ProjectEPI
{
    partial class SectorPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            DataGridViewSectors = new DataGridView();
            labelGridTitle = new Label();
            panel2 = new Panel();
            ButtonClear = new Button();
            TextBoxId = new TextBox();
            labelId = new Label();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            ButtonAdd = new Button();
            labelSectorName = new Label();
            TextBoxName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSectors).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(DataGridViewSectors);
            panel1.Controls.Add(labelGridTitle);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 192);
            panel1.TabIndex = 0;
            // 
            // DataGridViewSectors
            // 
            DataGridViewSectors.AllowUserToAddRows = false;
            DataGridViewSectors.AllowUserToDeleteRows = false;
            DataGridViewSectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSectors.EnableHeadersVisualStyles = false;
            DataGridViewSectors.Location = new Point(26, 60);
            DataGridViewSectors.Name = "DataGridViewSectors";
            DataGridViewSectors.ReadOnly = true;
            DataGridViewSectors.RowHeadersVisible = false;
            DataGridViewSectors.Size = new Size(703, 110);
            DataGridViewSectors.TabIndex = 1;
            DataGridViewSectors.CellClick += DataGridViewSectorsCellClick;
            // 
            // labelGridTitle
            // 
            labelGridTitle.AutoSize = true;
            labelGridTitle.Font = new Font("Tahoma", 14F);
            labelGridTitle.Location = new Point(21, 16);
            labelGridTitle.Name = "labelGridTitle";
            labelGridTitle.Size = new Size(72, 23);
            labelGridTitle.TabIndex = 0;
            labelGridTitle.Text = "Setores";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(ButtonClear);
            panel2.Controls.Add(TextBoxId);
            panel2.Controls.Add(labelId);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(labelSectorName);
            panel2.Controls.Add(TextBoxName);
            panel2.Location = new Point(21, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 205);
            panel2.TabIndex = 1;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(491, 161);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 9;
            ButtonClear.Text = "Limpar";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClearClick;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(52, 20);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(127, 23);
            TextBoxId.TabIndex = 8;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(26, 23);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 7;
            labelId.Text = "Id:";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(365, 161);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDeleteClick;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(229, 161);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 5;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(96, 161);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 4;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // labelSectorName
            // 
            labelSectorName.AutoSize = true;
            labelSectorName.Location = new Point(183, 23);
            labelSectorName.Name = "labelSectorName";
            labelSectorName.Size = new Size(43, 15);
            labelSectorName.TabIndex = 3;
            labelSectorName.Text = "Nome:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(229, 20);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(127, 23);
            TextBoxName.TabIndex = 2;
            // 
            // SectorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SectorPage";
            Text = "SectorPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSectors).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelGridTitle;
        private Panel panel2;
        private DataGridView DataGridViewSectors;
        private TextBox TextBoxName;
        private Label labelSectorName;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private Label labelId;
        private TextBox TextBoxId;
        private Button ButtonClear;
    }
}