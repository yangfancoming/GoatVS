# FileNotFound_FileName = “RestSharp, Version=106.3.1.0, Culture=neutral, PublicKeyToken=598062e77f915f75”
     加载的dll 版本不对
   
# 发生一个或多个错误。 MinIO API responded with message=Unsuccessful response from server without XML error: 基础连接已经关闭: 发送时发生错误。
    传输协议不对应 
    干掉 private static MinioClient minioClient = new MinioClient("192.168.211.128:9000","minioadmin","minioadmin" ).WithSSL();
    中的.WithSSL() 就可以了

#  MinIO API responded with message=The difference between the request time and the server's time is too large.
    请求时间和服务器时间 差异太大
    本地运行软件的windows系统时间和 minio部署的linux系统时间 相差了8个小时
    
    查看linux系统时间
    [root@localhost ~]# date
    Mon Jan 27 03:29:55 CST 2020
    自动校准时间
    [root@localhost ~]# sudo ntpdate cn.pool.ntp.org 
    17 Feb 10:54:35 ntpdate[38830]: step time server 5.79.108.34 offset 1841009.731501 sec
    再次查看 校准后的时间 (正常了)
    [root@localhost ~]# date
    Mon Feb 17 10:54:41 CST 2020

    