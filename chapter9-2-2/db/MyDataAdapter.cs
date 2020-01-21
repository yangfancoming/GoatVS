using System.Data;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.db {

    public abstract class MyDataAdapter: IJob {

        protected IDataAdapter DataAdapter;
        public abstract DatabaseType getDbType();

        public abstract IDataAdapter GetDataAdapter(string sql,string constr);

        public abstract Task Execute(IJobExecutionContext context);
    }
}