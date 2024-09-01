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
            labelGridTitle = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            TextBoxId = new TextBox();
            labelId = new Label();
            labelSectorName = new Label();
            TextBoxName = new TextBox();
            ButtonClear = new Button();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labelGridTitle);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(40, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 202);
            panel1.TabIndex = 0;
            // 
            // labelGridTitle
            // 
            labelGridTitle.AutoSize = true;
            labelGridTitle.Font = new Font("Tahoma", 14F);
            labelGridTitle.Location = new Point(21, 20);
            labelGridTitle.Name = "labelGridTitle";
            labelGridTitle.Size = new Size(72, 23);
            labelGridTitle.TabIndex = 2;
            labelGridTitle.Text = "Setores";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(691, 111);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(TextBoxId);
            panel2.Controls.Add(labelId);
            panel2.Controls.Add(labelSectorName);
            panel2.Controls.Add(TextBoxName);
            panel2.Controls.Add(ButtonClear);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(40, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 202);
            panel2.TabIndex = 1;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(48, 22);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(127, 23);
            TextBoxId.TabIndex = 17;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(22, 25);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 16;
            labelId.Text = "Id:";
            // 
            // labelSectorName
            // 
            labelSectorName.AutoSize = true;
            labelSectorName.Location = new Point(179, 25);
            labelSectorName.Name = "labelSectorName";
            labelSectorName.Size = new Size(43, 15);
            labelSectorName.TabIndex = 15;
            labelSectorName.Text = "Nome:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(225, 22);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(127, 23);
            TextBoxName.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button ButtonClear;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private TextBox TextBoxId;
        private Label labelId;
        private Label labelSectorName;
        private TextBox TextBoxName;
        private Label labelGridTitle;
    }
}
