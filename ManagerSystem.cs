using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinfromTuanJav.Resources
{
    public partial class ManagerSystem : Form // quản lý
    {
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");    // thay thế bằng Data của bạn
        private string AddValues = "INSERT INTO MyData(username, password) VALUES(@username,@password)";    // thay thế "MyData  = bảng csdl của bạn" - "usermame = biến của bạn đặt trong csdl"
                                                                                                            // - "password = biến mà bạn đặt trong csdl" cái @ thì để yên nhé
        private string RemoValues = "DELETE FROM MyData WHERE @username=username AND @password=password";   // thay thế "MyData  = bảng csdl của bạn" - "usermame = biến của bạn đặt trong csdl"
                                                                                                            // - "password = biến mà bạn đặt trong csdl" cái @ thì để yên nhé

        string Id, username, userpassword; // biến lưu trữ để sử dụng dataGridView
        public ManagerSystem()
        {
            InitializeComponent();
        }
        private void ManagerSystem_Load(object sender, EventArgs e)
        {

        }

        private void Get_id_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e) // Hàm thêm account
        {
            CallSQL(AddValues);
        }

        private void button_Remove_Click(object sender, EventArgs e) // Hàm Xóa account
        {
            IsDeleteValues();
        }

        private void button_Changale_Click(object sender, EventArgs e) // Hàm thay đổi thông tin gồm mật khẩu và tên đăng nhập
        {
            int id = Convert.ToInt32(Get_id.Text);
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand($"UPDATE MyData SET username=@username, password=@password WHERE id={id}", MyConnection); // thay thế "MyData  = bảng csdl của bạn" - "usermame = biến của bạn đặt trong csdl"
                                                                                                                                            // - "password = biến mà bạn đặt trong csdl"
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text); // thay textBox_name.Text nếu bị gạch đỏ bằng tên của thanh textbox của bạn
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text); // thay textBox_password.Text nếu bị gạch đỏ bằng tên của thanh textbox của bạn
            int exex = MyCommand.ExecuteNonQuery();
            if (exex != 0) { MessageBox.Show("Thao tác dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            MyConnection.Close();
        }

        private void button_Referender_Click(object sender, EventArgs e) // Hàm Truy xuất cơ sở dữ liệu
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("SELECT * FROM MyData", MyConnection); // Thay thế "MyData = bảng csdl của bạn"
            DataTable MyTable = new DataTable();
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(MyCommand);
            MyDataAdapter.Fill(MyTable);
            dataGridView1.DataSource = MyTable;
            MyConnection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // click 2 - 3 lần để tạo hàm selected dataGridView này 
        {
            Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();  
            username = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userpassword = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Get_id.Text = Id;   // Thay Nếu nó đỏ
            textBox_name.Text = username;   // Thay Nếu nó đỏ
            textBox_password.Text = userpassword;   // Thay Nếu nó đỏ
        }

        private void button_Goback_Click(object sender, EventArgs e) // Hàm Quay lại From LoginSystem
        {
            this.Close();
            LoginSystem loginSystem = new LoginSystem(); // thay thế bằng tên From login ( from thứ 1 trong 3 from )!
            loginSystem.Show();
        }

        private void CallSQL(string Query) // Hàm gọi Query (đừng quan tâm đến nó cop và sửa 2 dòng texbox là được)!
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(Query, MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text); // thay
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text); // thay
            int exex = MyCommand.ExecuteNonQuery();
            if (exex != 0) { MessageBox.Show("Thao tác dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            MyConnection.Close();
        }
        private void IsDeleteValues() // Hàm hỏi bạn có muốn thực hiện không cop và không sửa gì cả
        {
            if (MessageBox.Show("Bạn có muốn thực hiện không ? (Yes/No)", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Debug
                CallSQL(RemoValues);
            }
        }

    }
}
