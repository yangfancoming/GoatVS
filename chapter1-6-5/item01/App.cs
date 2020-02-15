using System;
using System.Collections.Generic;

namespace chapter1_6_5.item01 {


    public class App {
        //创建泛型哈希表,Key类型为int,Value类型为string
        public static Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        public static void add() {
            //1.添加元素
            myDictionary.Add(1, "a");
            myDictionary.Add(2, "b");
            myDictionary.Add(3, "c");
            //2.删除元素
            myDictionary.Remove(3);

            //3.假如不存在元素则添加元素
            if (!myDictionary.ContainsKey(4)){
                myDictionary.Add(4, "d");
            }

            //4.显示容量和元素个数
            Console.WriteLine("元素个数：{0}",myDictionary.Count);
            //5.通过key查找元素
            if (myDictionary.ContainsKey(1)){
                Console.WriteLine("key:{0},value:{1}","1", myDictionary[1]);
                Console.WriteLine(myDictionary[1]);
            }

            //6.通过KeyValuePair遍历元素
            foreach (KeyValuePair<int,string>kvp in myDictionary){
                Console.WriteLine("key={0},value={1}", kvp.Key, kvp.Value);

            }

            //7.得到哈希表键的集合
            Dictionary<int, string>.KeyCollection keyCol = myDictionary.Keys;
            //遍历键的集合
            foreach (int n in keyCol){
                Console.WriteLine("key={0}", n);
            }

            //8.得到哈希表值的集合
            Dictionary<int, string>.ValueCollection valCol = myDictionary.Values;
            //遍历值的集合
            foreach( string s in valCol){
                Console.WriteLine("value：{0}",s);
            }
        }

        public static void ContainsKey() { //

        }

        public static void Remove() { //
        }

        public static void test() { //

        }
    }
}