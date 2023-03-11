namespace ziekoSkincare
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            t_username = new TextBox();
            t_password = new TextBox();
            b_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 72);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 137);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // t_username
            // 
            t_username.Location = new Point(282, 69);
            t_username.Name = "t_username";
            t_username.Size = new Size(268, 31);
            t_username.TabIndex = 2;
            // 
            // t_password
            // 
            t_password.Location = new Point(282, 134);
            t_password.Name = "t_password";
            t_password.PasswordChar = '*';
            t_password.Size = new Size(268, 31);
            t_password.TabIndex = 3;
            // 
            // b_login
            // 
            b_login.Location = new Point(308, 190);
            b_login.Name = "b_login";
            b_login.Size = new Size(128, 53);
            b_login.TabIndex = 4;
            b_login.Text = "Login";
            b_login.UseVisualStyleBackColor = true;
            b_login.Click += b_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 320);
            Controls.Add(b_login);
            Controls.Add(t_password);
            Controls.Add(t_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox t_username;
        private TextBox t_password;
        private Button button1;
        private Button b_login;
    }
}