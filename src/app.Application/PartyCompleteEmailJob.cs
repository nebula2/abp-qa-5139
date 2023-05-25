using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace app;

public class PartyCompleteEmailJob : AsyncBackgroundJob<EmailNotificationArgs>, ITransientDependency
{
    public override Task ExecuteAsync(EmailNotificationArgs args)
    {
        Logger.LogInformation("------------- Sending email to " + args.Email + " with subject " + args.Subject + " and body " +
        args.Body + "");
        return Task.CompletedTask;
    }
}