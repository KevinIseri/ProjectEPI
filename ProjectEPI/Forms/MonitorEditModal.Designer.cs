namespace ProjectEPI.Forms
{
    partial class MonitorEditModal
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PictureBoxCloseButton = new PictureBox();
            FieldMonitorEditModalMaturityDate = new DateTimePicker();
            LabelMonitorEditModalMaturityDate = new Label();
            ButtonUpdate = new Button();
            ButtonCancel = new Button();
            FieldMonitorEditModalIsActive = new CheckBox();
            FieldMonitorEditModalDescription = new TextBox();
            FieldMonitorEditModalName = new TextBox();
            LabelMonitorEditModalDescription = new Label();
            LabelMonitorEditModalName = new Label();
            LabelMonitorEditModalHandlingStatus = new Label();
            FieldMonitorEditModalHandlingStatus = new ComboBox();
            FieldMonitorEditModalId = new TextBox();
            LabelMonitorEditModalId = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(FieldMonitorEditModalMaturityDate);
            panel1.Controls.Add(LabelMonitorEditModalMaturityDate);
            panel1.Controls.Add(ButtonUpdate);
            panel1.Controls.Add(ButtonCancel);
            panel1.Controls.Add(FieldMonitorEditModalIsActive);
            panel1.Controls.Add(FieldMonitorEditModalDescription);
            panel1.Controls.Add(FieldMonitorEditModalName);
            panel1.Controls.Add(LabelMonitorEditModalDescription);
            panel1.Controls.Add(LabelMonitorEditModalName);
            panel1.Controls.Add(LabelMonitorEditModalHandlingStatus);
            panel1.Controls.Add(FieldMonitorEditModalHandlingStatus);
            panel1.Controls.Add(FieldMonitorEditModalId);
            panel1.Controls.Add(LabelMonitorEditModalId);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 340);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(161, 99, 245);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(PictureBoxCloseButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 30);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.window_alt;
            pictureBox1.Location = new Point(20, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 35;
            label1.Text = "Monitor";
            // 
            // PictureBoxCloseButton
            // 
            PictureBoxCloseButton.Cursor = Cursors.Hand;
            PictureBoxCloseButton.Image = Properties.Resources.delete;
            PictureBoxCloseButton.Location = new Point(518, 7);
            PictureBoxCloseButton.Name = "PictureBoxCloseButton";
            PictureBoxCloseButton.Size = new Size(20, 18);
            PictureBoxCloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxCloseButton.TabIndex = 31;
            PictureBoxCloseButton.TabStop = false;
            PictureBoxCloseButton.Click += PictureBoxCloseButtonClick;
            // 
            // FieldMonitorEditModalMaturityDate
            // 
            FieldMonitorEditModalMaturityDate.Cursor = Cursors.Hand;
            FieldMonitorEditModalMaturityDate.Format = DateTimePickerFormat.Short;
            FieldMonitorEditModalMaturityDate.Location = new Point(87, 210);
            FieldMonitorEditModalMaturityDate.Name = "FieldMonitorEditModalMaturityDate";
            FieldMonitorEditModalMaturityDate.Size = new Size(434, 23);
            FieldMonitorEditModalMaturityDate.TabIndex = 12;
            // 
            // LabelMonitorEditModalMaturityDate
            // 
            LabelMonitorEditModalMaturityDate.AutoSize = true;
            LabelMonitorEditModalMaturityDate.Location = new Point(20, 210);
            LabelMonitorEditModalMaturityDate.Name = "LabelMonitorEditModalMaturityDate";
            LabelMonitorEditModalMaturityDate.Size = new Size(54, 15);
            LabelMonitorEditModalMaturityDate.TabIndex = 11;
            LabelMonitorEditModalMaturityDate.Text = "Validade:";
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.FromArgb(86, 63, 223);
            ButtonUpdate.Cursor = Cursors.Hand;
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonUpdate.ForeColor = Color.White;
            ButtonUpdate.Location = new Point(160, 290);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(100, 30);
            ButtonUpdate.TabIndex = 10;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(237, 70, 55);
            ButtonCancel.Cursor = Cursors.Hand;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Location = new Point(290, 290);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(100, 30);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancelClick;
            // 
            // FieldMonitorEditModalIsActive
            // 
            FieldMonitorEditModalIsActive.AutoSize = true;
            FieldMonitorEditModalIsActive.Cursor = Cursors.Hand;
            FieldMonitorEditModalIsActive.Location = new Point(20, 250);
            FieldMonitorEditModalIsActive.Name = "FieldMonitorEditModalIsActive";
            FieldMonitorEditModalIsActive.RightToLeft = RightToLeft.Yes;
            FieldMonitorEditModalIsActive.Size = new Size(81, 19);
            FieldMonitorEditModalIsActive.TabIndex = 8;
            FieldMonitorEditModalIsActive.Text = "        :Ativo";
            FieldMonitorEditModalIsActive.UseVisualStyleBackColor = true;
            // 
            // FieldMonitorEditModalDescription
            // 
            FieldMonitorEditModalDescription.Cursor = Cursors.No;
            FieldMonitorEditModalDescription.Location = new Point(87, 130);
            FieldMonitorEditModalDescription.Name = "FieldMonitorEditModalDescription";
            FieldMonitorEditModalDescription.ReadOnly = true;
            FieldMonitorEditModalDescription.Size = new Size(434, 23);
            FieldMonitorEditModalDescription.TabIndex = 7;
            // 
            // FieldMonitorEditModalName
            // 
            FieldMonitorEditModalName.Cursor = Cursors.No;
            FieldMonitorEditModalName.Location = new Point(87, 90);
            FieldMonitorEditModalName.Name = "FieldMonitorEditModalName";
            FieldMonitorEditModalName.ReadOnly = true;
            FieldMonitorEditModalName.Size = new Size(434, 23);
            FieldMonitorEditModalName.TabIndex = 6;
            // 
            // LabelMonitorEditModalDescription
            // 
            LabelMonitorEditModalDescription.AutoSize = true;
            LabelMonitorEditModalDescription.Location = new Point(20, 130);
            LabelMonitorEditModalDescription.Name = "LabelMonitorEditModalDescription";
            LabelMonitorEditModalDescription.Size = new Size(61, 15);
            LabelMonitorEditModalDescription.TabIndex = 5;
            LabelMonitorEditModalDescription.Text = "Descrição:";
            // 
            // LabelMonitorEditModalName
            // 
            LabelMonitorEditModalName.AutoSize = true;
            LabelMonitorEditModalName.Location = new Point(20, 90);
            LabelMonitorEditModalName.Name = "LabelMonitorEditModalName";
            LabelMonitorEditModalName.Size = new Size(43, 15);
            LabelMonitorEditModalName.TabIndex = 4;
            LabelMonitorEditModalName.Text = "Nome:";
            // 
            // LabelMonitorEditModalHandlingStatus
            // 
            LabelMonitorEditModalHandlingStatus.AutoSize = true;
            LabelMonitorEditModalHandlingStatus.Location = new Point(20, 170);
            LabelMonitorEditModalHandlingStatus.Name = "LabelMonitorEditModalHandlingStatus";
            LabelMonitorEditModalHandlingStatus.Size = new Size(54, 15);
            LabelMonitorEditModalHandlingStatus.TabIndex = 3;
            LabelMonitorEditModalHandlingStatus.Text = "Tratativa:";
            // 
            // FieldMonitorEditModalHandlingStatus
            // 
            FieldMonitorEditModalHandlingStatus.FormattingEnabled = true;
            FieldMonitorEditModalHandlingStatus.Items.AddRange(new object[] { "Nenhuma", "Pendente", "Em andamento", "Finalizado" });
            FieldMonitorEditModalHandlingStatus.Location = new Point(87, 170);
            FieldMonitorEditModalHandlingStatus.Name = "FieldMonitorEditModalHandlingStatus";
            FieldMonitorEditModalHandlingStatus.Size = new Size(434, 23);
            FieldMonitorEditModalHandlingStatus.TabIndex = 2;
            // 
            // FieldMonitorEditModalId
            // 
            FieldMonitorEditModalId.Cursor = Cursors.No;
            FieldMonitorEditModalId.Location = new Point(87, 50);
            FieldMonitorEditModalId.Margin = new Padding(20, 20, 20, 40);
            FieldMonitorEditModalId.Name = "FieldMonitorEditModalId";
            FieldMonitorEditModalId.ReadOnly = true;
            FieldMonitorEditModalId.Size = new Size(434, 23);
            FieldMonitorEditModalId.TabIndex = 1;
            // 
            // LabelMonitorEditModalId
            // 
            LabelMonitorEditModalId.AutoSize = true;
            LabelMonitorEditModalId.Location = new Point(20, 50);
            LabelMonitorEditModalId.Name = "LabelMonitorEditModalId";
            LabelMonitorEditModalId.Size = new Size(23, 15);
            LabelMonitorEditModalId.TabIndex = 0;
            LabelMonitorEditModalId.Text = "Id: ";
            // 
            // MonitorEditModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 340);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitorEditModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MonitorEditModal";
            Load += MonitorEditModal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelMonitorEditModalId;
        private TextBox FieldMonitorEditModalId;
        private Label LabelMonitorEditModalHandlingStatus;
        private ComboBox FieldMonitorEditModalHandlingStatus;
        private Label LabelMonitorEditModalName;
        private Label LabelMonitorEditModalDescription;
        private TextBox FieldMonitorEditModalDescription;
        private TextBox FieldMonitorEditModalName;
        private CheckBox FieldMonitorEditModalIsActive;
        private Button ButtonCancel;
        private Button ButtonUpdate;
        private Label LabelMonitorEditModalMaturityDate;
        private DateTimePicker FieldMonitorEditModalMaturityDate;
        private Panel panel2;
        private PictureBox PictureBoxCloseButton;
        private PictureBox pictureBox1;
        private Label label1;
    }
}