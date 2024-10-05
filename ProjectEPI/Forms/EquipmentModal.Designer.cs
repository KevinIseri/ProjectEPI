namespace ProjectEPI.Forms
{
    partial class EquipmentModal
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
            FieldEquipmentModalStatus = new ComboBox();
            FieldEquipmentModalMaturityDate = new DateTimePicker();
            LabelEquipmentMaturityDate = new Label();
            LabelEquipmentoSector = new Label();
            FieldEquipmentModalIsActive = new CheckBox();
            LabelEquipmentStatus = new Label();
            LabelEquipmentDescription = new Label();
            FieldEquipmentModalDescription = new TextBox();
            LabelEquipmentCA = new Label();
            FieldEquipmentModalCA = new TextBox();
            FieldEquipmentModalId = new TextBox();
            LabelEquipmentId = new Label();
            LabelEquipmentName = new Label();
            FieldEquipmentModalName = new TextBox();
            ButtonDelete = new Button();
            ButtonAdd = new Button();
            ButtonUpdate = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PictureBoxCloseButton = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(FieldEquipmentSectors);
            panel2.Controls.Add(FieldEquipmentModalStatus);
            panel2.Controls.Add(FieldEquipmentModalMaturityDate);
            panel2.Controls.Add(LabelEquipmentMaturityDate);
            panel2.Controls.Add(LabelEquipmentoSector);
            panel2.Controls.Add(FieldEquipmentModalIsActive);
            panel2.Controls.Add(LabelEquipmentStatus);
            panel2.Controls.Add(LabelEquipmentDescription);
            panel2.Controls.Add(FieldEquipmentModalDescription);
            panel2.Controls.Add(LabelEquipmentCA);
            panel2.Controls.Add(FieldEquipmentModalCA);
            panel2.Controls.Add(FieldEquipmentModalId);
            panel2.Controls.Add(LabelEquipmentId);
            panel2.Controls.Add(LabelEquipmentName);
            panel2.Controls.Add(FieldEquipmentModalName);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 500);
            panel2.TabIndex = 7;
            // 
            // FieldEquipmentSectors
            // 
            FieldEquipmentSectors.Cursor = Cursors.Hand;
            FieldEquipmentSectors.FormattingEnabled = true;
            FieldEquipmentSectors.Location = new Point(148, 290);
            FieldEquipmentSectors.Name = "FieldEquipmentSectors";
            FieldEquipmentSectors.Size = new Size(382, 94);
            FieldEquipmentSectors.TabIndex = 30;
            // 
            // FieldEquipmentModalStatus
            // 
            FieldEquipmentModalStatus.FormattingEnabled = true;
            FieldEquipmentModalStatus.Items.AddRange(new object[] { "Em conformidade", "A vencer", "Vencido" });
            FieldEquipmentModalStatus.Location = new Point(148, 210);
            FieldEquipmentModalStatus.Name = "FieldEquipmentModalStatus";
            FieldEquipmentModalStatus.Size = new Size(382, 23);
            FieldEquipmentModalStatus.TabIndex = 29;
            // 
            // FieldEquipmentModalMaturityDate
            // 
            FieldEquipmentModalMaturityDate.Format = DateTimePickerFormat.Short;
            FieldEquipmentModalMaturityDate.Location = new Point(148, 250);
            FieldEquipmentModalMaturityDate.Name = "FieldEquipmentModalMaturityDate";
            FieldEquipmentModalMaturityDate.Size = new Size(382, 23);
            FieldEquipmentModalMaturityDate.TabIndex = 28;
            // 
            // LabelEquipmentMaturityDate
            // 
            LabelEquipmentMaturityDate.AutoSize = true;
            LabelEquipmentMaturityDate.Location = new Point(20, 250);
            LabelEquipmentMaturityDate.Name = "LabelEquipmentMaturityDate";
            LabelEquipmentMaturityDate.Size = new Size(54, 15);
            LabelEquipmentMaturityDate.TabIndex = 27;
            LabelEquipmentMaturityDate.Text = "Validade:";
            // 
            // LabelEquipmentoSector
            // 
            LabelEquipmentoSector.AutoSize = true;
            LabelEquipmentoSector.Location = new Point(20, 290);
            LabelEquipmentoSector.Name = "LabelEquipmentoSector";
            LabelEquipmentoSector.Size = new Size(37, 15);
            LabelEquipmentoSector.TabIndex = 25;
            LabelEquipmentoSector.Text = "Setor:";
            // 
            // FieldEquipmentModalIsActive
            // 
            FieldEquipmentModalIsActive.AutoSize = true;
            FieldEquipmentModalIsActive.Cursor = Cursors.Hand;
            FieldEquipmentModalIsActive.Location = new Point(20, 404);
            FieldEquipmentModalIsActive.Name = "FieldEquipmentModalIsActive";
            FieldEquipmentModalIsActive.RightToLeft = RightToLeft.Yes;
            FieldEquipmentModalIsActive.Size = new Size(141, 19);
            FieldEquipmentModalIsActive.TabIndex = 24;
            FieldEquipmentModalIsActive.Text = "                            :Ativo";
            FieldEquipmentModalIsActive.TextAlign = ContentAlignment.MiddleCenter;
            FieldEquipmentModalIsActive.UseVisualStyleBackColor = true;
            // 
            // LabelEquipmentStatus
            // 
            LabelEquipmentStatus.AutoSize = true;
            LabelEquipmentStatus.Location = new Point(20, 210);
            LabelEquipmentStatus.Name = "LabelEquipmentStatus";
            LabelEquipmentStatus.Size = new Size(42, 15);
            LabelEquipmentStatus.TabIndex = 21;
            LabelEquipmentStatus.Text = "Status:";
            // 
            // LabelEquipmentDescription
            // 
            LabelEquipmentDescription.AutoSize = true;
            LabelEquipmentDescription.Location = new Point(20, 170);
            LabelEquipmentDescription.Name = "LabelEquipmentDescription";
            LabelEquipmentDescription.Size = new Size(120, 15);
            LabelEquipmentDescription.TabIndex = 19;
            LabelEquipmentDescription.Text = "Descrição (Opcional):";
            // 
            // FieldEquipmentModalDescription
            // 
            FieldEquipmentModalDescription.Location = new Point(148, 170);
            FieldEquipmentModalDescription.Name = "FieldEquipmentModalDescription";
            FieldEquipmentModalDescription.Size = new Size(382, 23);
            FieldEquipmentModalDescription.TabIndex = 18;
            // 
            // LabelEquipmentCA
            // 
            LabelEquipmentCA.AutoSize = true;
            LabelEquipmentCA.Location = new Point(20, 130);
            LabelEquipmentCA.Name = "LabelEquipmentCA";
            LabelEquipmentCA.Size = new Size(32, 15);
            LabelEquipmentCA.TabIndex = 17;
            LabelEquipmentCA.Text = "C.A.:";
            // 
            // FieldEquipmentModalCA
            // 
            FieldEquipmentModalCA.Location = new Point(148, 130);
            FieldEquipmentModalCA.Margin = new Padding(20, 40, 20, 40);
            FieldEquipmentModalCA.Name = "FieldEquipmentModalCA";
            FieldEquipmentModalCA.Size = new Size(382, 23);
            FieldEquipmentModalCA.TabIndex = 16;
            // 
            // FieldEquipmentModalId
            // 
            FieldEquipmentModalId.Cursor = Cursors.No;
            FieldEquipmentModalId.Location = new Point(148, 50);
            FieldEquipmentModalId.Margin = new Padding(20, 20, 20, 40);
            FieldEquipmentModalId.Name = "FieldEquipmentModalId";
            FieldEquipmentModalId.ReadOnly = true;
            FieldEquipmentModalId.Size = new Size(382, 23);
            FieldEquipmentModalId.TabIndex = 17;
            // 
            // LabelEquipmentId
            // 
            LabelEquipmentId.AutoSize = true;
            LabelEquipmentId.Location = new Point(20, 50);
            LabelEquipmentId.Margin = new Padding(20, 0, 20, 0);
            LabelEquipmentId.Name = "LabelEquipmentId";
            LabelEquipmentId.Size = new Size(20, 15);
            LabelEquipmentId.TabIndex = 16;
            LabelEquipmentId.Text = "Id:";
            // 
            // LabelEquipmentName
            // 
            LabelEquipmentName.AutoSize = true;
            LabelEquipmentName.Location = new Point(20, 90);
            LabelEquipmentName.Name = "LabelEquipmentName";
            LabelEquipmentName.Size = new Size(43, 15);
            LabelEquipmentName.TabIndex = 15;
            LabelEquipmentName.Text = "Nome:";
            // 
            // FieldEquipmentModalName
            // 
            FieldEquipmentModalName.Location = new Point(148, 90);
            FieldEquipmentModalName.Margin = new Padding(20, 40, 20, 40);
            FieldEquipmentModalName.Name = "FieldEquipmentModalName";
            FieldEquipmentModalName.Size = new Size(382, 23);
            FieldEquipmentModalName.TabIndex = 14;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(237, 70, 55);
            ButtonDelete.Cursor = Cursors.Hand;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(290, 447);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(100, 30);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDeleteClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.FromArgb(86, 63, 223);
            ButtonAdd.Cursor = Cursors.Hand;
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(225, 447);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(100, 30);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.FromArgb(86, 63, 223);
            ButtonUpdate.Cursor = Cursors.Hand;
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.ForeColor = SystemColors.ButtonHighlight;
            ButtonUpdate.Location = new Point(160, 447);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(100, 30);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 99, 245);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PictureBoxCloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 30);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.window_alt;
            pictureBox1.Location = new Point(20, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 7);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 31;
            label1.Text = "Equipamento";
            // 
            // PictureBoxCloseButton
            // 
            PictureBoxCloseButton.Cursor = Cursors.Hand;
            PictureBoxCloseButton.Image = Properties.Resources.delete;
            PictureBoxCloseButton.Location = new Point(518, 6);
            PictureBoxCloseButton.Name = "PictureBoxCloseButton";
            PictureBoxCloseButton.Size = new Size(20, 18);
            PictureBoxCloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxCloseButton.TabIndex = 31;
            PictureBoxCloseButton.TabStop = false;
            PictureBoxCloseButton.Click += PictureBoxCloseButtonClick;
            // 
            // EquipmentModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 500);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EquipmentModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EquipmentEditModal";
            Load += EquipmentEditModal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CheckedListBox FieldEquipmentSectors;
        private ComboBox FieldEquipmentModalStatus;
        private DateTimePicker FieldEquipmentModalMaturityDate;
        private Label LabelEquipmentMaturityDate;
        private Label LabelEquipmentoSector;
        private CheckBox FieldEquipmentModalIsActive;
        private Label LabelEquipmentStatus;
        private Label LabelEquipmentDescription;
        private TextBox FieldEquipmentModalDescription;
        private Label LabelEquipmentCA;
        private TextBox FieldEquipmentModalCA;
        private TextBox FieldEquipmentModalId;
        private Label LabelEquipmentId;
        private Label LabelEquipmentName;
        private TextBox FieldEquipmentModalName;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private Panel panel1;
        private PictureBox PictureBoxCloseButton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}