using Volo.Abp.Settings;

namespace app.Settings;

public class appSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(appSettings.MySetting1));
    }
}
