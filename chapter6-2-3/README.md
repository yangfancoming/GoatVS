
# 引入步骤

    添加 lib目录中的 dll
    
    加载 SqlMap.config
       DomSqlMapBuilder builder = new DomSqlMapBuilder();
       ISqlMapper Map = builder.Configure("IBatis/SqlMap.config");
    
    SqlMap.config 和 providers.config 两个配置文件 名字不能变是固定的  而且都必须设置成  嵌入的资源和始终复制
    其中 SqlMap.config    可以随意放置路径  只要在代码中指定就可以            E:\Code\C#_code\RiderLearning\GoatVS\chapter6-2-3\IBatis\SqlMap.config
    其中 providers.config 可以随意放置路径  只要在SqlMap.config中指定就可以   <providers resource="IBatis/providers.config"/>

        
    通过 SqlMap.config 全局配置文件  关联局部配置文件 sqlMaps
          <sqlMaps>
            <sqlMap embedded="chapter6_2_3.IBatis.sqlMaps.sys_user.xml,chapter6_2_3"/>
          </sqlMaps>
     其中 chapter6_2_3 是工程名  . 即/  表示目录 
     从整个项目的结构来看 关联局部配置文件的方式 是： chapter6_2_3 工程目录下的  IBatis 目录下的sqlMaps 目录下的 sys_user.xml 
     即为： chapter6_2_3/IBatis/sqlMaps/sys_user.xml
     
     
     最后一步就是 局部配置文件 sys_user.xml 中的 别名配置的路径问题了
      <typeAlias alias="sys_user" type="chapter6_2_3.Domain.SysUser,chapter6_2_3" />
      
      顶层命名空间 chapter6_2_3  
      Domain 目录下的 SysUser 的namespace 必须是 chapter6_2_3.Domain 逐级下来的才可以
      
      如果是 
      Domain 目录下的 SysUser 的namespace 是 Domain 然后局部配置文件 sys_user.xml 这样配置
      <typeAlias alias="sys_user" type="Domain.SysUser,Domain" />
      是不行的！！！


    
#   创建SqlMapper的方式有以下几种
    
    a. 第一种方式
    ISqlMapper _sqlMapper=IBatisNet.DataMapper.Mapper.Instance()
    注:此种方式要求SqlMap.config文件位于应用程序根目录下，且文件名是且仅是”SqlMap.config”。
        sos Provider.config Person.xml局部配置文件   sqlMap.config 三个文件 必须放在放到debug/bin目录里
    
    b. 第二种方式
    ISqlMapper _sqlMapper=new DomSqlMapBuilder().Configure()
    注:此种方式要求SqlMap.config文件位于应用程序根目录下，且文件名是且仅是”SqlMap.config”。
    
    c. 第三种方式——指定SqlMap.config的路径(使用EmbededResource查找config资源时，要求SqlMap.config生成操作属性为嵌入的资源)
    XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("Config.SqlMap.config, Persistence");
    ISqlMapper _sqlMapper = new DomSqlMapBuilder().Configure(sqlMapConfig); //---第三种
    
    
#  批量删除报错：Insert statements cannot be executed as a update query.
    问题： 可定是 代码中调用的
     var deleteList = "collect_db.selectList".deleteList(array);
