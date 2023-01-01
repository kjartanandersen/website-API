
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models;

public class Link {

    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [BsonElement("url")]
    [JsonPropertyName("url")]
    public string Url { get; set; } = String.Empty;
}