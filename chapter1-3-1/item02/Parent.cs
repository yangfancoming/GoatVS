using System.Diagnostics;

namespace chapter1_3_1.item02 {

    public class Parent {

        public void F() {
            Debug.Print("Parent.F()");
        }

        public virtual void G()  {//抽象方法
            Debug.Print("Parent.G()");
        }

        public int Add(int x, int y) {
            return x + y;
        }

        //重载(overload)Add函数
        public float Add(float x, float y)  {
            return x + y;
        }

    }
}