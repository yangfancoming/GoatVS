using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace chapter5_3_0 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string connetStr = "Database=test2;Data Source=192.168.211.128;port=3306;uid=root;pwd=12345;charset=utf8;pooling=true";
            MySqlConnection SQLCon = new MySqlConnection(connetStr);
            try{
                SQLCon.Open(); //连接数据库
                //MessageBox.Show("数据库连接成功", "提示", MessageBoxButtons.OK);
                string searchStr = "select * from book";   //student表中数据
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchStr, SQLCon);
                DataTable a = new DataTable();
                adapter.Fill(a);
            }
            catch (MySqlException ex){
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK);     //显示错误信息
            }

        }
    }
}