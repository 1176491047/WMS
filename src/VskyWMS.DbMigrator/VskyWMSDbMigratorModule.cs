using VskyWMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace VskyWMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VskyWMSEntityFrameworkCoreModule),
    typeof(VskyWMSApplicationContractsModule)
)]
public class VskyWMSDbMigratorModule : AbpModule
{

}
