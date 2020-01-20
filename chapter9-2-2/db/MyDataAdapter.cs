using System.Data;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.db {

    public abstract class MyDataAdapter: IJob {

//        public string constr;

//        public string dbSql;

        public IDataAdapter DataAdapter;
        public abstract DatabaseType getDbType();

        public abstract IDataAdapter getDataAdapter(string sql,string constr);

        public abstract Task Execute(IJobExecutionContext context);
    }
}