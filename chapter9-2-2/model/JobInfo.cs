using chapter9_2_2.constant;

namespace chapter9_2_2.model {

    public class JobInfor {

        // 主键id
        public int id;
        // 任务名称
        public string jobName;
        // 任务类型
        public string jobType;
        // 任务周期
        public string jobCycle;
        //任务状态  （停止,执行,暂停）
        public string jobStatus = JobStatus.停止.ToString();
        // 创建时间
        public string createTime;

        public int 编码 {
            get => id;
            set => id = value;
        }

        public string 任务名称 {
            get => jobName;
            set => jobName = value;
        }

        public string 任务类型 {
            get => jobType;
            set => jobType = value;
        }

        public string 任务周期 {
            get => jobCycle;
            set => jobCycle = value;
        }

        public string 任务状态 {
            get => jobStatus;
            set => jobStatus = value;
        }

        public string 创建时间 {
            get => createTime;
            set => createTime = value;
        }
    }
}