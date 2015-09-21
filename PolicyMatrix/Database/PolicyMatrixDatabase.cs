using MongoDB.Driver;
using PolicyMatrix.Configuration;

namespace PolicyMatrix.Database
{
    public class PolicyMatrixDatabase : IPolicyMatrixDatabase
    {
        private readonly IMongoDatabase _database;

        public PolicyMatrixDatabase(IPolicyMatrixConfiguration configuration)
        {
            var url = MongoUrl.Create(configuration.ConnectionString);

            _database = new MongoClient(url).GetDatabase(url.DatabaseName);   
        }

        
    }
}