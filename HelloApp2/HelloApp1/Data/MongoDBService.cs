using MongoDB.Driver;

namespace HelloApp1.Data
{
    public class MongoDBService
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase? _database;
        public MongoDBService(IConfiguration configuration)
        {
            _configuration = configuration;
            var connectionString = _configuration.GetConnectionString("DBconnection");
            var mongourl = MongoUrl.Create(connectionString);
            var MongoClient = new MongoClient(mongourl);
            _database = MongoClient.GetDatabase(mongourl.DatabaseName);
        }
        public IMongoDatabase? Database => _database;
    }
}
