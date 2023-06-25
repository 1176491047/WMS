using Volo.Abp.Modularity;

namespace VskyWMS;

[DependsOn(
    typeof(VskyWMSApplicationModule),
    typeof(VskyWMSDomainTestModule)
    )]
public class VskyWMSApplicationTestModule : AbpModule
{

}
