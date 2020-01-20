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
            SQLiteConnection SQLCon = new SQLiteConnection(constr);
            IDataAdapter adapter = new SQLiteDataAdapter(sql,SQLCon);
            return adapter;
        }

        public override Task Execute(IJobExecutionContext context) {
            string connetStr = @"Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-7\db\DemoDB.db";
            string dbSql = "select * from person";
            DataSet dataSet = new DataSet();
            try {
                var dataAdapter = getDataAdapter(dbSql,connetStr);
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