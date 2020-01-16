//
//using System.Xml;
//using IBatisNet.Common.Utilities;
//using IBatisNet.DataMapper;
//using IBatisNet.DataMapper.Configuration;
//
//namespace MyBatis
//{
//    public class MyBatisProvider
//    {
//        private static ISqlMapper _sqlMapper;
//        private static object sysncObj = new object();
//        public static ISqlMapper GetInstanse()
//        {
//            if (_sqlMapper == null)
//            {
//                lock (sysncObj)
//                {
//                    if (_sqlMapper == null)
//                    {
////                        XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("IBatis.SqlMap.config,IBatis");
////                        XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("IBatis/SqlMap.config");
//                        XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument(@"E:\Code\C#_code\RiderLearning\GoatVS\chapter6-2-3\IBatis\SqlMap.config");
//                        _sqlMapper = new DomSqlMapBuilder().Configure(sqlMapConfig);  //---第三种
//
//                    }
//                }
//            }
//            return _sqlMapper;
//        }
//    }
//}
