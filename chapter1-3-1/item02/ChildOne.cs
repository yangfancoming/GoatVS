
using System.Diagnostics;

namespace chapter1_3_1.item02 {

    public class ChildOne:Parent {

        //覆写(overwrite)父类函数
        public new void F() {
            Debug.Print("ChildOne.F()");
        }

        //重写(override)父类虚函数,主要实现多态
        public override void G() {
            Debug.Print("ChildOne.G()");
        }

    }
}