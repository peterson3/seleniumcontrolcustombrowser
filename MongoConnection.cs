using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    public class MongoConnection
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }

        private IMongoDatabase _database { get; }

        public MongoConnection()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://localhost:27017/"));
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase("GramCreatDB");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IMongoCollection<Pessoa> Pessoas
        {
            get
            {
                return _database.GetCollection<Pessoa>("Pessoas");
            }
        }
    }
}
