using System.Diagnostics;

namespace chapter1_3_1.item01 {

    public class Cat :Pet,IClimbTree,ICatchMice {
        public void ClimbTree() {
            Debug.Print("我是cat 我会爬树");
        }

        public void CatchMice() {
            Debug.Print("我是cat 我会抓老鼠");
        }



    }
}