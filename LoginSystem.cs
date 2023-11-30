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
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private string Selected = "SELECT * FROM MyData WHERE username=@username AND password=@password";
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string password = textBox_password.Text;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(Selected, MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text);
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text);
            SqlDataReader myDataReader = MyCommand.ExecuteReader();
            if(myDataReader.Read())
            {
                this.Hide();
                ManagerSystem managerSystem = new ManagerSystem();
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
            RegisterSystem registerSystem = new RegisterSystem();
            registerSystem.Show();
        }
    }
}
