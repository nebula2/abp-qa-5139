using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace app.Blazor;

[Dependency(ReplaceServices = true)]
public class appBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "app";
}
