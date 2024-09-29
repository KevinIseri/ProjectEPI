namespace ProjectEPI.Forms
{
    partial class EquipmentEditModal
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
            panel2 = new Panel();
            FieldEquipmentSectors = new CheckedListBox();
            FieldEquipmenttEditModalStatus = new ComboBox();
            FieldEquipmenttEditModalMaturityDate = new DateTimePicker();
            LabelEquipmentMaturityDate = new Label();
            LabelEquipmentoSector = new Label();
            FieldEquipmenttEditModalIsActive = new CheckBox();
            LabelEquipmentStatus = new Label();
            LabelEquipmentDescription = new Label();
            FieldEquipmenttEditModalDescription = new TextBox();
            LabelEquipmentCA = new Label();
            FieldEquipmenttEditModalCA = new TextBox();
            FieldEquipmentEditModalId = new TextBox();
            LabelEquipmentId = new Label();
            LabelEquipmentName = new Label();
            FieldEquipmenttEditModalName = new TextBox();
            ButtonClear = new Button();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(FieldEquipmentSectors);
            panel2.Controls.Add(FieldEquipmenttEditModalStatus);
            panel2.Controls.Add(FieldEquipmenttEditModalMaturityDate);
            panel2.Controls.Add(LabelEquipmentMaturityDate);
            panel2.Controls.Add(LabelEquipmentoSector);
            panel2.Controls.Add(FieldEquipmenttEditModalIsActive);
            panel2.Controls.Add(LabelEquipmentStatus);
            panel2.Controls.Add(LabelEquipmentDescription);
            panel2.Controls.Add(FieldEquipmenttEditModalDescription);
            panel2.Controls.Add(LabelEquipmentCA);
            panel2.Controls.Add(FieldEquipmenttEditModalCA);
            panel2.Controls.Add(FieldEquipmentEditModalId);
            panel2.Controls.Add(LabelEquipmentId);
            panel2.Controls.Add(LabelEquipmentName);
            panel2.Controls.Add(FieldEquipmenttEditModalName);
            panel2.Controls.Add(ButtonClear);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(25, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 202);
            panel2.TabIndex = 7;
            // 
            // FieldEquipmentSectors
            // 
            FieldEquipmentSectors.FormattingEnabled = true;
            FieldEquipmentSectors.Location = new Point(300, 100);
            FieldEquipmentSectors.Name = "FieldEquipmentSectors";
            FieldEquipmentSectors.Size = new Size(303, 58);
            FieldEquipmentSectors.TabIndex = 30;
            // 
            // FieldEquipmenttEditModalStatus
            // 
            FieldEquipmenttEditModalStatus.FormattingEnabled = true;
            FieldEquipmenttEditModalStatus.Items.AddRange(new object[] { "Em conformidade", "A vencer", "Vencido" });
            FieldEquipmenttEditModalStatus.Location = new Point(82, 64);
            FieldEquipmenttEditModalStatus.Name = "FieldEquipmenttEditModalStatus";
            FieldEquipmenttEditModalStatus.Size = new Size(121, 23);
            FieldEquipmenttEditModalStatus.TabIndex = 29;
            // 
            // FieldEquipmenttEditModalMaturityDate
            // 
            FieldEquipmenttEditModalMaturityDate.Location = new Point(545, 64);
            FieldEquipmenttEditModalMaturityDate.Name = "FieldEquipmenttEditModalMaturityDate";
            FieldEquipmenttEditModalMaturityDate.Size = new Size(167, 23);
            FieldEquipmenttEditModalMaturityDate.TabIndex = 28;
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
            // LabelEquipmentoSector
            // 
            LabelEquipmentoSector.AutoSize = true;
            LabelEquipmentoSector.Location = new Point(300, 67);
            LabelEquipmentoSector.Name = "LabelEquipmentoSector";
            LabelEquipmentoSector.Size = new Size(37, 15);
            LabelEquipmentoSector.TabIndex = 25;
            LabelEquipmentoSector.Text = "Setor:";
            // 
            // FieldEquipmenttEditModalIsActive
            // 
            FieldEquipmenttEditModalIsActive.AutoSize = true;
            FieldEquipmenttEditModalIsActive.Cursor = Cursors.Hand;
            FieldEquipmenttEditModalIsActive.Location = new Point(225, 66);
            FieldEquipmenttEditModalIsActive.Name = "FieldEquipmenttEditModalIsActive";
            FieldEquipmenttEditModalIsActive.RightToLeft = RightToLeft.Yes;
            FieldEquipmenttEditModalIsActive.Size = new Size(57, 19);
            FieldEquipmenttEditModalIsActive.TabIndex = 24;
            FieldEquipmenttEditModalIsActive.Text = ":Ativo";
            FieldEquipmenttEditModalIsActive.TextAlign = ContentAlignment.MiddleCenter;
            FieldEquipmenttEditModalIsActive.UseVisualStyleBackColor = true;
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
            LabelEquipmentDescription.Size = new Size(120, 15);
            LabelEquipmentDescription.TabIndex = 19;
            LabelEquipmentDescription.Text = "Descrição (Opcional):";
            // 
            // FieldEquipmenttEditModalDescription
            // 
            FieldEquipmenttEditModalDescription.Location = new Point(656, 22);
            FieldEquipmenttEditModalDescription.Name = "FieldEquipmenttEditModalDescription";
            FieldEquipmenttEditModalDescription.Size = new Size(68, 23);
            FieldEquipmenttEditModalDescription.TabIndex = 18;
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
            // FieldEquipmenttEditModalCA
            // 
            FieldEquipmenttEditModalCA.Location = new Point(396, 22);
            FieldEquipmenttEditModalCA.Name = "FieldEquipmenttEditModalCA";
            FieldEquipmenttEditModalCA.Size = new Size(127, 23);
            FieldEquipmenttEditModalCA.TabIndex = 16;
            // 
            // FieldEquipmentEditModalId
            // 
            FieldEquipmentEditModalId.Location = new Point(48, 22);
            FieldEquipmentEditModalId.Name = "FieldEquipmentEditModalId";
            FieldEquipmentEditModalId.ReadOnly = true;
            FieldEquipmentEditModalId.Size = new Size(127, 23);
            FieldEquipmentEditModalId.TabIndex = 17;
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
            // FieldEquipmenttEditModalName
            // 
            FieldEquipmenttEditModalName.Location = new Point(225, 22);
            FieldEquipmenttEditModalName.Name = "FieldEquipmenttEditModalName";
            FieldEquipmenttEditModalName.Size = new Size(127, 23);
            FieldEquipmenttEditModalName.TabIndex = 14;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(516, 164);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 13;
            ButtonClear.Text = "Limpar";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClearClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(121, 164);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(390, 164);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDeleteClick;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(254, 164);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // EquipmentEditModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 440);
            Controls.Add(panel2);
            Name = "EquipmentEditModal";
            Text = "EquipmentEditModal";
            Load += EquipmentEditModal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CheckedListBox FieldEquipmentSectors;
        private ComboBox FieldEquipmenttEditModalStatus;
        private DateTimePicker FieldEquipmenttEditModalMaturityDate;
        private Label LabelEquipmentMaturityDate;
        private Label LabelEquipmentoSector;
        private CheckBox FieldEquipmenttEditModalIsActive;
        private Label LabelEquipmentStatus;
        private Label LabelEquipmentDescription;
        private TextBox FieldEquipmenttEditModalDescription;
        private Label LabelEquipmentCA;
        private TextBox FieldEquipmenttEditModalCA;
        private TextBox FieldEquipmentEditModalId;
        private Label LabelEquipmentId;
        private Label LabelEquipmentName;
        private TextBox FieldEquipmenttEditModalName;
        private Button ButtonClear;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
    }
}