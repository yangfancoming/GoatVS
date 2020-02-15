using MongoDB.Bson;

namespace chapter5_3_2 {

    public class InsertApp: BaseClass {


        public static void insert() {
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
    }
}