using System;
using System.Diagnostics;
using System.Reflection;

namespace chapter1_4_8.item01 {
    public class App {

        // 如何获取一个Type类对象 方法一：通过 GetType 方法
        public static void test() {
            var bc = new BaseClass();
            var dc = new DerivedClass();
            BaseClass[] bca = { bc, dc };
            foreach(var v in bca){
                //获取类的类型
                Type t = v.GetType();
                Console.WriteLine("Object Type: {0}", t.Name);
                //获取类中的字段
                FieldInfo[] fi = t.GetFields();
                foreach (var f in fi)
                    Console.WriteLine("     Field:{0}", f.Name);
            }
            Console.WriteLine("End!");
        }

        // 如何获取一个Type类对象  方法二：还可以通过typeof()方法来获取一个类型的Type对象引用。
        public static void test2() {
            //通过程序集获取类型
            var baseType = Assembly.GetExecutingAssembly().GetType("chapter1_4_8.item01.BaseClass");
            Debug.Print(baseType.Name);
            var derivedType = Assembly.GetExecutingAssembly().GetType("chapter1_4_8.item01.DerivedClass");
            Debug.Print(derivedType.Name);
        }

        // 如何获取一个Type类对象  方法三：
        public static void test3() {
            object type = Assembly.Load("chapter1_4_8").CreateInstance("chapter1_4_8.item01.DerivedClass");
            DerivedClass temp = type as DerivedClass;
            Debug.Print(temp.BaseField.ToString());

        }
    }
}