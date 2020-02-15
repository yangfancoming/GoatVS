using MongoDB.Bson;
using MongoDB.Driver;

namespace chapter5_3_2 {

    public  class UpdateApp : BaseClass {


        public static void update() {
            collection.UpdateMany(Builders<BsonDocument>.Filter.Eq("name", "测试数据1"), Builders<BsonDocument>.Update.Set("number", 6));
        }
    }
}