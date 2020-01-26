using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.db {


    public class SQLiteImpl :MyDataAdapter{

        public override DatabaseType getDbType() {
            return DatabaseType.SQLite;
        }

        public override IDataAdapter getDataAdapter(string sql,string constr) {
            if (dataAdapter != null) return dataAdapter;
            SQLiteConnection SQLCon = new SQLiteConnection(constr);
            dataAdapter = new SQLiteDataAdapter(sql,SQLCon);
            return dataAdapter;
        }

//        string connetStr = @"Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-7\db\DemoDB.db";
//        string dbSql = "select * from person";
        // 定时任务执行函数
        public override Task Execute(IJobExecutionContext context) {
            // 获取任务参数
            string dbConstr = context.JobDetail.JobDataMap.GetString("dbConstr");
            string dbSql = context.JobDetail.JobDataMap.GetString("dbSql");
            DataSet dataSet = new DataSet();
            try {
                IDataAdapter dataAdapter = getDataAdapter(dbSql,dbConstr);
                dataAdapter.Fill(dataSet);
            } catch (Exception e) {
                Debug.Print(e.Message);
                throw;
            }
            MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("SQLiteImpl 返回记录条数\r\n"  +  dataSet.Tables[0].Rows.Count); }));
            return null;
        }
    }
}