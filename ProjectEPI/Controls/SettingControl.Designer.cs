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
            LabelSettingsNotificationsTitle = new Label();
            LabelSettingTitle = new Label();
            LabelSettingsNotificationsMaturityInterval = new Label();
            FieldSettingsNotificationsMaturityInterval = new TextBox();
            ButtonUpdate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ButtonUpdate);
            panel1.Controls.Add(FieldSettingsNotificationsMaturityInterval);
            panel1.Controls.Add(LabelSettingsNotificationsMaturityInterval);
            panel1.Controls.Add(LabelSettingsNotificationsTitle);
            panel1.Controls.Add(LabelSettingTitle);
            panel1.Location = new Point(41, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 459);
            panel1.TabIndex = 0;
            // 
            // LabelSettingsNotificationsTitle
            // 
            LabelSettingsNotificationsTitle.AutoSize = true;
            LabelSettingsNotificationsTitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingsNotificationsTitle.Location = new Point(29, 92);
            LabelSettingsNotificationsTitle.Name = "LabelSettingsNotificationsTitle";
            LabelSettingsNotificationsTitle.Size = new Size(93, 19);
            LabelSettingsNotificationsTitle.TabIndex = 1;
            LabelSettingsNotificationsTitle.Text = "Notificações";
            // 
            // LabelSettingTitle
            // 
            LabelSettingTitle.AutoSize = true;
            LabelSettingTitle.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSettingTitle.Location = new Point(19, 14);
            LabelSettingTitle.Name = "LabelSettingTitle";
            LabelSettingTitle.Size = new Size(128, 23);
            LabelSettingTitle.TabIndex = 0;
            LabelSettingTitle.Text = "Configurações";
            // 
            // LabelSettingsNotificationsMaturityInterval
            // 
            LabelSettingsNotificationsMaturityInterval.AutoSize = true;
            LabelSettingsNotificationsMaturityInterval.Location = new Point(29, 130);
            LabelSettingsNotificationsMaturityInterval.Name = "LabelSettingsNotificationsMaturityInterval";
            LabelSettingsNotificationsMaturityInterval.Size = new Size(172, 15);
            LabelSettingsNotificationsMaturityInterval.TabIndex = 2;
            LabelSettingsNotificationsMaturityInterval.Text = "Intervalo de dias para notificar: ";
            // 
            // FieldSettingsNotificationsMaturityInterval
            // 
            FieldSettingsNotificationsMaturityInterval.Location = new Point(207, 127);
            FieldSettingsNotificationsMaturityInterval.Name = "FieldSettingsNotificationsMaturityInterval";
            FieldSettingsNotificationsMaturityInterval.Size = new Size(100, 23);
            FieldSettingsNotificationsMaturityInterval.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(335, 130);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 4;
            ButtonUpdate.Text = "Atualizar";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdateClick;
            // 
            // SettingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SettingControl";
            Size = new Size(900, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelSettingTitle;
        private Label LabelSettingsNotificationsTitle;
        private Label LabelSettingsNotificationsMaturityInterval;
        private TextBox FieldSettingsNotificationsMaturityInterval;
        private Button ButtonUpdate;
    }
}
