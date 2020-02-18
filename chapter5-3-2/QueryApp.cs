using MongoDB.Bson;
using MongoDB.Driver;

namespace chapter5_3_2 {


    public class QueryApp : BaseClass{

 /**
      find()需要一个filter参数, 根据条件查询
      collection.Find(Builders<BsonDocument>.Filter.Empty);
  */
        public static void find() {
            IFindFluent<BsonDocument, BsonDocument> findFluent = collection.Find(Builders<BsonDocument>.Filter.Eq("name", "测试数据1") & Builders<BsonDocument>.Filter.Lt("number", 6));
        }

        public static void find1() {
            var client = new MongoClient("mongodb://192.168.211.128:27017");
            IMongoDatabase database = client.GetDatabase("foo"); // 数据库名称
            IMongoCollection<BsonDocument> temp = database.GetCollection<BsonDocument>("bar"); // 集合名称
            var temp1 = temp.Find(new BsonDocument()).ToList();
        }
    }
}