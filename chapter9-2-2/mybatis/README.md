# 缓存
    1.在 SqlMap.config  全局配置文件中
        <setting cacheModelsEnabled="true"/>
        
    2.在 局部配置文件中
          <!--
          implementation="MEMORY"是设置缓存的实现方式，可以指定LRU、FIFO等，有点类似于内存的页替换策略。MEMORY是最常使用的一种方式。
          flushOnExecute 设置的是当执行了这些语句时更新缓存 
          -->
            <cacheModels>
                <cacheModel id="sys_fileJob-cache"  implementation="MEMORY" >
                    <flushInterval hours="24"/>
        <!--            <flushOnExecute  statement="sys_fileJob.selectList"/>-->
        <!--            <flushOnExecute  statement="sys_fileJob.deleteById"/>-->
                    <property name="Type" value="Weak"/>
                </cacheModel>
            </cacheModels>
     <cacheModel> 标签的 implementation 属性：
        MEMORY实现适用于没有统一的对象重用模式的应用，或内存不足的应用。
        LRU Cache 实现用“近期最少使用”原则来确定如何从 Cache 中清除对象。
        FIFO Cache 实现用“先进先出”原则来确定如何从 Cache 中清除对象。
        OSCACHE Cache 实现是OSCache2.0缓存引擎的一个 Plugin。它具有高度的可配置性，分布式，高度的灵活性。
        
        
      <cacheModel>  的子标签
      flushOnExecute：设置的是当执行了这些语句时更新缓存。
      flushInterval : Cache刷新间隔. 可以配置hours,minutes,seconds,milliseconds.
      property : 这是针对cacheModel的额外的一些属性配置.不同type的cacheModel将会有自己专有的一些property配置. 
                       FIFO: <property name="size" value="100" /> 
                      LRU: <property name="cache-size" value="100" /> 
                      MEMORY: <property name="reference-type" value="WEAK" />
        
        
        当然,你也可以自己来实现Cache, 你需要做的是让你的Cache类 implements com.ibatis.sqlmap.engine.cache.CacheController. 
        
        readOnly : 是否只读. 默认为true, 只读. 
        所谓只读，只是说建议您在开发的时候，对于配置为只读的缓存，不要进行更新操作，这样可能会出现问题，比如可能会出现同步的问题，因为当您访问只读缓存的时候，框架直接将缓存中对象的引用返回给你，如果多个线程试图对其修改，就有可能出现同步问题。
        
        可读写缓存与只读缓存的区别是，当你访问缓存中的数据时，缓存会返回给你一个原数据的副本，而不是直接将原数据的引用返回给你。这样即使是多线程，由于各自用于一个完全一样的副本，也不回出现线程同步的问题。可读写缓存配置时需要使用：readOnly="false"
        
        
        serialize : 是否从Cache中读取同一个对象,还是对象的副本. 
        只有在readOnly=false才有效. 
        因为Cache是只读的,那么为不同session返回的对象肯定是一个. 
        只有在Cache是可读写的时候,才需要为每个session返回对象的副本. 
        
        flushInterval : Cache刷新间隔. 可以配置hours,minutes,seconds,milliseconds. 
        注: 不是说,间隔时间到了,在Cache的statement会自己刷新,而是说,在间隔时间过了后,下次的查询 
        将不会从Cache中直接去值,而会用SQL去查.也就是: 如果,间隔时间过了,还没有Cache对应的statement执行 
        的话,那么Cache中就会一直是旧的,不用担心Cache数据是旧的,因为下次的查询将会直接从SQL查询,而非Cache,查询的结果也会去更新Cache的值. 
        
        flushOnExecute : 当这些statement被执行了,那么下次的查询将会通过SQL去查,同时用查询结果更新Cache. 
        注: 和flushInterval的刷新一样,不是主动刷新,而是由下次查询来触发被动刷新. 
        在一个cacheModel中可以指定多个flushOnExecute. 
        
        property : 这是针对cacheModel的额外的一些属性配置.不同type的cacheModel将会有自己专有的一些property配置. 
        FIFO: <property name="size" value="100" /> 
        LRU: <property name="cache-size" value="100" /> 
        MEMORY: <property name="reference-type" value="WEAK" /> 
        
        另外， ibatis 的缓存机制使用必须特别谨慎。特别是flushOnExecute 的设定，需要考虑到所有可能引起实际数据与缓存数据不符的操作。如本模块中其他Statement对数据的更新，其他模块对数据的更新，甚至第三方系统对数据的更新。否则，脏数据的出现将为系统的正常运行造成极大隐患。
        如果你不能确定，或者数据库同时由其它系统共用，你不能完全控制数据何时被更新，就不能使用Ibatis提供的缓存机制，否则就会出现查询出不是最新数据的问题。

        
        
        
     3. select|update|delete 标签 节点 属性 加入 cacheModel="account-cache"
        
            <select id="selectById" parameterclass="int" resultClass="sys_fileJob" cacheModel="sys_fileJob-cache">
              select  *  from   sys_fileJob  WHERE id = #value#
            </select>

        
#  1.一个未解决的 iBatisNet 并发访问问题
    iBatisNet 是通过 SqlMap 实例执行 SQL Statement 的, 一个 SqlMap 实例里封装了数据库连接和事务, 让人难受的是, Cache 竟然也封装在 SqlMap 里。
    
    大家知道, 我们可以通过以下方式获得 SqlMap 实例:
    
    a. SqlMap map = Mapper.Instance(); // 单件模式, 返回唯一实例
    
    b. DomSqlMapBuilder builder = new DomSqlMapBuilder();
    SqlMap map = builder.Configure(); // 返回新的 SqlMap 实例
    
    在单线程的环境下, a 没有问题, cache 也工作得很正常, 在多线程环境下, 因为 SqlMap 封装了 Connection, 如果并发调用同一个 SqlMap 实例访问数据库的时候, 会抛出以下异常:
    IBatisNet.DataMapper.Exceptions.DataMapperException: SqlMap could not invoke OpenConnection(). A connection is already started. Call CloseConnection first.
    
    在多线程环境下, b 就派上用场了, 可以在每个线程的开始用 b 创建一个 SqlMap 实例, 然后用这个 SqlMap 对数据库进行访问。但问题也就来了, 因为 cache 是封装在 SqlMap 里的, 每个 SqlMap 都会创建一份自己的 cache, 也就是说, iBatisNet 自带的 cache 机制没有用了。
    
    真让人失望, 我现在只好自己用 Hashtable 实现简单的 cache 功能。  