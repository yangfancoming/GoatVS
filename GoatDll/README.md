
#   目录
    - Dll           log4net| util
    - chapter1-0-2  函数
    - chapter1-1-1  委托
    - chapter1-2-1  事件
    - chapter1-3-1  接口
    - chapter1-3-5  多线程
    - chapter1-4-1  泛型
    - chapter1-4-8  反射
    - chapter1-5-1  枚举器/迭代器
    - chapter1-6-1  LINQ
    - chapter1-7-1  集合
    - chapter1-9-1  I/O
    - chapter1-9-2  minio
    - chapter1-9-3  ftp  使用 FluentFTP 实现
    - chapter1-9-5  WebApiClient 
    - chapter1-9-7  HTTPClient 

    - chapter2-1-1  设计模式
    - chapter2-5-1  office

    - chapter3-4-1  定时任务---Quartz.Net
    - chapter3-5-5  FileSystemWatcher 用法 (文件狗)
    - chapter3-6-1  解析xml 
    - chapter3-6-4  xml 与 json互转 
    
    - chapter4-2-4  spring.net
    - chapter4-2-8  spring.net + DB
    - chapter4-3-0  spring.net + AOP

    - chapter4-3-2  spring.net-master
    - chapter4-3-5  spring.net-quartz ？？？ 失败

    - chapter5-2-6  连接 access   （mdb|accdb）
    - chapter5-2-7  连接 sqlite  
    - chapter5-2-8  连接 sqlserver  本地 MDF文件
    - chapter5-2-9  连接 Oracle
    - chapter5-3-0  连接 mysql
    
    
    - chapter6-2-3  IBatis +  mdb 
# 控件 目录

    - chapter8-2-1   ListBox
    - chapter8-2-2   选择文件/文件夹 控件
    - chapter8-2-3  CheckListBox
    - chapter8-2-4  combox
    - chapter8-3-2  DataGridView
    
 # 综合类
    - chapter9-2-2  DataGridView + crud + ibatis + sqlite

#  添加 log4net.dll

   
# .NET Framework 与 .NET Core 的区别与联系

     .net framwork 主要适用于：
    
            没时间学习新技术
            需要一个很稳定的运行环境，最近学习发布稳定版本
            已经在使用现有的应用程序并扩展其功能。
            现在已经有专门的.net团队来实现客户所需要的功能
            不想经常更新程序
            
            
    .net core 更适用于以下几个方面：
    
            程序需要多系统运行，包括MAC，windows和Linux等系统
            不怕学习新东西，不怕出现的各种疑难杂症，毕竟.net core 刚出生没多久，肯定很多东西考虑的不是特别全面
            热爱开源，最好是刚接触.net 的
            
            



# log4net
    log4net不输出日志的原因及解决方案:
    原因：运行程序目录下没有log4net.config配置文件。
    解决方法有两种：
     
     1.手动将log4net.config复制到运行程序
     2.选择解决方案中的log4net.config，在属性–>复制到输出目录，选择始终复制。
        右键 log4net.config 文件 点击 properties 后弹出框中  更改 Copy to output directory目录为 Copy always 
        
        
# log4net 再 winform项目中的用方法：
    1.下载并引入Log4Net.dll程序集到项目中  下载地址：http://logging.apache.org/log4net/download_log4net.cgi   页面中的 log4net-2.0.8-bin-oldkey.zip
    　　
    2.在App.Config中添加对应的节点
        <!--重点configsections必须是第一个节点1og4net配置-->
        <configSections>
            <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
        </configSections>
        
     3.在App.Config中添加Log4Net.dll初始化信息
            <log4net>
                <appender name="Console" type="log4net.Appender.ConsoleAppender">
                    <layout type="log4net.Layout.PatternLayout">
                        <!-- Pattern to output the caller's file name and line number -->
                        <conversionPattern value="%utcdate %5level [%thread] - %message%newline" />
                    </layout>
                </appender>
                
                <appender name="RollingFile" type="log4net.Appender.RollingFileAppender">
                    <file value="logf123ile.log" />
                    <appendToFile value="true" />
                    <maximumFileSize value="100KB" />
                    <maxSizeRollBackups value="2" />
             
                    <layout type="log4net.Layout.PatternLayout">
                        <conversionPattern value="%utcdate %level %thread %logger - %message%newline" />
                    </layout>
                </appender>
                
                <root>
                    <level value="DEBUG" />
                    <appender-ref ref="Console" />
                    <appender-ref ref="RollingFile" />
                </root>
            </log4net>
     4.在AssemblyInfo.cs：配置文件中读取配置Log4net.dll
        [assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config", Watch = true)]   
        
        
     5. //首先实例化Log4net
        public static readonly ILog log = LogManager.GetLogger(typeof(Log4C)); 
        或者
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        //使用记录信息
        log.Debug("Debug", new Exception("Debug"));
        log.Info("Info", new Exception("Info"));
        log.Warn("Warn", new Exception("Warn"));
        log.Error("Error", new Exception("Error"));
        log.Fatal("Fatal", new Exception("Fatal"));   
        
# Rider 工程配置
     配置 大括号 C#成对显示 还是 java单行显示  在 工程设置里的 
     Editor --- Code Style --- C# --- Braces Layout Tab 标签页 --- 选项不多自己挨个试