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
            FieldSectorId = new TextBox();
            LabelSectorId = new Label();
            LabelSectorName = new Label();
            FieldSectorName = new TextBox();
            ButtonAdd = new Button();
            ButtonDelete = new Button();
            ButtonUpdate = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(FieldSectorId);
            panel2.Controls.Add(LabelSectorId);
            panel2.Controls.Add(LabelSectorName);
            panel2.Controls.Add(FieldSectorName);
            panel2.Controls.Add(ButtonAdd);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(12, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 202);
            panel2.TabIndex = 2;
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
            // FieldSectorName
            // 
            FieldSectorName.Location = new Point(225, 22);
            FieldSectorName.Name = "FieldSectorName";
            FieldSectorName.Size = new Size(127, 23);
            FieldSectorName.TabIndex = 14;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(129, 137);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Adicionar";
            ButtonAdd.UseVisualStyleBackColor = true;
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
            // SectorModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "SectorModal";
            Text = "SectorModal";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}