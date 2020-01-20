using System.Data;
using System.Data.SQLite;
using chapter9_2_2.constant;

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
    }
}