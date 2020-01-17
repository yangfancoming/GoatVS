using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using chapter4_2_8.IBLL;

namespace chapter4_2_8.BLLMsSql {

    /// SqlServer服务类，实现IDatabaseService接口
    public class SqlServerService : IDatabaseService {

        public DataTable GetDataTableBySQL() {
            string strConn = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn)) {
                try {
                    string str = "select * from PtInfectionCard";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                } catch (Exception ex) {
                    Debug.Print(ex.Message);
                } finally {
                    conn.Close();
                }
            }

            return dt;
        }

        /// 返回SqlServer数据库
        public string GetDbTyoe() {
            return "我是SQLServer数据库";
        }
    }
}