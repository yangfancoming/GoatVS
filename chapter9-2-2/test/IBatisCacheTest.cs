using System;
using System.Windows.Forms;
using chapter9_2_2.constant;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;

namespace chapter9_2_2.test {


    public static class IBatisCacheTest {

        private const string suffix = "xml";
        private const string directory = @"C:\Users\Administrator\Desktop\123";

        // IBatis 一级缓存测试
        public static void test1() {
            init();
            // 相同的查询条件
            FileJob condition = new FileJob { fileSuffix = suffix, fileDirectory =  directory};
            // 第一次查询  走数据库
            FileJob selectOne1 = "sys_fileJob.selectOne".selectOne<FileJob>(condition);// Retrieved cached object 'chapter9_2_2.model.FileJob' using key '567820725|9223372032384783854'
            // 第二次查询  走一级缓存
            FileJob selectOne2 = "sys_fileJob.selectOne".selectOne<FileJob>(condition); // Retrieved cached object 'chapter9_2_2.model.FileJob' using key '567820725|9223372032384783854'
            // true
            MessageBox.Show((selectOne1 == selectOne2).ToString());
        }


        public static void init() {

            FileJob fileJob = new FileJob {
                jobName = "测试",// 任务名称
                jobStatus = JobStatus.停止.ToString(),
                fileSuffix = suffix, // 文件类型|后缀
                fileDirectory = directory, // 文件目录
                fileMatched = "", // 文件名匹配条件
                jobType = "文件采集", // 任务类型
                filehandlerOld = "",// 处理已有文件
                createTime = DateTime.Now.ToString() // 创建时间
            };
            "sys_fileJob.insert".insert(fileJob);
        }
    }
}