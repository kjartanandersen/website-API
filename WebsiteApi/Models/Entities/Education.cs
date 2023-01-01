using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace API.Models;

public class Education
{

    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [BsonElement("date_from")]
    [JsonPropertyName("date_from")]
    public string DateFrom { get; set; } = String.Empty;

    [BsonElement("date_to")]
    [JsonPropertyName("date_to")]
    public string DateTo { get; set; } = String.Empty;

    [BsonElement("subject")]
    [JsonPropertyName("subject")]
    public string Subject { get; set; } = String.Empty;

    [BsonElement("description")]
    [JsonPropertyName("description")]
    public string Description { get; set; } = String.Empty;


}