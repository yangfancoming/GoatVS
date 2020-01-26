using System;
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

        private static readonly Dictionary<string,IScheduler> schedulerDic = new Dictionary<string, IScheduler>();

        // 使用 代码配置方式

        public static async void configFileAndStart(IParse<string, string> mParse, string key) {
            await configFile(mParse, key);
            await startJob(key);
        }
        public static async void configDbAndStart(MyDataAdapter myDataAdapter, string key) {
            await configDb(myDataAdapter, key);
            await startJob(key);
        }
        // 通过反射方式 动态创建job
        private static async Task configFile(IParse<string,string> mParse,string key) {
            IScheduler scheduler = await factory.GetScheduler();
            schedulerDic.Add(key,scheduler);
            //OfType的方式加载类型
            IJobDetail job = JobBuilder.Create().OfType(mParse.GetType()).UsingJobData("key",key).Build();
            ISimpleTrigger trigger = getTrigger();
            await scheduler.ScheduleJob(job, trigger);
        }

        private static async Task configDb(MyDataAdapter myDataAdapter,string key) {
            IScheduler scheduler = await factory.GetScheduler();
            schedulerDic.Add(key,scheduler);
            //OfType的方式加载类型
            IJobDetail job = JobBuilder.Create().OfType(myDataAdapter.GetType())
                .UsingJobData("constr",key)
                .UsingJobData("sql",key)
                .Build();
            ISimpleTrigger trigger = getTrigger();
            await scheduler.ScheduleJob(job, trigger);
        }



        public static ISimpleTrigger getTrigger(int repeat = 3) {
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(repeat).RepeatForever()).Build();
            return trigger;
        }
        public static async Task startJob(string key) {
            await schedulerDic[key].Start();
            MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("开启任务： " + key  + " \r\n"); }));
        }

        public static async Task stopJob(string key) {
            await schedulerDic[key].Shutdown();
            MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("停止任务： " + key  + " \r\n"); }));
        }

    }
}