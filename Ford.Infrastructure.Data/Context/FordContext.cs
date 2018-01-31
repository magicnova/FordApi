using Ford.Infrastructure.Data.Context.Interfaces;
using MongoDB.Driver;

namespace Ford.Infrastructure.Data.Context
{
    public class FordContext :IFordContext
    {
        private readonly IMongoDatabase _database = null;

        public FordContext(string connectionString, string database)
        {
            var client = new MongoClient(connectionString);
             _database = client.GetDatabase(database);
        }

        
        public IMongoDatabase GetContext()
        {
return _database;

        }
    }
}