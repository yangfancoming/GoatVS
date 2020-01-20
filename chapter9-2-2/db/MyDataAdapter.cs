using System.Data;
using chapter9_2_2.constant;

namespace chapter9_2_2.db {

    public abstract class MyDataAdapter {

        public abstract DatabaseType getDbType();

        public abstract IDataAdapter getDataAdapter(string sql,string constr);
    }
}