using MongoDB.Bson;
using MongoDB.Driver;

namespace chapter5_3_2 {


    public  class BaseClass {

        public static IMongoCollection<BsonDocument> collection;

        public BaseClass() {
            // 三个对象, client是连接数据库的客户端, database对应库, collection是对象集合.
            var client = new MongoClient("mongodb://192.168.211.128:27017");
            IMongoDatabase database = client.GetDatabase("foo"); // 数据库名称
            IMongoCollection<BsonDocument> temp = database.GetCollection<BsonDocument>("bar"); // 集合名称
            collection = temp;
        }

    }
}