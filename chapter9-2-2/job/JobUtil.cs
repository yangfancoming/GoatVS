using System.Threading.Tasks;
using chapter9_2_2.parse;
using Quartz;
using Quartz.Impl;

namespace chapter9_2_2.job {


    public static class JobUtil {

        //调度器工厂
        private static readonly StdSchedulerFactory factory = new StdSchedulerFactory();

        private static IScheduler scheduler;

        // 使用 代码配置方式
        public static async Task config() {
            scheduler = await factory.GetScheduler();
            IJobDetail job = JobBuilder.Create<ParseXml>().WithIdentity("jobName2", "jobGroup2").Build();

            ISimpleTrigger trigger1 = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

            await scheduler.ScheduleJob(job, trigger1);
        }


        public static async Task start() {
            await scheduler.Start();
        }

        public static async Task stop() {
            await scheduler.Shutdown();
        }

    }
}