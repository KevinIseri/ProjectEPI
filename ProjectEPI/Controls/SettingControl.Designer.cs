namespace ProjectEPI.Controls
{
    partial class SettingControl
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
            ButtonUpdate = new Button();
            FieldSettingsNotificationsMaturityInterval = new TextBox();
            LabelSettingsNotificationsMaturityInterval = new Label();
            LabelSettingsNotificationsTitle = new Label();
            LabelSettingTitle = new Label();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ButtonUpdate);
            panel1.Controls.Add(FieldSettingsNotificationsMaturityInterval);
            panel1.Controls.Add(LabelSettingsNotificationsMaturityInterval);
            panel1.Controls.Add(LabelSettingsNotificationsTitle);
            panel1.Location = new Point(23, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 147);
            panel1.TabIndex = 0;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.FromArgb(86, 63, 223);
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.ForeColor = Color.White;
            ButtonUpdate.Location = new Point(329, 46);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 24);
            ButtonUpdate.TabIndex = 4;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // FieldSettingsNotificationsMaturityInterval
            // 
            FieldSettingsNotificationsMaturityInterval.Location = new Point(231, 46);
            FieldSettingsNotificationsMaturityInterval.Name = "FieldSettingsNotificationsMaturityInterval";
            FieldSettingsNotificationsMaturityInterval.Size = new Size(79, 23);
            FieldSettingsNotificationsMaturityInterval.TabIndex = 3;
            // 
            // LabelSettingsNotificationsMaturityInterval
            // 
            LabelSettingsNotificationsMaturityInterval.AutoSize = true;
            LabelSettingsNotificationsMaturityInterval.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingsNotificationsMaturityInterval.Location = new Point(15, 49);
            LabelSettingsNotificationsMaturityInterval.Name = "LabelSettingsNotificationsMaturityInterval";
            LabelSettingsNotificationsMaturityInterval.Size = new Size(210, 14);
            LabelSettingsNotificationsMaturityInterval.TabIndex = 2;
            LabelSettingsNotificationsMaturityInterval.Text = "Intervalo de dias para notificar: ";
            // 
            // LabelSettingsNotificationsTitle
            // 
            LabelSettingsNotificationsTitle.AutoSize = true;
            LabelSettingsNotificationsTitle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingsNotificationsTitle.Location = new Point(12, 12);
            LabelSettingsNotificationsTitle.Name = "LabelSettingsNotificationsTitle";
            LabelSettingsNotificationsTitle.Size = new Size(108, 18);
            LabelSettingsNotificationsTitle.TabIndex = 1;
            LabelSettingsNotificationsTitle.Text = "Notificações";
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.ForeColor = Color.FromArgb(221, 221, 221);
            LabelSettingTitle.Location = new Point(54, 27);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(146, 23);
            LabelSettingTitle.TabIndex = 0;
            LabelSettingTitle.Text = "Configurações";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(37, 35, 78);
            pictureBox6.Image = Properties.Resources.settings;
            pictureBox6.Location = new Point(21, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // SettingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 35, 78);
            Controls.Add(pictureBox6);
            Controls.Add(panel1);
            Controls.Add(LabelSettingTitle);
            Name = "SettingControl";
            Size = new Size(1043, 695);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LabelSettingTitle;
        private Label LabelSettingsNotificationsTitle;
        private Label LabelSettingsNotificationsMaturityInterval;
        private TextBox FieldSettingsNotificationsMaturityInterval;
        private Button ButtonUpdate;
        private PictureBox pictureBox6;
    }
}
