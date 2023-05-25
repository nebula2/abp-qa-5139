using app.Localization;
using Volo.Abp.AspNetCore.Components;

namespace app.Blazor;

public abstract class appComponentBase : AbpComponentBase
{
    protected appComponentBase()
    {
        LocalizationResource = typeof(appResource);
    }
}
