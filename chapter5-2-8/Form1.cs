using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chapter5_2_8 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // 连接远程库测试
        String strCon = "Data Source=210.45.***.**;Initial Catalog=Energy2;User ID=EnergyUser;Password=*******";


        private void button1_Click(object sender, EventArgs e) {
            string str1 = Environment.CurrentDirectory;
            // 连接本地 DB文件测试
            String strCon2 =  @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + @str1 + @"\db\FSU.MDF" + ";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(strCon2);
            con.Open();

            String sql = "select * from HistoryPower";
            //创建命令对象，指定要执行sql语句与连接对象conn
            SqlCommand cmd = new SqlCommand(sql, con);
            //执行查询返回结果集
            SqlDataReader sdr = cmd.ExecuteReader();
            //下移游标，读取一行，如果没有数据了则返回false
            while (sdr.Read()){
                MessageBox.Show("姓名：" + sdr["ActivePower"] + ",性别：" + sdr["Id"]);
            }
            con.Close();
        }


    }
}