using System;
using System.Collections.Generic;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace chapter9_2_2.mybatis {

    public static class BASE_DAL {

        // 单例模式
        private static ISqlMapper sqlMapper;

        private static readonly object sysncObj = new object();

        static BASE_DAL() {
            sqlMapper = GetInstant();
        }

        public static ISqlMapper GetInstant() {
            if (sqlMapper == null) {
                lock (sysncObj) {
                    if (sqlMapper == null) {
                        sqlMapper = new DomSqlMapBuilder().Configure("mybatis/SqlMap.config");//  Map.DataSource.ConnectionString = @"Data Source=Data Source=.\db\sqlite.db;Version=3";
                    }
                }
            }
            return sqlMapper;
        }

        public static IList<T> selectList<T>(String MapperStr, object o = null){
            return sqlMapper.QueryForList<T>(MapperStr, o);
        }

        public static Object selectOne(String MapperStr, object o){
            return sqlMapper.QueryForObject(MapperStr, o);
        }

        public static object insert(String MapperStr, object o) {
            sqlMapper.BeginTransaction();
            var insert1 = sqlMapper.Insert(MapperStr, o);
            sqlMapper.CommitTransaction();
            return insert1;
        }
        public static int update(String MapperStr, object o){
            return sqlMapper.Update(MapperStr, o);
        }
        //public IList<T> List()
        //{

        //    return sqlMapper.QueryForList<T>("DEPT.List", null);
        //}
        public static int deleteList(String MapperStr, int[] ids){
            return sqlMapper.Delete(MapperStr, ids);
        }

        public static int deleteById(String MapperStr, Object o){
            return sqlMapper.Delete(MapperStr, o);
        }

    }
}