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
            ISimpleTrigger trigger1 = getTrigger();
            await scheduler.ScheduleJob(job, trigger1);
        }

        // 通过反射方式 动态创建job
        public static async Task config2(IParse<string,string> mParse) {
            scheduler = await factory.GetScheduler();
            //OfType的方式加载类型
            IJobDetail job = JobBuilder.Create().OfType(mParse.GetType()).Build();
            ISimpleTrigger trigger = getTrigger();
            await scheduler.ScheduleJob(job, trigger);
        }


        public static ISimpleTrigger getTrigger(int repeat = 5) {
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(repeat).RepeatForever()).Build();
            return trigger;
        }


        public static async Task start() {
            await scheduler.Start();
        }

        public static async Task stop() {
            await scheduler.Shutdown();
        }

    }
}