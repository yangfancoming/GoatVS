using System;
using System.Diagnostics;

namespace chapter1_1_1.item03 {
    /**
            Func委托
            Func是有返回值的泛型委托，<>中，最后一个类型为返回值类型。
            Func<int> 表示无参，返回值为int的委托
            Func<object,string,int> 表示传入参数为object, string 返回值为int的委托
            Func<object,string,int> 表示传入参数为object, string 返回值为int的委托
            Func<T1,T2,,T3,int> 表示传入参数为T1,T2,,T3(泛型)返回值为int的委托
            Func至少0个参数，至多16个参数，根据返回值泛型返回。必须有返回值，不可void

            Func<out TResult>
            Func<in T,out TResult>
            Func<in T1,in T2,...,in T16, out TResult>
    */
    public class App {

        private static int Test1(){
            return 1;
        }
        // 无参 有返回值
        public static void test1() {
            Func<int> a = Test1;
            Debug.Print(a().ToString());
        }

        private static int Test2(string str){
            return 100;
        }

        // 有参  有返回值
        public static void test2() {
            Func<string, int> a = Test2;
            Console.WriteLine(a("Test1"));
        }

        private static readonly Func<string, int> test3 = s => 100 + Convert.ToInt32(s);

        // lambda 方式
        public static void test33() {
            Console.WriteLine(test3("200"));
        }

    }
}