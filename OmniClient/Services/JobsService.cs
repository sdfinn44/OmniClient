

namespace OmniClient.Services;

public class JobsService
{
    public async Task<List<Job>> GetJobs()
    {
        await Task.Delay(20);
        List<Job> result = new();
       

        return result;
    }
}
