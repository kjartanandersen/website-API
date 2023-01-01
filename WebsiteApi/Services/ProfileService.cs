using API.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;


namespace API.Services;

public class ProfileService
{
    private readonly IMongoCollection<ProfileDto> _profileCollection;

    public ProfileService(IOptions<MongoDBSettings> mongoDBSettings) 
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase db = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _profileCollection = db.GetCollection<ProfileDto>(mongoDBSettings.Value.ProfilesCollection);
    }
    
    public async Task<List<ProfileDto>> GetAsync() {
        return await _profileCollection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task CreateAsync(ProfileDto language) { 
        await _profileCollection.InsertOneAsync(language);
    }

    public async Task UpdateAsync(ProfileDto language) {
        var filter = Builders<ProfileDto>.Filter.Eq(p => p.Id, language.Id);
        var found = await _profileCollection.FindOneAndReplaceAsync(filter, language);
        
    }
    
    public async Task DeleteAsync(string id) {
        FilterDefinition<ProfileDto> filter = Builders<ProfileDto>.Filter.Eq("Id", id);
        await _profileCollection.DeleteOneAsync(filter);
    return;
}

}