using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinfromTuanJav.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinfromTuanJav
{
    public partial class LoginSystem : Form // đăng nhập
    {
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True"); // thay thế bằng Data của bạn
        private string Selected = "SELECT * FROM MyData WHERE username=@username AND password=@password"; // thay thế "MyData  = bảng csdl của bạn" - "usermame = biến của bạn đặt trong csdl"
                                                                                                          // - "password = biến mà bạn đặt trong csdl" cái @ thì để yên nhé
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void BT_Login_Click(object sender, EventArgs e) // hàm đăng nhập
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(Selected, MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text); // thay textBox_name.Text nếu bị gạch đỏ bằng tên của thanh textbox của bạn
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text); // thay textBox_password.Text nếu bị gạch đỏ bằng tên của thanh textbox của bạn
            SqlDataReader myDataReader = MyCommand.ExecuteReader();
            if(myDataReader.Read())
            {
                this.Hide();
                ManagerSystem managerSystem = new ManagerSystem(); // thay bằng tên của from quản lý ( from thứ 3 trong 3 from )!
                managerSystem.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản Mật Khẩu Sai!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MyConnection.Close();
        }

        private void BT_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterSystem registerSystem = new RegisterSystem(); // thay bằng tên của from quản lý ( from thứ 2 trong 3 from )!
            registerSystem.Show();
        }
    }
}
