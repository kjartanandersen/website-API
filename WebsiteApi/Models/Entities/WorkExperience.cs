using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace API.Models;

public class WorkExperience
{

    [BsonElement("company_name")]
    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; } = String.Empty;

    [BsonElement("date_from")]
    [JsonPropertyName("date_from")]
    public string DateFrom { get; set; } = String.Empty;

    [BsonElement("date_to")]
    [JsonPropertyName("date_to")]
    public string DateTo { get; set; } = String.Empty;

    [BsonElement("occupation")]
    [JsonPropertyName("occupation")]
    public string Occupation { get; set; } = String.Empty;

    [BsonElement("description")]
    [JsonPropertyName("description")]
    public string Description { get; set; } = String.Empty;

}