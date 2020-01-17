using System.Diagnostics;
using Spring.Context;
using Spring.Context.Support;

namespace item01 {

    public static class Item01Demo01 {

        // 创建方法的 三种方式！

        public static void NormalMethod(){
            IPerson dao = new Person();
            dao.Save();
            Debug.Print("我是一般方法");
        }

        public static void FactoryMethod(){
            IPerson dao = DataAccess.CreatePersonDao();
            dao.Save();
            Debug.Print("我是工厂方法");
        }


        /**
         * 这种取bean的方式  需要在App.config中 方式一 ： 这样配置
            <context>
                <resource uri="config://spring/objects" />
            </context>

            <objects xmlns="http://www.springframework.net">
                <object id="Person" type="item01.Person,chapter4_2_4" />
            </objects>
        */
        public static void IoCMethod(){
            IApplicationContext ctx = ContextRegistry.GetContext();
            if (ctx.GetObject("Person") is IPerson dao){
                dao.Save();
                Debug.Print("我是IoC方法");
            }
        }


    }
}