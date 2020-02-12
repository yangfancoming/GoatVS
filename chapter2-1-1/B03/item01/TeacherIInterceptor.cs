using System;
using Castle.DynamicProxy;

namespace chapter2_1_1.B03.item01 {


    // 创建一个拦截器并实现IInterceptor接口
    public class TeacherIInterceptor : IInterceptor {

        public void Intercept(IInvocation invocation) {
            Console.WriteLine("进入方法，参数:"+invocation.Arguments[0]);
            invocation.Proceed();
            Console.WriteLine("离开方法，返回值:"+invocation.ReturnValue);
        }
    }
}