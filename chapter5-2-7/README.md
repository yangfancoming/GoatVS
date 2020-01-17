#  连接 sqlite 
    1.添加系统自带引用  搜索 System.Configuration 
    
    2.添加 Dll
    System.Data.SQLite.dll
    Dapper.dll
    
    3. 将项目生成  cpu选择 64位 
    
    4.DemoDB.db 文件属性设置成 始终复制
    
    
#   Form1.cs(5, 19): [CS0234] 命名空间“System.Data”中不存在类型或命名空间名“SQLite”(是否缺少程序集引用?)
    原因： System.Data.SQLite.dll 的版本与 当前项目使用的 .net Framework的版本不一致导致的
    下载地址： https://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki