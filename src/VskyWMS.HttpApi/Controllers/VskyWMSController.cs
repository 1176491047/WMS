using VskyWMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VskyWMS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VskyWMSController : AbpControllerBase
{
    protected VskyWMSController()
    {
        LocalizationResource = typeof(VskyWMSResource);
    }
}
