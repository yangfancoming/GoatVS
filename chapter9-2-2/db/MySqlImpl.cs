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

        public override IDataAdapter GetDataAdapter(string sql,string constr) {
            if (dataAdapter != null) return dataAdapter;
            MySqlConnection SQLCon = new MySqlConnection(constr);
            dataAdapter = new MySqlDataAdapter(sql, SQLCon);
            return dataAdapter;
        }
//        string constr = "Database=test2;Data Source=192.168.211.128;port=3306;uid=root;pwd=12345;charset=utf8;pooling=true";
//        string dbSql = "select * from book";
        // 定时任务执行函数
        public override Task Execute(IJobExecutionContext context) {
            // 获取任务参数
            string dbConstr = context.JobDetail.JobDataMap.GetString("dbConstr");
            string dbSql = context.JobDetail.JobDataMap.GetString("dbSql");

            DataSet dataSet = new DataSet();
            try {
                var dataAdapter = GetDataAdapter(dbSql,dbConstr);
                dataAdapter.Fill(dataSet);
            } catch (Exception e) {
                Debug.Print(e.Message);
                throw;
            }
            MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("返回记录条数\r\n"  +  dataSet.Tables[0].Rows.Count); }));
            return null;
        }
    }
}