namespace WinfromTuanJav.Resources
{
    partial class RegisterSystem
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
            this.name_register = new System.Windows.Forms.Label();
            this.password_register = new System.Windows.Forms.Label();
            this.Repassword_register = new System.Windows.Forms.Label();
            this.BT_register = new System.Windows.Forms.Button();
            this.BT_Goback = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_repass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.Location = new System.Drawing.Point(330, 25);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(111, 31);
            this.H1.TabIndex = 0;
            this.H1.Text = "Đăng Ký";
            // 
            // name_register
            // 
            this.name_register.AutoSize = true;
            this.name_register.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_register.Location = new System.Drawing.Point(119, 74);
            this.name_register.Name = "name_register";
            this.name_register.Size = new System.Drawing.Size(96, 23);
            this.name_register.TabIndex = 1;
            this.name_register.Text = "Họ và Tên";
            // 
            // password_register
            // 
            this.password_register.AutoSize = true;
            this.password_register.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_register.Location = new System.Drawing.Point(119, 128);
            this.password_register.Name = "password_register";
            this.password_register.Size = new System.Drawing.Size(88, 23);
            this.password_register.TabIndex = 2;
            this.password_register.Text = "Mật khẩu";
            // 
            // Repassword_register
            // 
            this.Repassword_register.AutoSize = true;
            this.Repassword_register.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repassword_register.Location = new System.Drawing.Point(120, 182);
            this.Repassword_register.Name = "Repassword_register";
            this.Repassword_register.Size = new System.Drawing.Size(121, 23);
            this.Repassword_register.TabIndex = 3;
            this.Repassword_register.Text = "Re Mật Khẩu";
            // 
            // BT_register
            // 
            this.BT_register.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_register.Location = new System.Drawing.Point(172, 262);
            this.BT_register.Name = "BT_register";
            this.BT_register.Size = new System.Drawing.Size(174, 67);
            this.BT_register.TabIndex = 4;
            this.BT_register.Text = "Đăng Ký";
            this.BT_register.UseVisualStyleBackColor = true;
            this.BT_register.Click += new System.EventHandler(this.BT_register_Click);
            // 
            // BT_Goback
            // 
            this.BT_Goback.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Goback.Location = new System.Drawing.Point(432, 262);
            this.BT_Goback.Name = "BT_Goback";
            this.BT_Goback.Size = new System.Drawing.Size(182, 67);
            this.BT_Goback.TabIndex = 5;
            this.BT_Goback.Text = "Quay Lại";
            this.BT_Goback.UseVisualStyleBackColor = true;
            this.BT_Goback.Click += new System.EventHandler(this.BT_Goback_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(296, 74);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(355, 20);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(296, 131);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(355, 20);
            this.textBox_pass.TabIndex = 7;
            // 
            // textBox_repass
            // 
            this.textBox_repass.Location = new System.Drawing.Point(296, 182);
            this.textBox_repass.Name = "textBox_repass";
            this.textBox_repass.Size = new System.Drawing.Size(355, 20);
            this.textBox_repass.TabIndex = 8;
            // 
            // RegisterSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_repass);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.BT_Goback);
            this.Controls.Add(this.BT_register);
            this.Controls.Add(this.Repassword_register);
            this.Controls.Add(this.password_register);
            this.Controls.Add(this.name_register);
            this.Controls.Add(this.H1);
            this.Name = "RegisterSystem";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label name_register;
        private System.Windows.Forms.Label password_register;
        private System.Windows.Forms.Label Repassword_register;
        private System.Windows.Forms.Button BT_register;
        private System.Windows.Forms.Button BT_Goback;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_repass;
    }
}