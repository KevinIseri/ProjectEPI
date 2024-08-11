namespace ProjectEPI
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            txt_user = new TextBox();
            txt_password = new TextBox();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 108);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(310, 108);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(221, 23);
            txt_user.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(310, 146);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(221, 23);
            txt_password.TabIndex = 4;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login_exit);
            Controls.Add(button_login_clear);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_password;
        private Button button_login;
        private Button button_login_clear;
        private Button button_login_exit;
    }
}
