using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestMongodb
{
    public class MongoWork : BaseTest
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        private const string conn = "mongodb://admin:123456@192.168.2.213:27017";
        /// <summary>
        /// 指定的数据库
        /// </summary>
        private const string dbName = "logger";
        /// <summary>
        /// 指定的表
        /// </summary>
        private const string tbName = "table_text";

        private IMongoDatabase db;

        private IMongoCollection<LoggerItems> collection;

        public override void Run()
        {
            Init();

            LoggerItems logger = new LoggerItems();
            logger.test = "this is a data";
            InsertOne(logger);
            var collection = GetCollection(tbName);
            var filter = new BsonDocument();
            var list = collection.Find(filter).ToListAsync().Result;
            list.ForEach(p =>
             {
                 Console.WriteLine("ID：" + p["_id"] + ",test：" + p["test"].ToString());
             });

        }

        private void Init()
        {
            MongoClient client = new MongoClient(conn);
            //获取指定数据库
            db = client.GetDatabase(dbName);

            collection = db.GetCollection<LoggerItems>(tbName);
        }

        /// <summary>
        /// 数据集插入一条数据
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="newDocument"></param>
        private void InsertOne(LoggerItems newDocument)
        {
            collection.InsertOne(newDocument);
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        private IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return db.GetCollection<BsonDocument>(collectionName);
        }

    }
}
