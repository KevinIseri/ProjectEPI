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
            panel2 = new Panel();
            FieldEquipmentStatus = new ComboBox();
            FieldEquipmentMaturityDate = new DateTimePicker();
            LabelEquipmentMaturityDate = new Label();
            FieldEquipmentSector = new ComboBox();
            LabelEquipmentoSector = new Label();
            FieldEquipmentIsActive = new CheckBox();
            LabelEquipmentStatus = new Label();
            LabelEquipmentDescription = new Label();
            FieldEquipmentDescription = new TextBox();
            LabelEquipmentCA = new Label();
            FieldEquipmentCA = new TextBox();
            FieldEquipmentId = new TextBox();
            LabelEquipmentId = new Label();
            LabelEquipmentName = new Label();
            FieldEquipmentName = new TextBox();
            ButtonClear = new Button();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            panel1 = new Panel();
            LabelGridEquipmentTitle = new Label();
            EquipmentDataGridView = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(FieldEquipmentStatus);
            panel2.Controls.Add(FieldEquipmentMaturityDate);
            panel2.Controls.Add(LabelEquipmentMaturityDate);
            panel2.Controls.Add(FieldEquipmentSector);
            panel2.Controls.Add(LabelEquipmentoSector);
            panel2.Controls.Add(FieldEquipmentIsActive);
            panel2.Controls.Add(LabelEquipmentStatus);
            panel2.Controls.Add(LabelEquipmentDescription);
            panel2.Controls.Add(FieldEquipmentDescription);
            panel2.Controls.Add(LabelEquipmentCA);
            panel2.Controls.Add(FieldEquipmentCA);
            panel2.Controls.Add(FieldEquipmentId);
            panel2.Controls.Add(LabelEquipmentId);
            panel2.Controls.Add(LabelEquipmentName);
            panel2.Controls.Add(FieldEquipmentName);
            panel2.Controls.Add(ButtonClear);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(78, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 202);
            panel2.TabIndex = 6;
            // 
            // FieldEquipmentStatus
            // 
            FieldEquipmentStatus.FormattingEnabled = true;
            FieldEquipmentStatus.Items.AddRange(new object[] { "Em conformidade", "A vencer", "Vencido" });
            FieldEquipmentStatus.Location = new Point(82, 64);
            FieldEquipmentStatus.Name = "FieldEquipmentStatus";
            FieldEquipmentStatus.Size = new Size(121, 23);
            FieldEquipmentStatus.TabIndex = 29;
            // 
            // FieldEquipmentMaturityDate
            // 
            FieldEquipmentMaturityDate.Location = new Point(545, 64);
            FieldEquipmentMaturityDate.Name = "FieldEquipmentMaturityDate";
            FieldEquipmentMaturityDate.Size = new Size(167, 23);
            FieldEquipmentMaturityDate.TabIndex = 28;
            // 
            // LabelEquipmentMaturityDate
            // 
            LabelEquipmentMaturityDate.AutoSize = true;
            LabelEquipmentMaturityDate.Location = new Point(486, 67);
            LabelEquipmentMaturityDate.Name = "LabelEquipmentMaturityDate";
            LabelEquipmentMaturityDate.Size = new Size(54, 15);
            LabelEquipmentMaturityDate.TabIndex = 27;
            LabelEquipmentMaturityDate.Text = "Validade:";
            // 
            // FieldEquipmentSector
            // 
            FieldEquipmentSector.FormattingEnabled = true;
            FieldEquipmentSector.Location = new Point(343, 64);
            FieldEquipmentSector.Name = "FieldEquipmentSector";
            FieldEquipmentSector.Size = new Size(121, 23);
            FieldEquipmentSector.TabIndex = 26;
            // 
            // LabelEquipmentoSector
            // 
            LabelEquipmentoSector.AutoSize = true;
            LabelEquipmentoSector.Location = new Point(300, 67);
            LabelEquipmentoSector.Name = "LabelEquipmentoSector";
            LabelEquipmentoSector.Size = new Size(37, 15);
            LabelEquipmentoSector.TabIndex = 25;
            LabelEquipmentoSector.Text = "Setor:";
            // 
            // FieldEquipmentIsActive
            // 
            FieldEquipmentIsActive.AutoSize = true;
            FieldEquipmentIsActive.Cursor = Cursors.Hand;
            FieldEquipmentIsActive.Location = new Point(225, 66);
            FieldEquipmentIsActive.Name = "FieldEquipmentIsActive";
            FieldEquipmentIsActive.RightToLeft = RightToLeft.Yes;
            FieldEquipmentIsActive.Size = new Size(57, 19);
            FieldEquipmentIsActive.TabIndex = 24;
            FieldEquipmentIsActive.Text = ":Ativo";
            FieldEquipmentIsActive.TextAlign = ContentAlignment.MiddleCenter;
            FieldEquipmentIsActive.UseVisualStyleBackColor = true;
            // 
            // LabelEquipmentStatus
            // 
            LabelEquipmentStatus.AutoSize = true;
            LabelEquipmentStatus.Location = new Point(21, 67);
            LabelEquipmentStatus.Name = "LabelEquipmentStatus";
            LabelEquipmentStatus.Size = new Size(42, 15);
            LabelEquipmentStatus.TabIndex = 21;
            LabelEquipmentStatus.Text = "Status:";
            // 
            // LabelEquipmentDescription
            // 
            LabelEquipmentDescription.AutoSize = true;
            LabelEquipmentDescription.Location = new Point(530, 25);
            LabelEquipmentDescription.Name = "LabelEquipmentDescription";
            LabelEquipmentDescription.Size = new Size(61, 15);
            LabelEquipmentDescription.TabIndex = 19;
            LabelEquipmentDescription.Text = "Descrição:";
            // 
            // FieldEquipmentDescription
            // 
            FieldEquipmentDescription.Location = new Point(597, 22);
            FieldEquipmentDescription.Name = "FieldEquipmentDescription";
            FieldEquipmentDescription.Size = new Size(127, 23);
            FieldEquipmentDescription.TabIndex = 18;
            // 
            // LabelEquipmentCA
            // 
            LabelEquipmentCA.AutoSize = true;
            LabelEquipmentCA.Location = new Point(358, 25);
            LabelEquipmentCA.Name = "LabelEquipmentCA";
            LabelEquipmentCA.Size = new Size(32, 15);
            LabelEquipmentCA.TabIndex = 17;
            LabelEquipmentCA.Text = "C.A.:";
            // 
            // FieldEquipmentCA
            // 
            FieldEquipmentCA.Location = new Point(396, 22);
            FieldEquipmentCA.Name = "FieldEquipmentCA";
            FieldEquipmentCA.Size = new Size(127, 23);
            FieldEquipmentCA.TabIndex = 16;
            // 
            // FieldEquipmentId
            // 
            FieldEquipmentId.Location = new Point(48, 22);
            FieldEquipmentId.Name = "FieldEquipmentId";
            FieldEquipmentId.ReadOnly = true;
            FieldEquipmentId.Size = new Size(127, 23);
            FieldEquipmentId.TabIndex = 17;
            // 
            // LabelEquipmentId
            // 
            LabelEquipmentId.AutoSize = true;
            LabelEquipmentId.Location = new Point(22, 25);
            LabelEquipmentId.Name = "LabelEquipmentId";
            LabelEquipmentId.Size = new Size(20, 15);
            LabelEquipmentId.TabIndex = 16;
            LabelEquipmentId.Text = "Id:";
            // 
            // LabelEquipmentName
            // 
            LabelEquipmentName.AutoSize = true;
            LabelEquipmentName.Location = new Point(179, 25);
            LabelEquipmentName.Name = "LabelEquipmentName";
            LabelEquipmentName.Size = new Size(43, 15);
            LabelEquipmentName.TabIndex = 15;
            LabelEquipmentName.Text = "Nome:";
            // 
            // FieldEquipmentName
            // 
            FieldEquipmentName.Location = new Point(225, 22);
            FieldEquipmentName.Name = "FieldEquipmentName";
            FieldEquipmentName.Size = new Size(127, 23);
            FieldEquipmentName.TabIndex = 14;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(524, 137);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 13;
            ButtonClear.Text = "Limpar";
            ButtonClear.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(129, 137);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(398, 137);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(262, 137);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(LabelGridEquipmentTitle);
            panel1.Controls.Add(EquipmentDataGridView);
            panel1.Location = new Point(78, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 202);
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
            EquipmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipmentDataGridView.Location = new Point(21, 60);
            EquipmentDataGridView.Name = "EquipmentDataGridView";
            EquipmentDataGridView.ReadOnly = true;
            EquipmentDataGridView.Size = new Size(691, 111);
            EquipmentDataGridView.TabIndex = 0;
            // 
            // EquipmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EquipmentControl";
            Size = new Size(900, 575);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker FieldEquipmentMaturityDate;
        private Label LabelEquipmentMaturityDate;
        private ComboBox FieldEquipmentSector;
        private Label LabelEquipmentoSector;
        private CheckBox FieldEquipmentIsActive;
        private Label LabelEquipmentStatus;
        private Label LabelEquipmentDescription;
        private TextBox FieldEquipmentDescription;
        private Label LabelEquipmentCA;
        private TextBox FieldEquipmentCA;
        private TextBox FieldEquipmentId;
        private Label LabelEquipmentId;
        private Label LabelEquipmentName;
        private TextBox FieldEquipmentName;
        private Button ButtonClear;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private Panel panel1;
        private Label LabelGridEquipmentTitle;
        private DataGridView EquipmentDataGridView;
        private ComboBox FieldEquipmentStatus;
    }
}
