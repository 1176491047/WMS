using VskyWMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VskyWMS;

[DependsOn(
    typeof(VskyWMSEntityFrameworkCoreTestModule)
    )]
public class VskyWMSDomainTestModule : AbpModule
{

}
