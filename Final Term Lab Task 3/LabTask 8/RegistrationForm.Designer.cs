
namespace LabTask_8
{
    partial class RegistrationForm
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
            this.firstname_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateofbirth_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogIn_Label
            // 
            this.LogIn_Label.AutoSize = true;
            this.LogIn_Label.BackColor = System.Drawing.SystemColors.Control;
            this.LogIn_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_Label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LogIn_Label.Location = new System.Drawing.Point(12, 9);
            this.LogIn_Label.Name = "LogIn_Label";
            this.LogIn_Label.Size = new System.Drawing.Size(213, 26);
            this.LogIn_Label.TabIndex = 5;
            this.LogIn_Label.Text = "Personal Information\n";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_label.Location = new System.Drawing.Point(100, 62);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(91, 21);
            this.firstname_label.TabIndex = 6;
            this.firstname_label.Text = "First Name:";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_label.Location = new System.Drawing.Point(101, 105);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(88, 21);
            this.lastname_label.TabIndex = 7;
            this.lastname_label.Text = "Last Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(199, 65);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserName.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(199, 108);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateofbirth_label
            // 
            this.dateofbirth_label.AutoSize = true;
            this.dateofbirth_label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth_label.Location = new System.Drawing.Point(86, 151);
            this.dateofbirth_label.Name = "dateofbirth_label";
            this.dateofbirth_label.Size = new System.Drawing.Size(103, 21);
            this.dateofbirth_label.TabIndex = 11;
            this.dateofbirth_label.Text = "Date of Birth:";
            this.dateofbirth_label.Click += new System.EventHandler(this.dateofbirth_label_Click);
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(123, 199);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(66, 21);
            this.gender_label.TabIndex = 12;
            this.gender_label.Text = "Gender:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.dateofbirth_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.LogIn_Label);
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogIn_Label;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateofbirth_label;
        private System.Windows.Forms.Label gender_label;
    }
}