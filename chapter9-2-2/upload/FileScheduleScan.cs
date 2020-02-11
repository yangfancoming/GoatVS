using System.Diagnostics;
using System.Threading.Tasks;
using Quartz;

namespace chapter9_2_2.upload {

    // 文件定时任务扫描类
    public class FileScheduleScan : IJob {

        public async Task Execute(IJobExecutionContext context) {
            Debug.Print( "文件扫描测试");
            await Task.Delay(1);
        }
    }
}