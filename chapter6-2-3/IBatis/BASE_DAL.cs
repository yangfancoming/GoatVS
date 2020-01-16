//using System;
//using System.Collections;
//using MyBatis;
//
//namespace DAL
//{
//   public  class BASE_DAL
//    {
//
//       public IList selectList(String MapperStr, object o){
//           return (IList)MyBatisProvider.GetInstanse().QueryForList(MapperStr, o);
//       }
//       public Object selectOne(String MapperStr, object o)
//       {
//
//           return MyBatisProvider.GetInstanse().QueryForObject(MapperStr, o);
//       }
//       public void Insert(String MapperStr, object o)
//       {
//           MyBatisProvider.GetInstanse().Insert(MapperStr, o);
//
//       }
//       public int update(String MapperStr, object o)
//       {
//           return MyBatisProvider.GetInstanse().Update(MapperStr, o);
//       }
//        //public IList<T> List()
//        //{
//
//        //    return MyBatisProvider.GetInstanse().QueryForList<T>("DEPT.List", null);
//        //}
//       public int deleteList(String MapperStr, int[] ids)
//       {
//           return MyBatisProvider.GetInstanse().Delete(MapperStr, ids);
//       }
//
//       public int delete(String MapperStr, Object o)
//       {
//           return MyBatisProvider.GetInstanse().Delete(MapperStr, o);
//       }
//
//    }
//}
