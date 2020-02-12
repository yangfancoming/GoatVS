using Castle.DynamicProxy;

namespace chapter2_1_1.B03.item01 {


    public static class App {

        public static void test1() {
            Teacher teacher = CreateLandlordProxy();
            teacher.Say("nihao");
        }

        private static Teacher CreateLandlordProxy() {
            ProxyGenerator proxyGenerator = new ProxyGenerator();
            Teacher proyLandlord = proxyGenerator.CreateClassProxy<Teacher>(new TeacherIInterceptor());
            return proyLandlord;
        }

    }
}