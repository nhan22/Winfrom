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
        SqlConnection MyConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private string AddValues = "INSERT INTO MyData(username, password) VALUES(@username,@password)";
        private string RemoValues = "DELETE FROM MyData WHERE @username=username AND @password=password";

        string Id, username, userpassword;
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

        private void button_Add_Click(object sender, EventArgs e)
        {
            CallSQL(AddValues);
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            IsDeleteValues();
        }

        private void button_Changale_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Get_id.Text);
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand($"UPDATE MyData SET username=@username, password=@password WHERE id={id}", MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text);
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text);
            int exex = MyCommand.ExecuteNonQuery();
            if (exex != 0) { MessageBox.Show("Thao tác dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            MyConnection.Close();
        }

        private void button_Referender_Click(object sender, EventArgs e)
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("SELECT * FROM MyData", MyConnection);
            DataTable MyTable = new DataTable();
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(MyCommand);
            MyDataAdapter.Fill(MyTable);
            dataGridView1.DataSource = MyTable;
            MyConnection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            username = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userpassword = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Get_id.Text = Id;
            textBox_name.Text = username;
            textBox_password.Text = userpassword;
        }
        private void CallSQL(string Query)
        {
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(Query, MyConnection);
            MyCommand.Parameters.AddWithValue("@username", textBox_name.Text);
            MyCommand.Parameters.AddWithValue("@password", textBox_password.Text);
            int exex = MyCommand.ExecuteNonQuery();
            if (exex != 0) { MessageBox.Show("Thao tác dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Thao tác dữ liệu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            MyConnection.Close();
        }
        private void IsDeleteValues()
        {
            if (MessageBox.Show("Bạn có muốn thực hiện không ? (Yes/No)", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Debug
                CallSQL(RemoValues);
            }
        }

    }
}
