using System.Data;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.db {

    public abstract class MyDataAdapter: IJob {

        // 这里必须是 static 否则定时任务每次都会 新建连接
        protected static IDataAdapter dataAdapter;

        public abstract DatabaseType getDbType();

        public abstract IDataAdapter GetDataAdapter(string sql,string constr);

        public abstract Task Execute(IJobExecutionContext context);
    }
}