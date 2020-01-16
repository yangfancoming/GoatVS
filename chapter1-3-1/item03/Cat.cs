
using System.Diagnostics;

namespace chapter1_3_1.item03 {

    public class Cat :IShout{

        public void shout() {
            Debug.Print($"我是猫：喵喵喵！");
        }
    }
}