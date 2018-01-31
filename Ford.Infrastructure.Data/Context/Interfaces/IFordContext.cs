using MongoDB.Driver;

namespace Ford.Infrastructure.Data.Context.Interfaces
{
    public interface IFordContext
    {
        IMongoDatabase GetContext();
    }
}