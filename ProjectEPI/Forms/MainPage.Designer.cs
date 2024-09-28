namespace ProjectEPI
{
    partial class MainPage
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
            button4 = new Button();
            button3 = new Button();
            SectorButton = new Button();
            button1 = new Button();
            PictureBoxMainPageLogo = new PictureBox();
            panel2 = new Panel();
            LabelMainNotificationNumber = new Label();
            LabelMainCurrentNotifications = new Label();
            button2 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            notificationControl1 = new Controls.NotificationControl();
            settingControl1 = new Controls.SettingControl();
            monitorControl1 = new Controls.MonitorControl();
            equipmentControl1 = new Controls.EquipmentControl();
            sectorControl1 = new Controls.SectorControl();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMainPageLogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(51, 283);
            button4.Name = "button4";
            button4.Size = new Size(150, 25);
            button4.TabIndex = 3;
            button4.Text = "Equipamentos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += EquipmentsButtonClick;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(51, 239);
            button3.Name = "button3";
            button3.Size = new Size(150, 25);
            button3.TabIndex = 2;
            button3.Text = "Notificações";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NotificationsButtonClick;
            // 
            // SectorButton
            // 
            SectorButton.Cursor = Cursors.Hand;
            SectorButton.Location = new Point(51, 331);
            SectorButton.Name = "SectorButton";
            SectorButton.Size = new Size(150, 25);
            SectorButton.TabIndex = 2;
            SectorButton.Text = "Setores";
            SectorButton.UseVisualStyleBackColor = true;
            SectorButton.Click += SectorsButtonClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(51, 196);
            button1.Name = "button1";
            button1.Size = new Size(150, 25);
            button1.TabIndex = 1;
            button1.Text = "Monitor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MonitorButtonClick;
            // 
            // PictureBoxMainPageLogo
            // 
            PictureBoxMainPageLogo.BackColor = Color.FromArgb(33, 32, 70);
            PictureBoxMainPageLogo.Image = Properties.Resources.helmet_main_prp_logo1;
            PictureBoxMainPageLogo.Location = new Point(59, 30);
            PictureBoxMainPageLogo.Name = "PictureBoxMainPageLogo";
            PictureBoxMainPageLogo.Size = new Size(118, 88);
            PictureBoxMainPageLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMainPageLogo.TabIndex = 0;
            PictureBoxMainPageLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 32, 70);
            panel2.Controls.Add(PictureBoxMainPageLogo);
            panel2.Controls.Add(LabelMainNotificationNumber);
            panel2.Controls.Add(LabelMainCurrentNotifications);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(SectorButton);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 720);
            panel2.TabIndex = 5;
            // 
            // LabelMainNotificationNumber
            // 
            LabelMainNotificationNumber.AutoSize = true;
            LabelMainNotificationNumber.BackColor = SystemColors.HighlightText;
            LabelMainNotificationNumber.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelMainNotificationNumber.Location = new Point(112, 165);
            LabelMainNotificationNumber.Name = "LabelMainNotificationNumber";
            LabelMainNotificationNumber.Size = new Size(19, 19);
            LabelMainNotificationNumber.TabIndex = 6;
            LabelMainNotificationNumber.Text = "0";
            // 
            // LabelMainCurrentNotifications
            // 
            LabelMainCurrentNotifications.AutoSize = true;
            LabelMainCurrentNotifications.BackColor = SystemColors.HighlightText;
            LabelMainCurrentNotifications.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMainCurrentNotifications.Location = new Point(68, 137);
            LabelMainCurrentNotifications.Name = "LabelMainCurrentNotifications";
            LabelMainCurrentNotifications.Size = new Size(118, 16);
            LabelMainCurrentNotifications.TabIndex = 5;
            LabelMainCurrentNotifications.Text = "Notificações atuais:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(51, 378);
            button2.Name = "button2";
            button2.Size = new Size(150, 25);
            button2.TabIndex = 4;
            button2.Text = "Configurações";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SettingsButtonClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 35, 78);
            panel3.Controls.Add(settingControl1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(notificationControl1);
            panel3.Controls.Add(monitorControl1);
            panel3.Controls.Add(equipmentControl1);
            panel3.Controls.Add(sectorControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(237, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 720);
            panel3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 26, 62);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 27);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1001, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // notificationControl1
            // 
            notificationControl1.Location = new Point(3, 55);
            notificationControl1.Name = "notificationControl1";
            notificationControl1.Size = new Size(900, 575);
            notificationControl1.TabIndex = 3;
            // 
            // settingControl1
            // 
            settingControl1.Location = new Point(6, 30);
            settingControl1.Name = "settingControl1";
            settingControl1.Size = new Size(900, 575);
            settingControl1.TabIndex = 4;
            // 
            // monitorControl1
            // 
            monitorControl1.Location = new Point(81, 55);
            monitorControl1.Name = "monitorControl1";
            monitorControl1.Size = new Size(900, 575);
            monitorControl1.TabIndex = 2;
            // 
            // equipmentControl1
            // 
            equipmentControl1.Location = new Point(55, 55);
            equipmentControl1.Name = "equipmentControl1";
            equipmentControl1.Size = new Size(900, 575);
            equipmentControl1.TabIndex = 1;
            // 
            // sectorControl1
            // 
            sectorControl1.Location = new Point(81, 91);
            sectorControl1.Name = "sectorControl1";
            sectorControl1.Size = new Size(900, 575);
            sectorControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)PictureBoxMainPageLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PictureBoxMainPageLogo;
        private Button button3;
        private Button SectorButton;
        private Button button1;
        private Button button4;
        private Panel panel2;
        private Panel panel3;
        private Controls.SectorControl sectorControl1;
        private Controls.EquipmentControl equipmentControl1;
        private Controls.MonitorControl monitorControl1;
        private Button button2;
        private Controls.NotificationControl notificationControl1;
        private Label LabelMainCurrentNotifications;
        private Label LabelMainNotificationNumber;
        private Controls.SettingControl settingControl1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}