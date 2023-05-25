using System;
using System.Threading.Tasks;
using Volo.Abp.BackgroundJobs;

namespace app;

public class TestAppService : appAppService
{
    private readonly IBackgroundJobManager _backgroundJobManager;

    public TestAppService(IBackgroundJobManager backgroundJobManager)
    {
        _backgroundJobManager = backgroundJobManager;
    }

    public async Task SendDelayEmail()
    {
        _ = await _backgroundJobManager.EnqueueAsync(
            new EmailNotificationArgs { Email = "test", Subject = "test", Body = "test" },
            delay: TimeSpan.FromMinutes(3));
    }
}