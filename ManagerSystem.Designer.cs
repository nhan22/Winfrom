namespace WinfromTuanJav.Resources
{
    partial class ManagerSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Get_id = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Changale = new System.Windows.Forms.Button();
            this.button_Referender = new System.Windows.Forms.Button();
            this.Colume1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colume2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colume3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colume1,
            this.Colume2,
            this.Colume3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Get_id
            // 
            this.Get_id.AutoSize = true;
            this.Get_id.Location = new System.Drawing.Point(23, 82);
            this.Get_id.Name = "Get_id";
            this.Get_id.Size = new System.Drawing.Size(30, 13);
            this.Get_id.TabIndex = 1;
            this.Get_id.Text = "ID = ";
            this.Get_id.Click += new System.EventHandler(this.Get_id_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(26, 13);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(371, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(26, 44);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(371, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(26, 111);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(121, 44);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Thêm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(154, 111);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(112, 44);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "Xóa";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Changale
            // 
            this.button_Changale.Location = new System.Drawing.Point(273, 111);
            this.button_Changale.Name = "button_Changale";
            this.button_Changale.Size = new System.Drawing.Size(124, 44);
            this.button_Changale.TabIndex = 6;
            this.button_Changale.Text = "Sửa";
            this.button_Changale.UseVisualStyleBackColor = true;
            this.button_Changale.Click += new System.EventHandler(this.button_Changale_Click);
            // 
            // button_Referender
            // 
            this.button_Referender.Location = new System.Drawing.Point(683, 382);
            this.button_Referender.Name = "button_Referender";
            this.button_Referender.Size = new System.Drawing.Size(105, 56);
            this.button_Referender.TabIndex = 7;
            this.button_Referender.Text = "Truy Xuất";
            this.button_Referender.UseVisualStyleBackColor = true;
            this.button_Referender.Click += new System.EventHandler(this.button_Referender_Click);
            // 
            // Colume1
            // 
            this.Colume1.DataPropertyName = "id";
            this.Colume1.HeaderText = "ID";
            this.Colume1.Name = "Colume1";
            // 
            // Colume2
            // 
            this.Colume2.DataPropertyName = "username";
            this.Colume2.HeaderText = "Tên Đăng Nhập";
            this.Colume2.Name = "Colume2";
            // 
            // Colume3
            // 
            this.Colume3.DataPropertyName = "password";
            this.Colume3.HeaderText = "Mật Khẩu";
            this.Colume3.Name = "Colume3";
            // 
            // button_Goback
            // 
            this.button_Goback.Location = new System.Drawing.Point(683, 328);
            this.button_Goback.Name = "button_Goback";
            this.button_Goback.Size = new System.Drawing.Size(105, 48);
            this.button_Goback.TabIndex = 8;
            this.button_Goback.Text = "Đăng Xuất";
            this.button_Goback.UseVisualStyleBackColor = true;
            this.button_Goback.Click += new System.EventHandler(this.button_Goback_Click);
            // 
            // ManagerSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_Goback);
            this.Controls.Add(this.button_Referender);
            this.Controls.Add(this.button_Changale);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.Get_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerSystem";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.ManagerSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Get_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Changale;
        private System.Windows.Forms.Button button_Referender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colume1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colume2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colume3;
        private System.Windows.Forms.Button button_Goback;
    }
}