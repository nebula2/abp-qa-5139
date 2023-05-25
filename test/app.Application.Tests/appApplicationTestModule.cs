using Volo.Abp.Modularity;

namespace app;

[DependsOn(
    typeof(appApplicationModule),
    typeof(appDomainTestModule)
    )]
public class appApplicationTestModule : AbpModule
{

}
