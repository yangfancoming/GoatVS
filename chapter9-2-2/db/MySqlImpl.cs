using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using MySql.Data.MySqlClient;
using Quartz;

namespace chapter9_2_2.db {


    public class MySqlImpl : MyDataAdapter {

        public override DatabaseType getDbType() {
            return DatabaseType.MySql;
        }

        public override IDataAdapter getDataAdapter(string sql,string constr) {
            if (DataAdapter != null) return DataAdapter;
            var SQLCon = new MySqlConnection(constr);
            DataAdapter = new MySqlDataAdapter(sql, SQLCon);
            return DataAdapter;
        }

        public  override Task Execute(IJobExecutionContext context) {
            string constr = "Database=test2;Data Source=192.168.211.128;port=3306;uid=root;pwd=12345;charset=utf8;pooling=true";
            string dbSql = "select * from book";
            DataSet dataSet = new DataSet();
            try {
                var dataAdapter = getDataAdapter(dbSql,constr);
                dataAdapter.Fill(dataSet);
            } catch (Exception e) {
                Debug.Print(e.Message);
                throw;
            }
//            Debug.Print(dataSet.Tables[0].Rows.Count.ToString());
            if (MainForm.PrtbLog.InvokeRequired){
                // 解决线程占用问题
                MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("返回记录条数\r\n"  +  dataSet.Tables[0].Rows.Count); }));
            }
            else{
                MainForm.PrtbLog.AppendText("返回记录条数 \r\n" +  dataSet.Tables[0].Rows.Count);
            }
            return null;
        }
    }
}