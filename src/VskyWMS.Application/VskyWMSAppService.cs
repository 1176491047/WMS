using VskyWMS.Localization;
using Volo.Abp.Application.Services;

namespace VskyWMS;

/* Inherit your application services from this class.
 */
public abstract class VskyWMSAppService : ApplicationService
{
    protected VskyWMSAppService()
    {
        LocalizationResource = typeof(VskyWMSResource);
    }
}
