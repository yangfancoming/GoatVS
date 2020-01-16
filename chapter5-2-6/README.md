#  连接 access 
    Nuget 搜索 system.data.OleDb

# 读取access数据库时   accdb 与 mdb 两种格式的读取区别
    mdb    格式是access97\2000\2003数据库文件后缀名.即是早期access文件格式
    accdb  用于新的 Office Access 2007\2010 文件格式的文件扩展名。取代早期的 MDB 文件扩展名。

# 回收 access mdb 数据文件空间 
    记录是全部删除了, 但.mdb 文件的size 没有减少?!
    必须 Access 2003->工具->数据库实用工具->压缩和修复数据库 后 方可收回占用空间
    
    
# The 'Microsoft.Jet.OLEDB.4.0' provider is not registered on the local machine
    不要使用 .net core  使用 framework 就好了
    
# sqlite 报错：
    System.DllNotFoundException:“无法加载 DLL“SQLite.Interop.dll”: 
    System.DllNotFoundException:    at 在 System.Data.SQLite.UnsafeNativeMethods.sqlite3_config_none(SQLiteConfigOpsEnum op)