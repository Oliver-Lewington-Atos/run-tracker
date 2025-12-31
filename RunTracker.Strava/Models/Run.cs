using System.ComponentModel.DataAnnotations;


namespace RunTracker.Strava.Models;
public class Run
{
    [Key]
    public long Id { get; set; }

    // Strava identity
    [Required]
    public long StravaActivityId { get; set; }

    [Required]
    public long StravaAthleteId { get; set; }

    // Run metrics
    public double DistanceMeters { get; set; }
    public int MovingTimeSeconds { get; set; }
    public int ElapsedTimeSeconds { get; set; }
    public double ElevationGainMeters { get; set; }

    // Optional metrics
    public double? AverageSpeedMetersPerSecond { get; set; }
    public int? AverageHeartRate { get; set; }
    public int? MaxHeartRate { get; set; }

    // Dates
    public DateTime StartDateUtc { get; set; }
    public DateTime StartDateLocal { get; set; }
    public int UtcOffsetSeconds { get; set; }

    // Metadata
    public bool IsManual { get; set; }
    public bool IsPrivate { get; set; }

    // Audit
    public DateTime ImportedAtUtc { get; set; }
}

