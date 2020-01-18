using chapter4_3_2.MovieFinder;
using chapter4_3_2.MovieFinder.Impl;
using Common.Logging;
using Common.Logging.Log4Net;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Support;
using Spring.Objects.Factory.Xml;

namespace chapter4_3_2 {


    public static class SpringIOC {

        static readonly GenericApplicationContext ctx1 = new GenericApplicationContext();
        static readonly IObjectDefinitionFactory objectDefinitionFactory = new DefaultObjectDefinitionFactory();

        // 脱离 App.config文件 代码中直接指定 spring.xml文件来配置Spring容器
        public static IApplicationContext CreateContextMixXmlAndProgrammatic(){
            IObjectDefinitionReader objectDefinitionReader = new XmlObjectDefinitionReader(ctx1);
            objectDefinitionReader.LoadObjectDefinitions("assembly://chapter4_3_2/chapter4_3_2/AppContextContribution.xml");
            ObjectDefinitionBuilder builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(ColonDelimitedMovieFinder));
            builder.AddConstructorArg("movies.txt");
            ctx1.RegisterObjectDefinition("AnotherMovieFinder", builder.ObjectDefinition);
            ctx1.Refresh();
            return ctx1;
        }

        static  ObjectDefinitionBuilder builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(MovieLister));

        // 脱离 App.config 和 spring.xml 配置文件 使用纯代码方式 启动Spring容器
        public static IApplicationContext CreateContextProgrammatically(){
            InitializeCommonLogging();
            //Create MovieLister and dependency on
            //    <!-- 指定实现类 SimpleMovieFinder    using setter injection... -->
//            builder.AddPropertyReference("MovieFinder", "AnotherMovieFinder");

            // <!-- 指定实现类 SimpleMovieFinder    using setter injection... -->
            builder.AddPropertyReference("MovieFinder", "MyMovieFinder");
            ctx1.RegisterObjectDefinition("MyMovieLister", builder.ObjectDefinition);

            // 向容器中注册  ColonDelimitedMovieFinder  实现类
            builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(ColonDelimitedMovieFinder));
            builder.AddConstructorArg("movies.txt");
            ctx1.RegisterObjectDefinition("AnotherMovieFinder", builder.ObjectDefinition);
            // 向容器中注册  SimpleMovieFinder  实现类
            builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(SimpleMovieFinder));
            ctx1.RegisterObjectDefinition("MyMovieFinder", builder.ObjectDefinition);
            ctx1.Refresh();
            return ctx1;
        }

        public static IApplicationContext CreateContextProgrammaticallyWithAutoWire(){
            InitializeCommonLogging();
            //Create MovieLister and dependency on
            builder.AddPropertyReference("MovieFinder", "AnotherMovieFinder").SetAutowireMode(AutoWiringMode.ByType);
            ctx1.RegisterObjectDefinition("MyMovieLister", builder.ObjectDefinition);

            builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(ColonDelimitedMovieFinder));
            builder.AddConstructorArg("movies.txt").SetAutowireMode(AutoWiringMode.ByType);
            ctx1.RegisterObjectDefinition("AnotherMovieFinder", builder.ObjectDefinition);
            ctx1.Refresh();
            return ctx1;
        }


        private static void InitializeCommonLogging() {
            var properties = new Common.Logging.Configuration.NameValueCollection();
            properties["configType"] = "INLINE";
            LogManager.Adapter = new Log4NetLoggerFactoryAdapter(properties);
        }

    }
}