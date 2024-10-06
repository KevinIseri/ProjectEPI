namespace ProjectEPI.Forms
{
    partial class SectorModal
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PictureBoxCloseButton = new PictureBox();
            FieldSectorId = new TextBox();
            LabelSectorId = new Label();
            LabelSectorName = new Label();
            FieldSectorName = new TextBox();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
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
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(FieldSectorId);
            panel2.Controls.Add(LabelSectorId);
            panel2.Controls.Add(LabelSectorName);
            panel2.Controls.Add(FieldSectorName);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 200);
            panel2.TabIndex = 2;
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
            panel1.Size = new Size(548, 30);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.window_alt;
            pictureBox1.Location = new Point(20, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 33;
            label1.Text = "Setor";
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
            // FieldSectorId
            // 
            FieldSectorId.Cursor = Cursors.No;
            FieldSectorId.Location = new Point(69, 50);
            FieldSectorId.Name = "FieldSectorId";
            FieldSectorId.ReadOnly = true;
            FieldSectorId.Size = new Size(451, 23);
            FieldSectorId.TabIndex = 17;
            // 
            // LabelSectorId
            // 
            LabelSectorId.AutoSize = true;
            LabelSectorId.Location = new Point(20, 50);
            LabelSectorId.Name = "LabelSectorId";
            LabelSectorId.Size = new Size(20, 15);
            LabelSectorId.TabIndex = 16;
            LabelSectorId.Text = "Id:";
            // 
            // LabelSectorName
            // 
            LabelSectorName.AutoSize = true;
            LabelSectorName.Location = new Point(20, 90);
            LabelSectorName.Name = "LabelSectorName";
            LabelSectorName.Size = new Size(43, 15);
            LabelSectorName.TabIndex = 15;
            LabelSectorName.Text = "Nome:";
            // 
            // FieldSectorName
            // 
            FieldSectorName.Location = new Point(69, 90);
            FieldSectorName.Name = "FieldSectorName";
            FieldSectorName.Size = new Size(451, 23);
            FieldSectorName.TabIndex = 14;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.FromArgb(86, 63, 223);
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(225, 150);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(100, 30);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAddClick;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(237, 70, 55);
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(290, 150);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(100, 30);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDeleteClick;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.FromArgb(86, 63, 223);
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ButtonUpdate.ForeColor = Color.White;
            ButtonUpdate.Location = new Point(160, 150);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(100, 30);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // SectorModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 200);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SectorModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SectorModal";
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
        private TextBox FieldSectorId;
        private Label LabelSectorId;
        private Label LabelSectorName;
        private TextBox FieldSectorName;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonUpdate;
        private Panel panel1;
        private PictureBox PictureBoxCloseButton;
        private PictureBox pictureBox1;
        private Label label1;
    }
}