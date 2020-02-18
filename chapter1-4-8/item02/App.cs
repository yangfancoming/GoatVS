using System.Diagnostics;
using System.Linq;
using datacollect.model;

namespace chapter1_4_8.item02 {


    public class App {

        public static void test1() {

            var ftpSettings = FtpSettings.getInstance();
            ftpSettings.TbFtpAddr = "111";
            ftpSettings.TbFtpPort = "222";
            ftpSettings.TbFtpAccount = "333";
            ftpSettings.TbFtpPassword = "444";
            var anyNull = judgeAnyNull(ftpSettings);
            Debug.Print(anyNull.ToString());
        }

        // 判断一个对象的 所有属性中 是否存在null或""  如果有返回 true  否则返回false
        // 注意： 传入的实体类对象中的属性 必须有get set 方法！ 否则无法获取其属性
        public static bool judgeAnyNull<T>(T t) {
            var  properties  = t.GetType().GetProperties();
            if (properties.Any(item => item.GetValue(t, null) == "" || item.GetValue(t, null) == null)) {
                return true;
            }
            return false;
        }


        // 不检测某个字段
        public static bool judgeAnyNullEx<T>(T t) {
            var  properties  = t.GetType().GetProperties();
            return properties.Any(item => (item.GetValue(t, null) == null  || item.GetValue(t, null) == "" ) && item.Name != "deviceCode" );
        }

    }
}