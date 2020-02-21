using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl.Matchers;

namespace chapter3_4_1 {
    public partial class Form1 : Form {


        public static RichTextBox pRtbLog;
        public Form1() {
            InitializeComponent();
             pRtbLog = rtb_log;
             Util.Run2().GetAwaiter().GetResult();
             Util.Run3().GetAwaiter().GetResult();
        }

        // 任务1
        private async void button1_Click(object sender, EventArgs e) {
            await Util.Start();
        }

        private void button4_Click(object sender, EventArgs e) {
            Util.Stop().GetAwaiter().GetResult();
        }

        // 任务1
        private async void button2_Click(object sender, EventArgs e) {
            await Util.Start();
        }
        private void button5_Click(object sender, EventArgs e) {
            Util.Stop().GetAwaiter().GetResult();
        }

        // 任务3
        private async void button3_Click(object sender, EventArgs e) {
            await Util.Start();
        }

        private void button6_Click(object sender, EventArgs e) {
            Util.Stop().GetAwaiter().GetResult();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // 暂停
        private void button12_Click(object sender, EventArgs e) {

        }
        // 恢复
        private void button9_Click(object sender, EventArgs e) {

        }

        private void button13_Click(object sender, EventArgs e) {
            //此方法获取所有的Job的group的名字
            var jobGroupNames = Util.scheduler.GetJobGroupNames();
            List<string> list = jobGroupNames.Result.ToList();
            list.ForEach(x=> rtb_log.AppendText(x + " \r\n" ));
        }

        private void button14_Click(object sender, EventArgs e) {
            // GetJobKeys 获取到所有Job的JobKey，相当于Job信息
            var jobKeys = Util.scheduler.GetJobKeys(GroupMatcher<JobKey>.GroupEquals("jobGroup2"));
            var readOnlyCollection = jobKeys.Result;
            foreach (JobKey jobKey in readOnlyCollection) {
                rtb_log.AppendText("jobKey.Name---" + jobKey.Name + " \r\n");
                rtb_log.AppendText("jobKey.Group---" +jobKey.Group + " \r\n");
            }
        }

        private void button15_Click(object sender, EventArgs e) {
            // GetTriggerKeys获取到所有Trigger的TriggerKey，相当于Trigger信息
            var triggerKeys = Util.scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.GroupEquals("group2"));
            var readOnlyCollection = triggerKeys.Result;
            foreach (TriggerKey triggerKey in readOnlyCollection) {
                rtb_log.AppendText("TriggerKey.Name---" + triggerKey.Name + " \r\n");
                rtb_log.AppendText("TriggerKey.Group---" +triggerKey.Group + " \r\n");
                var triggerState = Util.scheduler.GetTriggerState(triggerKey);
                rtb_log.AppendText("TriggerKey.状态---" +  triggerState.Result + " \r\n");
            }
        }
    }
}