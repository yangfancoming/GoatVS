namespace chapter9_2_2.model {


    public class DBJob :JobInfor {

        // 数据库类型
        public string dbType ;

        // 连接串
        public string dbConstr ;

        // SQL 语句
        public string dbSql;

        public string 数据库类型 {
            get => dbType;
            set => dbType = value;
        }

        public string 连接串 {
            get => dbConstr;
            set => dbConstr = value;
        }

        public string SQL {
            get => dbSql;
            set => dbSql = value;
        }
    }
}