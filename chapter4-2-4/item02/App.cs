using System;
using System.IO;
using System.Windows.Forms;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Objects.Factory;
using Spring.Objects.Factory.Xml;

namespace chapter4_2_4.item02 {


    public class App {

        // 注册上下文方式1： 由于该种方法要读取App.config文件 所以必须要以Winform方式启动加载App.config 不能以测试方法启动 因为那样不会加载App.config
        public static void AppRegistry(){
            IApplicationContext ctx = ContextRegistry.GetContext();
            MessageBox.Show(ctx.GetObject("person").ToString());
        }


        // 注册上下文方式2： 指定spring.xml路径位置 通过： 程序集名称/命名空间/文件名   其中困惑的命名空间，不困惑的方式是  程序集名称chapter4_2_4 就是程序集名称不和要 命名空间混淆
        public static void XmlSystem(){
            //需要选中“Objects.xml”文件，再改变其“生成操作”属性为“生成嵌入的资源
            string[] xmlFiles = {"assembly://chapter4_2_4/chapter4_2_4/Objects.xml"};
            IApplicationContext ctx = new XmlApplicationContext(xmlFiles);
            IObjectFactory factory = ctx;
            Console.WriteLine(factory.GetObject("person").ToString());
        }

        //注册上下文方式3： file://  指定spring.xml文件的物理路径
        public static void FileSystem(){
            IResource input = new FileSystemResource(Path.GetFileName("Objects.xml"));  //实际物理路径
            IObjectFactory factory = new XmlObjectFactory(input);
            Console.WriteLine(factory.GetObject("person").ToString());
        }
    }
}