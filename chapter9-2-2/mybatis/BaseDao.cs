﻿using System;
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

        private static ISqlMapper GetInstant() {
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

        public static T selectById<T>(this string MapperStr, object o){
            return sqlMapper.QueryForObject<T>(MapperStr, o);
        }
        public static T selectOne<T>(this string MapperStr, object o){
            return sqlMapper.QueryForObject<T>(MapperStr, o);
        }

//        public static object selectOne(string MapperStr, object o){
//            return sqlMapper.QueryForObject(MapperStr, o);
//        }

        public static object insert(this string MapperStr, object o) {
            sqlMapper.BeginTransaction();
            var insert1 = sqlMapper.Insert(MapperStr, o);
            sqlMapper.CommitTransaction();
            return insert1;
        }
        public static int update<T>(this string MapperStr, T o){
            return sqlMapper.Update(MapperStr, o);
        }

        public static int deleteList(String MapperStr, int[] ids){
            return sqlMapper.Delete(MapperStr, ids);
        }

        public static int deleteById(this String MapperStr, Object o){
            return sqlMapper.Delete(MapperStr, o);
        }

    }
}