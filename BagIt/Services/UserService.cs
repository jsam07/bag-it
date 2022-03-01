using BagIt.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BagIt.Services;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;

    public UserService(IOptions<UsersDbSettings> usersDatabaseSettings) {
        var mongoClient = new MongoClient(
            usersDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            usersDatabaseSettings.Value.DatabaseName);

        _usersCollection = mongoDatabase.GetCollection<User>(
            usersDatabaseSettings.Value.CollectionName);
    }

    public async Task<List<User>> GetAsync()
    {
        return await _usersCollection.Find(_ => true).ToListAsync();
    }
}