using System;
using System.Diagnostics;

namespace chapter1_5_1 {
    public class Enum1 {
        // 默认情况下枚举中每个元素的基本类型都是int。可以使用冒号指定另一种整数类型。
        public enum Weekdays { Mon, Tues,Wed,Thur,Fri,Sat,Sun }

        public static void weekday(Weekdays day){
            switch (day){
                case Weekdays.Mon:
                    Debug.Print("今天是星期一");
                    break;
                case Weekdays.Tues:
                    Debug.Print("明天是星期二");
                    break;
                case Weekdays.Wed:
                    Debug.Print("后天是星期三");
                    break;
                case Weekdays.Thur:
                    Debug.Print("几天后星期四");
                    break;
                case Weekdays.Fri:
                    Debug.Print("几天后星期五");
                    break;
                case Weekdays.Sat:
                    Debug.Print("几天后星期六");
                    break;
                case Weekdays.Sun:
                    Debug.Print("几天后星期日");
                    break;
                default:
                    Debug.Print("参数错误！");
                    break;
            }
        }
    }
}