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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            button4 = new Button();
            button3 = new Button();
            SectorButton = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            monitorControl1 = new Controls.MonitorControl();
            equipmentControl1 = new Controls.EquipmentControl();
            sectorControl1 = new Controls.SectorControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(21, 286);
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
            button3.Location = new Point(21, 240);
            button3.Name = "button3";
            button3.Size = new Size(150, 25);
            button3.TabIndex = 2;
            button3.Text = "Notificações";
            button3.UseVisualStyleBackColor = true;
            // 
            // SectorButton
            // 
            SectorButton.Cursor = Cursors.Hand;
            SectorButton.Location = new Point(21, 335);
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
            button1.Location = new Point(21, 196);
            button1.Name = "button1";
            button1.Size = new Size(150, 25);
            button1.TabIndex = 1;
            button1.Text = "Monitor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MonitorButtonClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Menu;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 25);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(SectorButton);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 575);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(monitorControl1);
            panel3.Controls.Add(equipmentControl1);
            panel3.Controls.Add(sectorControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 575);
            panel3.TabIndex = 6;
            // 
            // monitorControl1
            // 
            monitorControl1.Location = new Point(0, 0);
            monitorControl1.Name = "monitorControl1";
            monitorControl1.Size = new Size(900, 575);
            monitorControl1.TabIndex = 2;
            // 
            // equipmentControl1
            // 
            equipmentControl1.Location = new Point(0, 0);
            equipmentControl1.Name = "equipmentControl1";
            equipmentControl1.Size = new Size(900, 575);
            equipmentControl1.TabIndex = 1;
            // 
            // sectorControl1
            // 
            sectorControl1.Location = new Point(0, 0);
            sectorControl1.Name = "sectorControl1";
            sectorControl1.Size = new Size(900, 575);
            sectorControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button3;
        private Button SectorButton;
        private Button button1;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Controls.SectorControl sectorControl1;
        private Controls.EquipmentControl equipmentControl1;
        private Controls.MonitorControl monitorControl1;
    }
}