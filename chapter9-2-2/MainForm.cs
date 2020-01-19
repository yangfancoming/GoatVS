using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using chapter9_2_2.model;
using Dapper;

namespace chapter9_2_2 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        // 测试按钮
        private void button1_Click(object sender, EventArgs e) {
            using (IDbConnection cnn = new SQLiteConnection(@"Data Source=.\db\sqlite.db;Version=3;"))
            {
                var output = cnn.Query<PersonModel>("SELECT * FROM PERSON", new DynamicParameters());
                List<PersonModel> temp = output.ToList();
                Debug.Print(temp.Count.ToString());
            }
        }
    }
}