using System;
using System.Collections.Generic;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace chapter9_2_2.mybatis {

    public static class BaseDao {

        // 单例模式
        private static ISqlMapper sqlMapper;

        private static readonly object sysncObj = new object();

        static BaseDao() {
            sqlMapper = GetInstant();
        }

        public static ISqlMapper GetInstant() {
            if (sqlMapper != null) return sqlMapper;
            lock (sysncObj) {
                if (sqlMapper == null) {
//                    sqlMapper = Mapper.Instance();
                    sqlMapper = new DomSqlMapBuilder().Configure("mybatis/SqlMap.config");//  Map.DataSource.ConnectionString = @"Data Source=Data Source=.\db\sqlite.db;Version=3";
                }
            }
            return sqlMapper;
        }

        public static IList<T> selectList<T>(this string MapperStr, object o = null){
            return sqlMapper.QueryForList<T>(MapperStr, o);
        }

        public static object selectById(this string MapperStr, object o){
            return sqlMapper.QueryForObject(MapperStr, o);
        }

        public static object selectOne(string MapperStr, object o){
            return sqlMapper.QueryForObject(MapperStr, o);
        }

        public static object insert(string MapperStr, object o) {
            sqlMapper.BeginTransaction();
            var insert1 = sqlMapper.Insert(MapperStr, o);
            sqlMapper.CommitTransaction();
            return insert1;
        }
        public static int update(string MapperStr, object o){
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