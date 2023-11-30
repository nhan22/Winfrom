namespace WinfromTuanJav
{
    partial class LoginSystem
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
            this.H1 = new System.Windows.Forms.Label();
            this.Name_login = new System.Windows.Forms.Label();
            this.password_login = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.BT_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.Location = new System.Drawing.Point(316, 37);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(138, 31);
            this.H1.TabIndex = 0;
            this.H1.Text = "Đăng Nhập";
            // 
            // Name_login
            // 
            this.Name_login.AutoSize = true;
            this.Name_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_login.Location = new System.Drawing.Point(109, 101);
            this.Name_login.Name = "Name_login";
            this.Name_login.Size = new System.Drawing.Size(155, 23);
            this.Name_login.TabIndex = 1;
            this.Name_login.Text = "Tên Đăng Nhập : ";
            // 
            // password_login
            // 
            this.password_login.AutoSize = true;
            this.password_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login.Location = new System.Drawing.Point(155, 150);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(109, 23);
            this.password_login.TabIndex = 2;
            this.password_login.Text = "Mật Khẩu : ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(270, 105);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(290, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(271, 152);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(289, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // BT_Login
            // 
            this.BT_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.Location = new System.Drawing.Point(159, 229);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(189, 53);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "Đăng Nhập";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // BT_Register
            // 
            this.BT_Register.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Register.Location = new System.Drawing.Point(420, 229);
            this.BT_Register.Name = "BT_Register";
            this.BT_Register.Size = new System.Drawing.Size(166, 53);
            this.BT_Register.TabIndex = 6;
            this.BT_Register.Text = "Đăng Ký";
            this.BT_Register.UseVisualStyleBackColor = true;
            this.BT_Register.Click += new System.EventHandler(this.BT_Register_Click);
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Register);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.password_login);
            this.Controls.Add(this.Name_login);
            this.Controls.Add(this.H1);
            this.Name = "LoginSystem";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label Name_login;
        private System.Windows.Forms.Label password_login;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Button BT_Register;
    }
}

