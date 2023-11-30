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
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private string AddValues = "INSERT INTO MyData(username, password) VALUES(@username,@password)";
        public RegisterSystem()
        {
            InitializeComponent();
        }

        private void BT_register_Click(object sender, EventArgs e)
        {
            if(textBox_Name.Text != "" || textBox_pass.Text != "" || textBox_repass.Text != "")
            {
                if(textBox_pass.Text.Equals(textBox_repass.Text))
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

        private void BT_Goback_Click(object sender, EventArgs e)
        {
            ExitRegister();
        }
        private void CallSQL(string Query)
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
            LoginSystem loginSystem = new LoginSystem();
            loginSystem.Show();
        }
    }
}
