using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace API.Models;

public class Reference {
    
    
    
    
    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [BsonElement("email")]
    [JsonPropertyName("email")]
    public string Email { get; set; } = String.Empty;

    [BsonElement("phone")]
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = String.Empty;

}