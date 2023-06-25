using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace VskyWMS.Blazor;

[Dependency(ReplaceServices = true)]
public class VskyWMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VskyWMS";
}
