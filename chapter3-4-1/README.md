#  
    项目中需引用： Quartz.dll 
     Nuget ： Quartz

# quartz暂停及恢复任务解决恢复时一咕噜把未执行的全补回来的问题
    解决方法：
        使用 WithMisfireHandlingInstructionDoNothing 
        并且  
        quartz.properties 
            java配置文件中 增加 ：org.quartz.jobStore.misfireThreshold = 5000
        quartz.config  
            C# 配置文件中 增加：<add key="quartz.jobStore.misfireThreshold" value="5000" />