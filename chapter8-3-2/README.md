#  表格控件 dataGridView
    dataGridView 是实体类集合绑定注意事项：
        实体类属性必须要遵循固定的格式  不是随便写的
        
        

    在数据绑定时： 其中 任务名称 为 dataGridView 显示的列名 其对应的jobName 为数据库绑定字段数据
            public abstract class JobInfor {
        
                //   任务名称 任务类型 任务周期 创建时间
                public string jobName;
        
                public string jobType;
        
                public string jobCycle;
        
                public string createTime;
        
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