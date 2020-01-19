namespace chapter9_2_2.model {

    public abstract class JobInfor {

        // 主键id
        public int id;

        //   任务名称 任务类型 任务周期 创建时间
        public string jobName;

        public string jobType;

        public string jobCycle;

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

        public string 创建时间 {
            get => createTime;
            set => createTime = value;
        }
    }
}