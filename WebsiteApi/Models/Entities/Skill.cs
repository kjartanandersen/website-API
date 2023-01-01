using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace API.Models;

public class Skill {

    

    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("proficiency")]
    [JsonPropertyName("proficiency")]
    public string Proficiency { get; set; } = string.Empty;

}