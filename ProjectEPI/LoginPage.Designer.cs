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
            label1 = new Label();
            labelUser = new Label();
            labelPass = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button_login = new Button();
            button_login_clear = new Button();
            button_login_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(225, 108);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(47, 15);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuário";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(225, 149);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(39, 15);
            labelPass.TabIndex = 2;
            labelPass.Text = "Senha";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(310, 108);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(221, 23);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 23);
            txtPassword.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new Point(456, 188);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 5;
            button_login.Text = "Entrar";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_login_clear
            // 
            button_login_clear.Location = new Point(310, 188);
            button_login_clear.Name = "button_login_clear";
            button_login_clear.Size = new Size(75, 23);
            button_login_clear.TabIndex = 6;
            button_login_clear.Text = "Limpar";
            button_login_clear.UseVisualStyleBackColor = true;
            button_login_clear.Click += button_login_clear_Click;
            // 
            // button_login_exit
            // 
            button_login_exit.Location = new Point(21, 404);
            button_login_exit.Name = "button_login_exit";
            button_login_exit.Size = new Size(75, 23);
            button_login_exit.TabIndex = 7;
            button_login_exit.Text = "Sair";
            button_login_exit.UseVisualStyleBackColor = true;
            button_login_exit.Click += button_login_exit_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login_exit);
            Controls.Add(button_login_clear);
            Controls.Add(button_login);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelUser;
        private Label labelPass;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button_login;
        private Button button_login_clear;
        private Button button_login_exit;
    }
}
