using System;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter5_2_9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string strConn = ConfigurationManager.ConnectionStrings["ORACLE"].ConnectionString;
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(strConn)) {
                try {
                    string str = "select * from emp";
                    OracleCommand cmd = new OracleCommand(str, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    conn.Open();
                    if (conn.State == ConnectionState.Open) Debug.Print("连接成功");
                    adapter.Fill(dt);
                }
                catch (Exception ex) {
                    Debug.Print(ex.Message);
                }
                finally {
                    conn.Close();
                }
            }
        }
    }
}