using System;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using chapter4_2_8.IBLL;

namespace chapter4_2_8.BLLOracle {


    /// Oracle数据服务类，实现IDatabaseService接口
    public class OracleService :IDatabaseService {
        public DataTable GetDataTableBySQL() {
            string strConn = ConfigurationManager.ConnectionStrings["ORACLE"].ConnectionString;
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(strConn)) {
                try {
                    string str = "select * from emp";
                    OracleCommand cmd = new OracleCommand(str, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex) {
                    Debug.Print(ex.Message);
                }
                finally {
                    conn.Close();
                }
            }
            return dt;
        }

        /// 返回Oracle数据库
        public string GetDbTyoe() {
            return "我是Oracle数据库";
        }
    }
}