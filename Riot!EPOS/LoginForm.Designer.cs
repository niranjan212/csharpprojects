namespace Riot_EPOS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.LoginInfoLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.BackLoginButton = new System.Windows.Forms.Button();
            this.ClearLoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginWarningLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LogoPicture);
            this.LoginPanel.Controls.Add(this.LoginInfoLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.BackLoginButton);
            this.LoginPanel.Controls.Add(this.ClearLoginButton);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.PasswordTextBox);
            this.LoginPanel.Controls.Add(this.UsernameTextBox);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.LoginWarningLabel);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(404, 661);
            this.LoginPanel.TabIndex = 12;
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.InitialImage = null;
            this.LogoPicture.Location = new System.Drawing.Point(103, 46);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(195, 122);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // LoginInfoLabel
            // 
            this.LoginInfoLabel.AutoSize = true;
            this.LoginInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.LoginInfoLabel.Location = new System.Drawing.Point(99, 205);
            this.LoginInfoLabel.Name = "LoginInfoLabel";
            this.LoginInfoLabel.Size = new System.Drawing.Size(199, 21);
            this.LoginInfoLabel.TabIndex = 10;
            this.LoginInfoLabel.Text = "Please log in to continue";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.LoginLabel.Location = new System.Drawing.Point(161, 169);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 27);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Login";
            // 
            // BackLoginButton
            // 
            this.BackLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.BackLoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackLoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLoginButton.ForeColor = System.Drawing.Color.Black;
            this.BackLoginButton.Location = new System.Drawing.Point(103, 562);
            this.BackLoginButton.Name = "BackLoginButton";
            this.BackLoginButton.Size = new System.Drawing.Size(195, 40);
            this.BackLoginButton.TabIndex = 5;
            this.BackLoginButton.Text = "&Back";
            this.BackLoginButton.UseVisualStyleBackColor = false;
            // 
            // ClearLoginButton
            // 
            this.ClearLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearLoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearLoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLoginButton.ForeColor = System.Drawing.Color.Black;
            this.ClearLoginButton.Location = new System.Drawing.Point(103, 516);
            this.ClearLoginButton.Name = "ClearLoginButton";
            this.ClearLoginButton.Size = new System.Drawing.Size(195, 40);
            this.ClearLoginButton.TabIndex = 4;
            this.ClearLoginButton.Text = "&Clear";
            this.ClearLoginButton.UseVisualStyleBackColor = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.PasswordLabel.Location = new System.Drawing.Point(99, 321);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(89, 22);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.UsernameLabel.Location = new System.Drawing.Point(99, 246);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(90, 22);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(103, 344);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(195, 26);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(103, 271);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(195, 26);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.Text = "admin";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(188)))), ((int)(((byte)(194)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(103, 470);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(195, 40);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // LoginWarningLabel
            // 
            this.LoginWarningLabel.AutoSize = true;
            this.LoginWarningLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginWarningLabel.Location = new System.Drawing.Point(77, 395);
            this.LoginWarningLabel.Name = "LoginWarningLabel";
            this.LoginWarningLabel.Size = new System.Drawing.Size(246, 44);
            this.LoginWarningLabel.TabIndex = 6;
            this.LoginWarningLabel.Text = "Incorrect password!\r\nYou\'ve got 2 more attempts!";
            this.LoginWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginWarningLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 683);
            this.Controls.Add(this.LoginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label LoginInfoLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button BackLoginButton;
        private System.Windows.Forms.Button ClearLoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginWarningLabel;
    }
}