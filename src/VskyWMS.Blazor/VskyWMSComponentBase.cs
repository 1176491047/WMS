using VskyWMS.Localization;
using Volo.Abp.AspNetCore.Components;

namespace VskyWMS.Blazor;

public abstract class VskyWMSComponentBase : AbpComponentBase
{
    protected VskyWMSComponentBase()
    {
        LocalizationResource = typeof(VskyWMSResource);
    }
}
