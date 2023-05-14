using System.Text.Json.Serialization;

namespace MicroserviceСompositeSC.Contracts;

public class Student
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("courseId")]
    public long CourseId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("groupName")]
    public string GroupName { get; set; }

    [JsonPropertyName("rating")]
    public int Rating { get; set; }
}
