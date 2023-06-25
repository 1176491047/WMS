using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace VskyWMS;

[Dependency(ReplaceServices = true)]
public class VskyWMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VskyWMS";
}
