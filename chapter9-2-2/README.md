#    Unable to connect to any of the specified MySQL hosts.
     再MySqlImpl  SQLiteImpl 两个实现类的  public override Task Execute(IJobExecutionContext context) 方法中
     
     对于需要有返回值的请求 必须要干掉 async 关键字  否则 数据库连接 不会等到连接成功后是 返回数据的
     
     
     
     
#  ui 线程占用问题
                if (MainForm.PrtbLog.InvokeRequired){
                 // 解决线程占用问题
                    MainForm.PrtbLog.Invoke(new Action(() => { MainForm.PrtbLog.AppendText("xml 解析 ++++++++++\r\n"); }));
                }
                else{
                    MainForm.PrtbLog.AppendText("xml 解析 ----------- \r\n");
                }
                
                
# MyFileSystemWatcher 多线程 同步问题  
    不加锁的情况： 每次while循环解析中。。。。 还没完成，下一个线程也开始了 while循环解析。。。。
        当前线程id:-----6文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json3.json Name： json3.json
        当前线程id:-----4文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml1.xml Name： xml1.xml
        当前线程id:-----6while循环解析中。。。。
        当前线程id:-----4while循环解析中。。。。
        当前线程id:-----6while循环 判断文件写入完毕:-----
        当前线程id:-----4while循环 判断文件写入完毕:-----
        ParseJson  当前线程id:-----6---C:\Users\Administrator\Desktop\123\json3.json
        解析完毕！！！当前线程id:-----6---C:\Users\Administrator\Desktop\123\json3.json
        当前线程id:-----5文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json1.json Name： json1.json
        ParseXml  当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml1.xml
        解析完毕！！！当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml1.xml
        当前线程id:-----6文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml2.xml Name： xml2.xml
        当前线程id:-----5while循环解析中。。。。
        当前线程id:-----5while循环 判断文件写入完毕:-----
        ParseJson  当前线程id:-----5---C:\Users\Administrator\Desktop\123\json1.json
        解析完毕！！！当前线程id:-----5---C:\Users\Administrator\Desktop\123\json1.json
        当前线程id:-----5文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json2.json Name： json2.json
        当前线程id:-----6while循环解析中。。。。
        当前线程id:-----6while循环 判断文件写入完毕:-----
        ParseXml  当前线程id:-----6---C:\Users\Administrator\Desktop\123\xml2.xml
        解析完毕！！！当前线程id:-----6---C:\Users\Administrator\Desktop\123\xml2.xml
        当前线程id:-----6文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml3.xml Name： xml3.xml
        当前线程id:-----5while循环解析中。。。。
        当前线程id:-----5while循环 判断文件写入完毕:-----
        ParseJson  当前线程id:-----5---C:\Users\Administrator\Desktop\123\json2.json
        解析完毕！！！当前线程id:-----5---C:\Users\Administrator\Desktop\123\json2.json
        当前线程id:-----6while循环解析中。。。。
        当前线程id:-----6while循环 判断文件写入完毕:-----
        ParseXml  当前线程id:-----6---C:\Users\Administrator\Desktop\123\xml3.xml
        解析完毕！！！当前线程id:-----6---C:\Users\Administrator\Desktop\123\xml3.xml
         
    加锁的情况：每次while循环解析中。。。。 都是等到该线程循环完成后，下一个线程才可以开始 while循环解析。。。。
        当前线程id:-----3文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json3.json Name： json3.json
        当前线程id:-----5文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml1.xml Name： xml1.xml
        当前线程id:-----5while循环解析中。。。。
        当前线程id:-----5while循环 判断文件写入完毕:-----
        当前线程id:-----3while循环解析中。。。。
        当前线程id:-----3while循环 判断文件写入完毕:-----
        ParseXml  当前线程id:-----5---C:\Users\Administrator\Desktop\123\xml1.xml
        解析完毕！！！当前线程id:-----5---C:\Users\Administrator\Desktop\123\xml1.xml
        当前线程id:-----4文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml2.xml Name： xml2.xml
        ParseJson  当前线程id:-----3---C:\Users\Administrator\Desktop\123\json3.json
        解析完毕！！！当前线程id:-----3---C:\Users\Administrator\Desktop\123\json3.json
        当前线程id:-----5文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json1.json Name： json1.json
        当前线程id:-----4while循环解析中。。。。
        当前线程id:-----4while循环 判断文件写入完毕:-----
        ParseXml  当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml2.xml
        解析完毕！！！当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml2.xml
        当前线程id:-----4文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\xml3.xml Name： xml3.xml
        当前线程id:-----5while循环解析中。。。。
        当前线程id:-----5while循环 判断文件写入完毕:-----
        ParseJson  当前线程id:-----5---C:\Users\Administrator\Desktop\123\json1.json
        解析完毕！！！当前线程id:-----5---C:\Users\Administrator\Desktop\123\json1.json
        当前线程id:-----5文件新建事件 ChangeType： Created  FullPath：C:\Users\Administrator\Desktop\123\json2.json Name： json2.json
        当前线程id:-----4while循环解析中。。。。
        当前线程id:-----4while循环 判断文件写入完毕:-----
        ParseXml  当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml3.xml
        解析完毕！！！当前线程id:-----4---C:\Users\Administrator\Desktop\123\xml3.xml
        当前线程id:-----5while循环解析中。。。。
        当前线程id:-----5while循环 判断文件写入完毕:-----
        ParseJson  当前线程id:-----5---C:\Users\Administrator\Desktop\123\json2.json
        解析完毕！！！当前线程id:-----5---C:\Users\Administrator\Desktop\123\json2.json