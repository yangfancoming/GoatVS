

using System.Threading.Tasks;
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.parse {


    public class ParseCsv : IParse<string,string> {


        public FileType fileType() {
            return FileType.csv;
        }

        /// <summary>
        /// csv 文件 解析实现类
        /// </summary>
        /// <param name="filePath">待解析的 csv 文件全路径</param>
        /// <param name="R">输出参数  解析结果</param>
        public string parse(string filePath) {
            return "csv 解析";
        }

        public Task Execute(IJobExecutionContext context) {
            throw new System.NotImplementedException();
        }
    }
}