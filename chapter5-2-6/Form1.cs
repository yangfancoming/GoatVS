using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace chapter5_2_6 {

    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
        }

        private readonly OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-6\db\myAccess.mdb;Persist Security Info=False");

        private void btn1_Click(object sender, EventArgs e){
            oleDb.Open();
            const string sql = "select * from sys_user";
            var dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            var dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
        }


        private readonly OleDbConnection oleDb2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-6\db\shit.accdb;Persist Security Info=False");
// 如果使用这种方式报错：    private readonly OleDbConnection oleDb2 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-6\db\shit.accdb;Persist Security Info=False"); // 不可识别的数据库格式
        private void button1_Click(object sender, EventArgs e) {
            oleDb2.Open();
            const string sql = "select * from sys_user";
            var dbDataAdapter = new OleDbDataAdapter(sql, oleDb2); //创建适配对象
            var dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象

        }
    }
}
