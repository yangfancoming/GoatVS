#    Unable to connect to any of the specified MySQL hosts.
     再MySqlImpl  SQLiteImpl 两个实现类的  public override Task Execute(IJobExecutionContext context) 方法中
     
     对于需要有返回值的请求 必须要干掉 async 关键字  否则 数据库连接 不会等到连接成功后是 返回数据的