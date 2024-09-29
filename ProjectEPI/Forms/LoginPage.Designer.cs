namespace ProjectEPI
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelLoginUser = new Label();
            LabelLoginPass = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button_login = new Button();
            PictureBoxBackground = new PictureBox();
            LabelLoginTitle = new Label();
            PictureBoxLogo = new PictureBox();
            PictureBoxCloseButton = new PictureBox();
            PictureBoxMinimizeButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMinimizeButton).BeginInit();
            SuspendLayout();
            // 
            // LabelLoginUser
            // 
            LabelLoginUser.AutoSize = true;
            LabelLoginUser.BackColor = Color.Black;
            LabelLoginUser.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginUser.ForeColor = Color.White;
            LabelLoginUser.Location = new Point(290, 258);
            LabelLoginUser.Name = "LabelLoginUser";
            LabelLoginUser.Size = new Size(70, 18);
            LabelLoginUser.TabIndex = 1;
            LabelLoginUser.Text = "Usuário";
            // 
            // LabelLoginPass
            // 
            LabelLoginPass.AutoSize = true;
            LabelLoginPass.BackColor = Color.Black;
            LabelLoginPass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginPass.ForeColor = Color.White;
            LabelLoginPass.Location = new Point(290, 322);
            LabelLoginPass.Name = "LabelLoginPass";
            LabelLoginPass.Size = new Size(58, 18);
            LabelLoginPass.TabIndex = 2;
            LabelLoginPass.Text = "Senha";
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Verdana", 10F);
            txtUser.Location = new Point(290, 279);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(221, 24);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Verdana", 10F);
            txtPassword.Location = new Point(290, 343);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 24);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(86, 63, 223);
            button_login.Cursor = Cursors.Hand;
            button_login.FlatAppearance.BorderColor = Color.White;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(325, 400);
            button_login.Name = "button_login";
            button_login.Size = new Size(150, 40);
            button_login.TabIndex = 5;
            button_login.Text = "Entrar";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += ButtonLoginClick;
            // 
            // PictureBoxBackground
            // 
            PictureBoxBackground.Dock = DockStyle.Fill;
            PictureBoxBackground.Image = Properties.Resources.lgn_prp;
            PictureBoxBackground.Location = new Point(0, 0);
            PictureBoxBackground.Name = "PictureBoxBackground";
            PictureBoxBackground.Size = new Size(800, 550);
            PictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxBackground.TabIndex = 8;
            PictureBoxBackground.TabStop = false;
            PictureBoxBackground.MouseDown += MouseDown;
            PictureBoxBackground.MouseMove += MouseMove;
            // 
            // LabelLoginTitle
            // 
            LabelLoginTitle.AutoSize = true;
            LabelLoginTitle.BackColor = Color.Black;
            LabelLoginTitle.Font = new Font("Verdana", 22F);
            LabelLoginTitle.ForeColor = Color.White;
            LabelLoginTitle.Location = new Point(315, 168);
            LabelLoginTitle.Name = "LabelLoginTitle";
            LabelLoginTitle.Size = new Size(170, 36);
            LabelLoginTitle.TabIndex = 9;
            LabelLoginTitle.Text = "ProjectEPI";
            // 
            // PictureBoxLogo
            // 
            PictureBoxLogo.Anchor = AnchorStyles.None;
            PictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            PictureBoxLogo.Image = Properties.Resources.helmet_main_prp_logo;
            PictureBoxLogo.Location = new Point(342, 46);
            PictureBoxLogo.Name = "PictureBoxLogo";
            PictureBoxLogo.Size = new Size(116, 131);
            PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLogo.TabIndex = 10;
            PictureBoxLogo.TabStop = false;
            // 
            // PictureBoxCloseButton
            // 
            PictureBoxCloseButton.Cursor = Cursors.Hand;
            PictureBoxCloseButton.Image = Properties.Resources.delete;
            PictureBoxCloseButton.Location = new Point(774, 6);
            PictureBoxCloseButton.Name = "PictureBoxCloseButton";
            PictureBoxCloseButton.Size = new Size(20, 18);
            PictureBoxCloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxCloseButton.TabIndex = 11;
            PictureBoxCloseButton.TabStop = false;
            PictureBoxCloseButton.Click += CloseButtonClick;
            // 
            // PictureBoxMinimizeButton
            // 
            PictureBoxMinimizeButton.Cursor = Cursors.Hand;
            PictureBoxMinimizeButton.Image = Properties.Resources.minimize;
            PictureBoxMinimizeButton.Location = new Point(750, 6);
            PictureBoxMinimizeButton.Name = "PictureBoxMinimizeButton";
            PictureBoxMinimizeButton.Size = new Size(18, 18);
            PictureBoxMinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMinimizeButton.TabIndex = 12;
            PictureBoxMinimizeButton.TabStop = false;
            PictureBoxMinimizeButton.Click += MinimizeButtonClick;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(PictureBoxMinimizeButton);
            Controls.Add(PictureBoxCloseButton);
            Controls.Add(PictureBoxLogo);
            Controls.Add(LabelLoginTitle);
            Controls.Add(button_login);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(LabelLoginPass);
            Controls.Add(LabelLoginUser);
            Controls.Add(PictureBoxBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginFormLoad;
            ((System.ComponentModel.ISupportInitialize)PictureBoxBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMinimizeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelLoginUser;
        private Label LabelLoginPass;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button_login;
        private PictureBox PictureBoxBackground;
        private Label LabelLoginTitle;
        private PictureBox PictureBoxLogo;
        private PictureBox PictureBoxCloseButton;
        private PictureBox PictureBoxMinimizeButton;
    }
}
