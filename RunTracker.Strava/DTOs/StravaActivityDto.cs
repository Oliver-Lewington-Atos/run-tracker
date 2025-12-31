using System.Text.Json.Serialization;

namespace RunTracker.Strava.DTOs;

public sealed class StravaActivityDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("athlete")]
    public StravaAthleteDto Athlete { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("sport_type")]
    public string SportType { get; set; } = default!;

    [JsonPropertyName("distance")]
    public double DistanceMeters { get; set; }

    [JsonPropertyName("moving_time")]
    public int MovingTimeSeconds { get; set; }

    [JsonPropertyName("elapsed_time")]
    public int ElapsedTimeSeconds { get; set; }

    [JsonPropertyName("total_elevation_gain")]
    public double ElevationGainMeters { get; set; }

    [JsonPropertyName("average_speed")]
    public double? AverageSpeedMetersPerSecond { get; set; }

    [JsonPropertyName("average_heartrate")]
    public double? AverageHeartRate { get; set; }

    [JsonPropertyName("max_heartrate")]
    public int? MaxHeartRate { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime StartDateUtc { get; set; }

    [JsonPropertyName("start_date_local")]
    public DateTime StartDateLocal { get; set; }

    [JsonPropertyName("utc_offset")]
    public int UtcOffsetSeconds { get; set; }

    [JsonPropertyName("manual")]
    public bool IsManual { get; set; }

    [JsonPropertyName("private")]
    public bool IsPrivate { get; set; }
}
