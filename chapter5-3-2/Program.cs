using MongoDB.Bson;
using MongoDB.Driver;

namespace chapter5_3_2 {
    internal class Program {

        public static void Main(string[] args) {

        }

        private static IMongoCollection<BsonDocument> getCollect() {
            // 三个对象, client是连接数据库的客户端, database对应库, collection是对象集合.
            var client = new MongoClient("mongodb://192.168.211.128:27017");
            IMongoDatabase database = client.GetDatabase("foo"); // 数据库名称
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("bar"); // 集合名称
            return collection;
        }

        public static void insert() {
            var collection = getCollect();
            var document = new BsonDocument{
                { "name", "测试数据1" },
                { "type", "大类" },
                { "number", 5 },
                { "info", new BsonDocument
                {
                    { "x", 111 },
                    { "y", 222 }
                }}
            };
            collection.InsertOne(document);
        }

        /**
            find()需要一个filter参数, 根据条件查询
            collection.Find(Builders<BsonDocument>.Filter.Empty);
        */
        public static void find() {
            var collection = getCollect();
            IFindFluent<BsonDocument, BsonDocument> findFluent = collection.Find(Builders<BsonDocument>.Filter.Eq("name", "测试数据1") & Builders<BsonDocument>.Filter.Lt("number", 6));
//            findFluent.
        }

        public static void update() {
            var collection = getCollect();
            collection.UpdateMany(Builders<BsonDocument>.Filter.Eq("name", "测试数据1"), Builders<BsonDocument>.Update.Set("number", 6));
        }

        public static void delete() {
            var collection = getCollect();
//            collection.DeleteMany();
        }

    }
}