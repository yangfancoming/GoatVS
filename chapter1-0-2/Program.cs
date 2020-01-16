using System;
using System.Linq;

namespace chapter1_0_2 {

    class Program {


        static void Main() {
            int sum1 = Function1.SumVals(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Values = {0}", sum1);

            int sum2 = Function1.SumVals(1, 5);
            Console.WriteLine("Summed Values = {0}", sum2);


            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            var max = myArray.Select(n=>n).Max();
            Console.WriteLine("The maximum value in myArray is {0}", max);
        }
    }
}