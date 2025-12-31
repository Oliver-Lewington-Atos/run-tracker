using RunTracker.Strava.DTOs;
using RunTracker.Strava.Services.Interfaces;

namespace RunTracker.Strava.Services
{
    public class ActivitiesService : IActivitiesService
    {
        public Task<IEnumerable<StravaActivityDto>> GetActivities(string accessToken, DateTime from, DateTime to, int page = 1, int perPage = 30)
        {
            throw new NotImplementedException();
        }
    }
}
