using System.Data;

namespace chapter4_2_8.IBLL {

    // 数据库服务接口
    public interface IDatabaseService {

        /// 根据SQL语句查询数据
        DataTable GetDataTableBySQL();

        /// 获取数据库类型
        string GetDbTyoe();
    }
}