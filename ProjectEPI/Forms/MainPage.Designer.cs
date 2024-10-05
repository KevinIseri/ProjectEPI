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
            LabelLoginTitle = new Label();
            LabelMainNotificationNumber = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            PictureBoxMinimizeButton = new PictureBox();
            pictureBox1 = new PictureBox();
            equipmentControl1 = new Controls.EquipmentControl();
            sectorControl1 = new Controls.SectorControl();
            settingControl1 = new Controls.SettingControl();
            notificationControl1 = new Controls.NotificationControl();
            monitorControl1 = new Controls.MonitorControl();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMainPageLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(33, 32, 70);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(221, 221, 221);
            button4.Location = new Point(0, 276);
            button4.Name = "button4";
            button4.Size = new Size(237, 45);
            button4.TabIndex = 3;
            button4.Text = "Equipamentos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += EquipmentsButtonClick;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(33, 32, 70);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(221, 221, 221);
            button3.Location = new Point(0, 232);
            button3.Name = "button3";
            button3.Size = new Size(237, 45);
            button3.TabIndex = 2;
            button3.Text = "Notificações   ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NotificationsButtonClick;
            // 
            // SectorButton
            // 
            SectorButton.Cursor = Cursors.Hand;
            SectorButton.FlatAppearance.BorderColor = Color.FromArgb(33, 32, 70);
            SectorButton.FlatStyle = FlatStyle.Flat;
            SectorButton.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SectorButton.ForeColor = Color.FromArgb(221, 221, 221);
            SectorButton.Location = new Point(0, 320);
            SectorButton.Name = "SectorButton";
            SectorButton.RightToLeft = RightToLeft.No;
            SectorButton.Size = new Size(237, 45);
            SectorButton.TabIndex = 2;
            SectorButton.Text = "Setores         ";
            SectorButton.UseVisualStyleBackColor = true;
            SectorButton.Click += SectorsButtonClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(33, 32, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(221, 221, 221);
            button1.Location = new Point(0, 189);
            button1.Name = "button1";
            button1.Size = new Size(237, 45);
            button1.TabIndex = 1;
            button1.Text = "Monitor         ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MonitorButtonClick;
            // 
            // PictureBoxMainPageLogo
            // 
            PictureBoxMainPageLogo.BackColor = Color.FromArgb(33, 32, 70);
            PictureBoxMainPageLogo.Image = Properties.Resources.helmet_main_prp_logo1;
            PictureBoxMainPageLogo.Location = new Point(59, 45);
            PictureBoxMainPageLogo.Name = "PictureBoxMainPageLogo";
            PictureBoxMainPageLogo.Size = new Size(118, 88);
            PictureBoxMainPageLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMainPageLogo.TabIndex = 0;
            PictureBoxMainPageLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 32, 70);
            panel2.Controls.Add(LabelLoginTitle);
            panel2.Controls.Add(LabelMainNotificationNumber);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(PictureBoxMainPageLogo);
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
            // LabelLoginTitle
            // 
            LabelLoginTitle.AutoSize = true;
            LabelLoginTitle.BackColor = Color.FromArgb(33, 32, 70);
            LabelLoginTitle.Font = new Font("Verdana", 14F);
            LabelLoginTitle.ForeColor = Color.White;
            LabelLoginTitle.Location = new Point(65, 132);
            LabelLoginTitle.Name = "LabelLoginTitle";
            LabelLoginTitle.Size = new Size(107, 23);
            LabelLoginTitle.TabIndex = 12;
            LabelLoginTitle.Text = "ProjectEPI";
            // 
            // LabelMainNotificationNumber
            // 
            LabelMainNotificationNumber.AutoSize = true;
            LabelMainNotificationNumber.BackColor = Color.FromArgb(33, 32, 70);
            LabelMainNotificationNumber.Font = new Font("Verdana", 8F, FontStyle.Bold);
            LabelMainNotificationNumber.ForeColor = Color.FromArgb(161, 99, 245);
            LabelMainNotificationNumber.Location = new Point(48, 235);
            LabelMainNotificationNumber.Name = "LabelMainNotificationNumber";
            LabelMainNotificationNumber.Size = new Size(23, 13);
            LabelMainNotificationNumber.TabIndex = 6;
            LabelMainNotificationNumber.Text = "10";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(33, 32, 70);
            pictureBox6.Image = Properties.Resources.settings;
            pictureBox6.Location = new Point(21, 372);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(33, 32, 70);
            pictureBox5.Image = Properties.Resources.industry_alt;
            pictureBox5.Location = new Point(21, 327);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(33, 32, 70);
            pictureBox4.Image = Properties.Resources.headphones;
            pictureBox4.Location = new Point(21, 284);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(33, 32, 70);
            pictureBox3.Image = Properties.Resources.pulse_f;
            pictureBox3.Location = new Point(21, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(33, 32, 70);
            pictureBox2.Image = Properties.Resources.bell_f;
            pictureBox2.Location = new Point(21, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(33, 32, 70);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 11F);
            button2.ForeColor = Color.FromArgb(221, 221, 221);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 364);
            button2.Name = "button2";
            button2.Size = new Size(237, 45);
            button2.TabIndex = 4;
            button2.Text = "Configurações";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SettingsButtonClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 35, 78);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(equipmentControl1);
            panel3.Controls.Add(sectorControl1);
            panel3.Controls.Add(settingControl1);
            panel3.Controls.Add(notificationControl1);
            panel3.Controls.Add(monitorControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(237, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 720);
            panel3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 26, 62);
            panel1.Controls.Add(PictureBoxMinimizeButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 25);
            panel1.TabIndex = 5;
            // 
            // PictureBoxMinimizeButton
            // 
            PictureBoxMinimizeButton.Cursor = Cursors.Hand;
            PictureBoxMinimizeButton.Image = Properties.Resources.minimize;
            PictureBoxMinimizeButton.Location = new Point(998, 3);
            PictureBoxMinimizeButton.Name = "PictureBoxMinimizeButton";
            PictureBoxMinimizeButton.Size = new Size(18, 18);
            PictureBoxMinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMinimizeButton.TabIndex = 13;
            PictureBoxMinimizeButton.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1022, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // equipmentControl1
            // 
            equipmentControl1.BackColor = Color.FromArgb(37, 35, 78);
            equipmentControl1.Location = new Point(0, 25);
            equipmentControl1.Name = "equipmentControl1";
            equipmentControl1.Size = new Size(1043, 695);
            equipmentControl1.TabIndex = 1;
            // 
            // sectorControl1
            // 
            sectorControl1.BackColor = Color.FromArgb(37, 35, 78);
            sectorControl1.Location = new Point(0, 25);
            sectorControl1.Name = "sectorControl1";
            sectorControl1.Size = new Size(1043, 695);
            sectorControl1.TabIndex = 0;
            // 
            // settingControl1
            // 
            settingControl1.BackColor = Color.FromArgb(37, 35, 78);
            settingControl1.Location = new Point(0, 25);
            settingControl1.Name = "settingControl1";
            settingControl1.Size = new Size(1043, 695);
            settingControl1.TabIndex = 4;
            // 
            // notificationControl1
            // 
            notificationControl1.BackColor = Color.FromArgb(37, 35, 78);
            notificationControl1.Location = new Point(0, 25);
            notificationControl1.Name = "notificationControl1";
            notificationControl1.Size = new Size(1043, 695);
            notificationControl1.TabIndex = 3;
            // 
            // monitorControl1
            // 
            monitorControl1.BackColor = Color.FromArgb(37, 35, 78);
            monitorControl1.Location = new Point(0, 25);
            monitorControl1.Name = "monitorControl1";
            monitorControl1.Size = new Size(1043, 695);
            monitorControl1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxMinimizeButton).EndInit();
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
        private Label LabelMainNotificationNumber;
        private Controls.SettingControl settingControl1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox PictureBoxMinimizeButton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label LabelLoginTitle;
    }
}