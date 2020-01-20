using System.Data;
using chapter9_2_2.constant;
using MySql.Data.MySqlClient;

namespace chapter9_2_2.db {


    public class MySqlImpl : MyDataAdapter{

        public override DatabaseType getDbType() {
            return DatabaseType.MySql;
        }

        public override IDataAdapter getDataAdapter(string sql,string constr) {
            MySqlConnection SQLCon = new MySqlConnection(constr);
            IDataAdapter adapter = new MySqlDataAdapter(sql, SQLCon);
            return adapter;
        }


    }
}