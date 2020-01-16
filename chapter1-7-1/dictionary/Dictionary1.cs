using System.Collections.Generic;
using System.Diagnostics;

namespace chapter1_7_1.dictionary {

    public class Dictionary1 {

        private static Dictionary<int,string> myDictionary = new Dictionary<int,string>();

        public static void test() {
            myDictionary.Add(1,"C#");
            myDictionary.Add(2,"C++");
            myDictionary.Add(3,"ASP.NET");
            myDictionary.Add(4,"MVC");

            // 获取元素
            var s = myDictionary[1];
            Debug.Print(s);

            // 判断元素
            if(myDictionary.ContainsKey(1)){
                Debug.Print("3、 通过Key查找元素   Key---{0},Value---{1}","1", s);
            }

            foreach (var kvp  in myDictionary) {
                Debug.Print(" 4、通过KeyValuePair遍历元素     Key = {0}, Value = {1}",kvp.Key, kvp.Value);
            }

            Dictionary<int,string>.KeyCollection keyCol = myDictionary.Keys;
            foreach (var key in keyCol) {
                Debug.Print("5、仅遍历键 Keys 属性    Key = {0}", key);
            }

            Dictionary<int,string>.ValueCollection valueCol=myDictionary.Values;
            foreach (var value in valueCol) {
                Debug.Print("6、仅遍历值 Valus属性 Value = {0}", value);
            }


            // 删除元素
            myDictionary.Remove(1);
            if(myDictionary.ContainsKey(1)){
                Debug.Print(" 7、通过Remove方法移除指定的键值 Key:{0},Value:{1}","1", s);
            }
            else{
                Debug.Print(" 7、通过Remove方法移除指定的键值 不存在 Key : 1");
            }
        }

    }
}