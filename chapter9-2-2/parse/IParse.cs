
using chapter9_2_2.constant;
using Quartz;

namespace chapter9_2_2.parse {


    public interface IParse<in T, out R> : IJob{


        FileType fileType();

        /// <summary>
        /// 解析接口
        /// </summary>
        /// <param name="T">输入参数  文件 xml csv json ...</param>
        /// <param name="R">输出参数  解析结果</param>
        R parse(T t);


    }
}
