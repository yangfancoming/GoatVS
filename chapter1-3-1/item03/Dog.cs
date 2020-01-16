using System.Diagnostics;

namespace chapter1_3_1.item03 {

    public class Dog : IShout{

        public void shout() {
            Debug.Print($"我是狗：汪汪汪！");
        }
    }
}