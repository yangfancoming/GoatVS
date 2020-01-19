namespace chapter9_2_2.model {

    public abstract class JobInfor {
//        任务名称 任务类型 任务周期 创建时间
        private string jobName;

        public string 任务名称{
            get => jobName;
            set => jobName = value;
        }

        private string jobType;

        public string 任务类型{
            get => jobType;
            set => jobType = value;
        }

        private string jobCycle;

        public string 任务周期{
            get => jobCycle;
            set => jobCycle = value;
        }

        private string createTime;

        public string 创建时间{
            get => createTime;
            set => createTime = value;
        }
    }
}