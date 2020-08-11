#  连接 Oracle
    报错： System.Data.OracleClient 需要 Oracle 客户端软件 version 8.1.7 或更高版本
    
        出错的原因：
        
        1.虽然报的是需要安装客户端8.1.7及以上版本，实际是.net账户没有访问Oracle\bin文件夹的权限
        
        2.在 Windows Server 2003/2008 的 NTFS系统中提供了高级的访问安全性，FAT32系统也许没有这个问题。
