using System.Text.Json.Serialization;

namespace RunTracker.Strava.DTOs;

public sealed class StravaAthleteDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
