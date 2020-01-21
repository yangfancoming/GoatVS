using System;
using System.Threading.Tasks;
using Quartz;

namespace chapter3_4_1 {


    public class TimeJob2 : IJob {

        public async Task Execute(IJobExecutionContext context) {
            if (Form1.pRtbLog.InvokeRequired){
                // 解决线程占用问题
                Form1.pRtbLog.Invoke(new Action(() => {     Form1.pRtbLog.AppendText("TimeJob2+++++++" + DateTime.Now + " \r\n" ); }));
            }
            else{
                Form1.pRtbLog.AppendText("TimeJob2---" + DateTime.Now + " \r\n" );
            }
            await Task.Delay(1);
        }
    }
}