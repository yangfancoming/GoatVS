using System;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Quartz.Simpl;
using Quartz.Xml;

namespace chapter3_4_1 {

    public static class Util {

        private static readonly SimpleTypeLoadHelper simpleTypeLoadHelper = new SimpleTypeLoadHelper();
        private static readonly XMLSchedulingDataProcessor processor = new XMLSchedulingDataProcessor(simpleTypeLoadHelper);
        //调度器工厂
        private static readonly StdSchedulerFactory factory = new StdSchedulerFactory();

        private static IScheduler scheduler1;
        private static IScheduler scheduler2;
        private static IScheduler scheduler3;

        // 使用 xml 配置文件方式  doit 该种方式 再winform下为啥就不好使了呢？
        public static async Task Run1() {
            scheduler1 = await factory.GetScheduler();
            await processor.ProcessFileAndScheduleJobs(@"E:\Code\C#_code\RiderLearning\GoatVS\chapter3-4-1\quartz_jobs.xml", scheduler1);
            await scheduler1.Start();
        }

        public static async Task Stop1() {
            await scheduler1.Shutdown();
        }

        // 使用 代码配置方式
        public static async Task Run2() {
            scheduler2 = await factory.GetScheduler();
            IJobDetail job = JobBuilder.Create<TimeJob2>().WithIdentity("jobName2", "jobGroup2").Build();
            IJobDetail job2 = JobBuilder.Create<TimeJob3>().WithIdentity("jobName3", "jobGroup3").Build();

            ISimpleTrigger trigger1 = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

            ITrigger trigger2 = TriggerBuilder.Create()
                .WithIdentity("trigger2", "group2")
                .WithCronSchedule("0/5 * * * * ?")     //5秒执行一次
                .Build();

            await scheduler2.ScheduleJob(job, trigger1);
            await scheduler2.ScheduleJob(job2, trigger2);
            await scheduler2.Start();
        }

        public static async Task Stop2() {
            await scheduler2.Shutdown();
        }



        public static async Task Run3() {
            //创建一个调度器
            scheduler3 = await factory.GetScheduler();
            IJobDetail job = JobBuilder.Create<TimeJob3>().WithIdentity("jobName3", "jobGroup3").Build();
            //3、创建触发器
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger2", "group2")
                .WithCronSchedule("0/5 * * * * ?")     //5秒执行一次
                .Build();
            //4、将任务与触发器添加到调度器中
            await scheduler3.ScheduleJob(job, trigger);
            //5、开始执行
            await scheduler3.Start();
        }

        public static async Task Stop3() {
            await scheduler3.Shutdown();
        }
    }
}