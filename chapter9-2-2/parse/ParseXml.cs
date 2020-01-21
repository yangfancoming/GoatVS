using System;
using System.Diagnostics;
using System.Threading.Tasks;
using chapter9_2_2.constant;
using IBatisNet.Common.Logging;
using Quartz;

namespace chapter9_2_2.parse {

    public class ParseXml : IParse<string,string> {

        private static readonly ILog log = LogManager.GetLogger(typeof(ParseXml));
        public FileType fileType() {
            return FileType.xml;
        }

        /// <summary>
        /// xml 文件 解析实现类
        /// </summary>
        /// <param name="filePath">待解析的 xml 文件全路径</param>
        /// <param name="R">输出参数  解析结果</param>
        public string parse(string t) {
            return t;
        }

        public async Task Execute(IJobExecutionContext context) {
            string mark = context.JobDetail.JobDataMap.GetString("mark");
            Debug.Print(mark);
            //  获取参数 todo
            if (MainForm.PrtbLog.InvokeRequired){
             // 解决线程占用问题
                MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("xml 解析 ++++++++++\r\n"); }));
            }
            else{
                MainForm.PrtbLog.AppendText("xml 解析 ----------- \r\n");
            }
            await Task.Delay(1);
        }
    }
}