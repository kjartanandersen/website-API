using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;

namespace API.Models;

public class ProfileDto
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [BsonElement("about_me")]
    [JsonPropertyName("about_me")]
    public string AboutMe { get; set; } = String.Empty;

    [BsonElement("current_residence")]
    [JsonPropertyName("current_residence")]
    public string CurrentResidence { get; set; } = String.Empty;

    [BsonElement("date_of_birth")]
    [JsonPropertyName("date_of_birth")]
    public DateTime DateOfBirth { get; set; } = DateTime.Now;

    [BsonElement("ssn")]
    [JsonPropertyName("ssn")]
    public string Ssn { get; set; } = String.Empty;

    [BsonElement("phone")]
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = String.Empty;

    [BsonElement("email")]
    [JsonPropertyName("email")]
    public string Email { get; set; } = String.Empty;


    [BsonElement("hobbies")]
    [JsonPropertyName("hobbies")]
    public List<string>? Hobbies { get; set; }


    [BsonElement("languages")]
    [JsonPropertyName("languages")]
    public List<Language>? Languages { get; set; }

    [BsonElement("skills")]
    [JsonPropertyName("skills")]
    public List<Skill>? Skills { get; set; }

    [BsonElement("references")]
    [JsonPropertyName("references")]
    public List<Reference>? References { get; set; }

    [BsonElement("education")]
    [JsonPropertyName("education")]
    public List<Education>? Education { get; set; }

    [BsonElement("work_experiences")]
    [JsonPropertyName("work_experiences")]
    public List<WorkExperience>? WorkExperiences { get; set; }

    [BsonElement("links")]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

}