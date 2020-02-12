using System;

namespace chapter2_1_1.B03.item01 {

    // 创建一个类Teacher，并实现一个说话的方法，注意Say方法必须是虚方法(virtual)，如下：
    public class Teacher {

        public virtual String Say(String msg){
            Console.WriteLine("老师在说话" + msg);
            return "好孩子";
        }
    }
}