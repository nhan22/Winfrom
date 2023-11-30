using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfromTuanJav.Resources
{
    public partial class RegisterSystem : Form // đăng kí
    {
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True"); // thay thế bằng Data của bạn
        private string AddValues = "INSERT INTO MyData(username, password) VALUES(@username,@password)"; // thay thế "MyData  = bảng csdl của bạn" - "usermame = biến của bạn đặt trong csdl"
                                                                                                         // - "password = biến mà bạn đặt trong csdl" cái @ thì để yên nhé
        public RegisterSystem()
        {
            InitializeComponent();
        }

        private void BT_register_Click(object sender, EventArgs e) // Hàm Đăng Kí
        {
            if(textBox_Name.Text != "" || textBox_pass.Text != "" || textBox_repass.Text != "") // cái nào đỏ thì thay đúng với text box thôi
            {
                if(textBox_pass.Text.Equals(textBox_repass.Text)) // cái này là so sanh 2 pass trước và sau
                {
                    CallSQL(AddValues);
                    ExitRegister();
                }
                else
                {
                    MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExitRegister();
                }    
            }    
        }

        private void BT_Goback_Click(object sender, EventArgs e) // Hàm Nút Quay trở lại
        {
            ExitRegister();
        }
        private void CallSQL(string Query) // Như bên hàm Quản lý nhé cái nào đỏ thì thay
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(Query, MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_Name.Text);
            MyCommand.Parameters.AddWithValue("@password", textBox_pass.Text);
            int exex = MyCommand.ExecuteNonQuery();
            if (exex != 0) { MessageBox.Show("Thao tác dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            MyConnection.Close();
        }
        private void ExitRegister()
        {
            this.Close();
            LoginSystem loginSystem = new LoginSystem(); // // thay thế bằng tên From login (from thứ  1 trong 3 from )!
            loginSystem.Show();
        }
    }
}
