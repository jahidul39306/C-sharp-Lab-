
namespace LabTask_8
{
    partial class LogIn_Form
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
            this.LogIn_Label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn_Label
            // 
            this.LogIn_Label.AutoSize = true;
            this.LogIn_Label.BackColor = System.Drawing.SystemColors.Window;
            this.LogIn_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogIn_Label.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogIn_Label.Location = new System.Drawing.Point(331, 47);
            this.LogIn_Label.Name = "LogIn_Label";
            this.LogIn_Label.Size = new System.Drawing.Size(116, 36);
            this.LogIn_Label.TabIndex = 0;
            this.LogIn_Label.Text = "LogIn Form\r\n";
            this.LogIn_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(182, 156);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(94, 32);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "User Name:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(183, 226);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(81, 32);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(331, 159);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(331, 229);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(456, 294);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(116, 47);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 444);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.LogIn_Label);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LogIn_Form";
            this.Text = "LogIn From";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogIn_Label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button button_login;
    }
}

