using RunTracker.Strava.DTOs;

namespace RunTracker.Strava.Services.Interfaces;

public interface IActivitiesService
{
    public Task<IEnumerable<StravaActivityDto>> GetActivities(string accessToken, DateTime from, DateTime to, int page = 1, int perPage = 30);
}
