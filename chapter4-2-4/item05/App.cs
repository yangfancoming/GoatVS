using System.Diagnostics;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace chapter4_2_4.item05 {

    public static class App {

        public static readonly string[] xmlFiles = {"assembly://chapter4_2_4/chapter4_2_4/Objects.xml"};
        public static readonly IApplicationContext context = new XmlApplicationContext(xmlFiles);
        public static readonly IObjectFactory factory = context;

        public static void CreateWithSingleton() {
            var obj1 = factory.GetObject("personDao");
            var obj2 = factory.GetObject("personDao");
            Debug.Print((obj1 == obj2).ToString());
        }

        public static void CreateWithOutSingleton() {
            var obj1 = factory.GetObject("person");
            var obj2 = factory.GetObject("person");
            Debug.Print((obj1 == obj2).ToString());
        }


        public static void CreateWithLazy() {
            var dao = factory.GetObject("personDao");
            Debug.Print(dao.ToString());
            var server = factory.GetObject("personServer");
            Debug.Print(server.ToString());
        }
    }
}