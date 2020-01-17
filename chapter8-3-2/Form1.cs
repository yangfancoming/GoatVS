using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DataBase.model;

namespace chapter8_3_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            dataGridView1.DataSource = EquitInfoList;  //将DataGridView里的数据源绑
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns) {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private static readonly BindingList<EquitmentInfo> EquitInfoList = new BindingList<EquitmentInfo>();//将IList中的值赋给对应的BindingList
        private void button1_Click(object sender, EventArgs e) {
            var Info2 = new EquitmentInfo {IpAddr = "192.168.10.83", MacAddr = "74:1A:E0:A0:01:95", EquitId = "2"};
            var Info = new EquitmentInfo {IpAddr = "192.168.10.206", MacAddr = "74:1A:E0:A2:00:2A", EquitId = "1"};
            EquitInfoList.Add(Info2);
            EquitInfoList.Add(Info);
        }

        private void button2_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            //在表中添加int类型的列
            dt.Columns.Add(new DataColumn("id", typeof(int)));
            //在表中添加string类型的Name列
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            //行
            DataRow dr;
            for (int i = 0; i < 3; i++)
            {
                dr = dt.NewRow();
                dr["id"] = i;
                dr["Name"] = "Name" + i;
                //在表的对象的行里添加此行
                dt.Rows.Add(dr);
            }
            dt.Columns.Add(new DataColumn("选中", typeof(bool)));
            dataGridView2.DataSource = dt;
        }
    }
}