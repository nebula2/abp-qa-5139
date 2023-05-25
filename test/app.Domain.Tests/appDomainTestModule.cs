using app.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace app;

[DependsOn(
    typeof(appEntityFrameworkCoreTestModule)
    )]
public class appDomainTestModule : AbpModule
{

}
