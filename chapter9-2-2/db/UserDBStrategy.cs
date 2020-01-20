using System.Collections.Generic;
using chapter9_2_2.constant;

namespace chapter9_2_2.db {


    public static class UserDBStrategy {

        //
        public static readonly Dictionary<DatabaseType,MyDataAdapter> mUserDB = new Dictionary<DatabaseType,MyDataAdapter>();

        static UserDBStrategy() {
            MyDataAdapter mySql = new MySqlImpl();
            MyDataAdapter sqLite = new SQLiteImpl();
            mUserDB.Add(mySql.getDbType(),mySql);
            mUserDB.Add(sqLite.getDbType(),sqLite);

        }

    }
}