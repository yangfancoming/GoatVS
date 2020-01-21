using Quartz;

namespace chapter9_2_2.parse {
    public abstract class ParseParam {

        public void getParams(IJobExecutionContext ctx) {
            string mark = ctx.JobDetail.JobDataMap.GetString("key");
        }

    }
}