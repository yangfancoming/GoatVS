using System;
using System.Diagnostics;
using System.Windows.Forms;
using chapter4_3_2.Model;
using chapter4_3_2.MovieFinder;
using chapter4_3_2.MovieFinder.Impl;
using Common.Logging;
using Common.Logging.Log4Net;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Support;
using Spring.Objects.Factory.Xml;

namespace chapter4_3_2 {
    public partial class Form1 : Form {

        readonly IApplicationContext ctx = ContextRegistry.GetContext();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MovieLister lister = (MovieLister) ctx.GetObject("MyMovieLister");
            Movie[] movies = lister.MoviesDirectedBy("Roberto Benigni");
            Debug.Print("Searching for movie...");
            foreach (Movie movie in movies){
                Debug.Print($"Movie Title = '{movie.Title}', Director = '{movie.Director}'.");
            }
            Debug.Print("MovieApp Done.");
        }

        // 构造函数测试
        private void button2_Click(object sender, EventArgs e) {
            IMovieFinder finder = (IMovieFinder) ctx.GetObject ("AnotherMovieFinder");
            var findAll = finder.FindAll();
        }

        private void button3_Click(object sender, EventArgs e) {
            IApplicationContext ctx = CreateContextMixXmlAndProgrammatic();
            MovieLister lister = (MovieLister) ctx.GetObject("MyMovieLister");
        }

        // 脱离 App.config文件 代码中直接指定 spring.xml文件来配置Spring容器
        private static IApplicationContext CreateContextMixXmlAndProgrammatic(){
            GenericApplicationContext ctx = new GenericApplicationContext();
            IObjectDefinitionReader objectDefinitionReader = new XmlObjectDefinitionReader(ctx);
            objectDefinitionReader.LoadObjectDefinitions("assembly://chapter4_3_2/chapter4_3_2/AppContextContribution.xml");
            IObjectDefinitionFactory objectDefinitionFactory = new DefaultObjectDefinitionFactory();
            ObjectDefinitionBuilder builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(ColonDelimitedMovieFinder));
            builder.AddConstructorArg("movies.txt");
            ctx.RegisterObjectDefinition("AnotherMovieFinder", builder.ObjectDefinition);
            ctx.Refresh();
            return ctx;
        }


        // 脱离 App.config 和 spring.xml 配置文件 使用纯代码方式 启动Spring容器
        private static IApplicationContext CreateContextProgrammatically(){
            InitializeCommonLogging();
            GenericApplicationContext ctx = new GenericApplicationContext();
            IObjectDefinitionFactory objectDefinitionFactory = new DefaultObjectDefinitionFactory();
            //Create MovieLister and dependency on
            ObjectDefinitionBuilder builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(MovieLister));
            //    <!-- 指定实现类 SimpleMovieFinder    using setter injection... -->
//            builder.AddPropertyReference("MovieFinder", "AnotherMovieFinder");

            // <!-- 指定实现类 SimpleMovieFinder    using setter injection... -->
            builder.AddPropertyReference("MovieFinder", "MyMovieFinder");
            ctx.RegisterObjectDefinition("MyMovieLister", builder.ObjectDefinition);

            // 向容器中注册  ColonDelimitedMovieFinder  实现类
            builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(ColonDelimitedMovieFinder));
            builder.AddConstructorArg("movies.txt");
            ctx.RegisterObjectDefinition("AnotherMovieFinder", builder.ObjectDefinition);
            // 向容器中注册  SimpleMovieFinder  实现类
            builder = ObjectDefinitionBuilder.RootObjectDefinition(objectDefinitionFactory, typeof(SimpleMovieFinder));
            ctx.RegisterObjectDefinition("MyMovieFinder", builder.ObjectDefinition);
            ctx.Refresh();
            return ctx;
        }

        private void button4_Click(object sender, EventArgs e) {
            IApplicationContext ctx = CreateContextProgrammatically();
            MovieLister lister = (MovieLister) ctx.GetObject("MyMovieLister");
        }







        private static void InitializeCommonLogging() {
            var properties = new Common.Logging.Configuration.NameValueCollection();
            properties["configType"] = "INLINE";
            LogManager.Adapter = new Log4NetLoggerFactoryAdapter(properties);
        }

    }
}