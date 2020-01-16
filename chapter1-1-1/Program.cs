using System.Collections.Generic;
using System.Diagnostics;

namespace chapter1_1_1 {
    internal class Program {

        static List<int> list = new List<int>(){1,2,3,4,5};

        public static void Main(string[] args) {

            Debug.Print("数组中的最大值" + Delegate1.getMax(list));


            Debug.Print("数组中的最大值" + Delegate1.getMax2(list));
            Debug.Print("数组中的最小值" + Delegate1.getMin2(list));
            
            
            List<int> for1 = Delegate1.for1(list);
            Debug.Print("数组中大于2的元素" + for1.Count);

            List<int> for2 = Delegate1.for2(list);
            Debug.Print("数组中偶数的元素" + for2.Count);

           Debug.Print("数组中的最大值" + Delegate2.getMaxMinTest1(list,Delegate2.getMax2));
           Debug.Print("数组中的最小值" + Delegate2.getMaxMinTest1(list,Delegate2.getMin2));
        }
    }
}