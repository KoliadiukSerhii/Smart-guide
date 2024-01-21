namespace Coursework
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Coursework.Properties.Resources.AuthBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.registerLink);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 553);
            this.panel1.TabIndex = 0;
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.BackColor = System.Drawing.Color.Transparent;
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLink.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.Location = new System.Drawing.Point(304, 68);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(101, 35);
            this.registerLink.TabIndex = 7;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Sign Up!";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have account?";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(170, 300);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 50);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(112, 211);
            this.passwordInput.MaxLength = 32;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(312, 50);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(112, 144);
            this.emailInput.MaxLength = 100;
            this.emailInput.Multiline = true;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(312, 48);
            this.emailInput.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Coursework.Properties.Resources.password_icon;
            this.pictureBox2.Location = new System.Drawing.Point(58, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.email_icon;
            this.pictureBox1.Location = new System.Drawing.Point(58, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 553);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Label label2;
    }
}