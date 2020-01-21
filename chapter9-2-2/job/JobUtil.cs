using System.Collections.Generic;
using System.Threading.Tasks;
using chapter9_2_2.db;
using chapter9_2_2.model;
using chapter9_2_2.parse;
using Quartz;
using Quartz.Impl;

namespace chapter9_2_2.job {


    public static class JobUtil {

        //调度器工厂
        private static readonly StdSchedulerFactory factory = new StdSchedulerFactory();

//        private static IScheduler scheduler ;

        private static Dictionary<string,IScheduler> schedulerDic = new Dictionary<string, IScheduler>();

        // 使用 代码配置方式
        public static async Task config() {
//            scheduler = await factory.GetScheduler();
            IJobDetail job = JobBuilder.Create<ParseXml>().WithIdentity("jobName2", "jobGroup2").Build();
            ISimpleTrigger trigger1 = getTrigger();
//            await scheduler.ScheduleJob(job, trigger1);
        }

        public static async Task configFileAndStart(IParse<string, string> mParse, string key) {
            configFile(mParse, key);
            startFile(key);
        }

        // 通过反射方式 动态创建job
        public static async Task configFile(IParse<string,string> mParse,string key) {
            IScheduler scheduler = await factory.GetScheduler();
            schedulerDic.Add(key,scheduler);
            //OfType的方式加载类型
            IJobDetail job = JobBuilder.Create().OfType(mParse.GetType())
                .UsingJobData("key",key)
                .Build();
            ISimpleTrigger trigger = getTrigger();
            await scheduler.ScheduleJob(job, trigger);
        }


        // 通过反射方式 动态创建job
        public static async Task config2(MyDataAdapter mParse) {
//            scheduler = await factory.GetScheduler();
            //OfType的方式加载类型
            IJobDetail job = JobBuilder.Create().OfType(mParse.GetType())
//                .UsingJobData("constr",constr)
//                .UsingJobData("sql",sql)
                .Build();
            ISimpleTrigger trigger = getTrigger();
//            await scheduler.ScheduleJob(job, trigger);
        }

        public static ISimpleTrigger getTrigger(int repeat = 5) {
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(repeat).RepeatForever()).Build();
            return trigger;
        }
        public static async Task startFile(string key) {
            await schedulerDic[key].Start();
        }

        public static async Task startDB(string key) {
            await schedulerDic[key].Start();
        }

        public static async Task stopFile(string key) {
            await schedulerDic[key].Shutdown();
        }

    }
}