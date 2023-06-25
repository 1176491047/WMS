using Volo.Abp.Settings;

namespace VskyWMS.Settings;

public class VskyWMSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(VskyWMSSettings.MySetting1));
    }
}
