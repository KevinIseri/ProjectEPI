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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
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
            panel1.Size = new Size(333, 466);
            panel1.TabIndex = 0;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(63, 407);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 10;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(198, 407);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancelClick;
            // 
            // FieldMonitorEditModalIsActive
            // 
            FieldMonitorEditModalIsActive.AutoSize = true;
            FieldMonitorEditModalIsActive.Location = new Point(16, 184);
            FieldMonitorEditModalIsActive.Name = "FieldMonitorEditModalIsActive";
            FieldMonitorEditModalIsActive.RightToLeft = RightToLeft.Yes;
            FieldMonitorEditModalIsActive.Size = new Size(57, 19);
            FieldMonitorEditModalIsActive.TabIndex = 8;
            FieldMonitorEditModalIsActive.Text = ":Ativo";
            FieldMonitorEditModalIsActive.UseVisualStyleBackColor = true;
            // 
            // FieldMonitorEditModalDescription
            // 
            FieldMonitorEditModalDescription.BorderStyle = BorderStyle.None;
            FieldMonitorEditModalDescription.Location = new Point(72, 114);
            FieldMonitorEditModalDescription.Name = "FieldMonitorEditModalDescription";
            FieldMonitorEditModalDescription.ReadOnly = true;
            FieldMonitorEditModalDescription.Size = new Size(181, 16);
            FieldMonitorEditModalDescription.TabIndex = 7;
            // 
            // FieldMonitorEditModalName
            // 
            FieldMonitorEditModalName.BorderStyle = BorderStyle.None;
            FieldMonitorEditModalName.Location = new Point(61, 82);
            FieldMonitorEditModalName.Name = "FieldMonitorEditModalName";
            FieldMonitorEditModalName.ReadOnly = true;
            FieldMonitorEditModalName.Size = new Size(181, 16);
            FieldMonitorEditModalName.TabIndex = 6;
            // 
            // LabelMonitorEditModalDescription
            // 
            LabelMonitorEditModalDescription.AutoSize = true;
            LabelMonitorEditModalDescription.Location = new Point(12, 114);
            LabelMonitorEditModalDescription.Name = "LabelMonitorEditModalDescription";
            LabelMonitorEditModalDescription.Size = new Size(61, 15);
            LabelMonitorEditModalDescription.TabIndex = 5;
            LabelMonitorEditModalDescription.Text = "Descrição:";
            // 
            // LabelMonitorEditModalName
            // 
            LabelMonitorEditModalName.AutoSize = true;
            LabelMonitorEditModalName.Location = new Point(12, 82);
            LabelMonitorEditModalName.Name = "LabelMonitorEditModalName";
            LabelMonitorEditModalName.Size = new Size(43, 15);
            LabelMonitorEditModalName.TabIndex = 4;
            LabelMonitorEditModalName.Text = "Nome:";
            // 
            // LabelMonitorEditModalHandlingStatus
            // 
            LabelMonitorEditModalHandlingStatus.AutoSize = true;
            LabelMonitorEditModalHandlingStatus.Location = new Point(12, 145);
            LabelMonitorEditModalHandlingStatus.Name = "LabelMonitorEditModalHandlingStatus";
            LabelMonitorEditModalHandlingStatus.Size = new Size(54, 15);
            LabelMonitorEditModalHandlingStatus.TabIndex = 3;
            LabelMonitorEditModalHandlingStatus.Text = "Tratativa:";
            // 
            // FieldMonitorEditModalHandlingStatus
            // 
            FieldMonitorEditModalHandlingStatus.FormattingEnabled = true;
            FieldMonitorEditModalHandlingStatus.Items.AddRange(new object[] { "Nenhuma", "Pendente", "Em andamento", "Finalizado" });
            FieldMonitorEditModalHandlingStatus.Location = new Point(72, 142);
            FieldMonitorEditModalHandlingStatus.Name = "FieldMonitorEditModalHandlingStatus";
            FieldMonitorEditModalHandlingStatus.Size = new Size(121, 23);
            FieldMonitorEditModalHandlingStatus.TabIndex = 2;
            // 
            // FieldMonitorEditModalId
            // 
            FieldMonitorEditModalId.BorderStyle = BorderStyle.None;
            FieldMonitorEditModalId.Location = new Point(40, 43);
            FieldMonitorEditModalId.Name = "FieldMonitorEditModalId";
            FieldMonitorEditModalId.ReadOnly = true;
            FieldMonitorEditModalId.Size = new Size(36, 16);
            FieldMonitorEditModalId.TabIndex = 1;
            // 
            // LabelMonitorEditModalId
            // 
            LabelMonitorEditModalId.AutoSize = true;
            LabelMonitorEditModalId.Location = new Point(11, 43);
            LabelMonitorEditModalId.Name = "LabelMonitorEditModalId";
            LabelMonitorEditModalId.Size = new Size(23, 15);
            LabelMonitorEditModalId.TabIndex = 0;
            LabelMonitorEditModalId.Text = "Id: ";
            // 
            // MonitorEditModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 466);
            Controls.Add(panel1);
            Name = "MonitorEditModal";
            Text = "MonitorEditModal";
            Load += MonitorEditModal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}