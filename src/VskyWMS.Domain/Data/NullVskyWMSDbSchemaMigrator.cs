using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VskyWMS.Data;

/* This is used if database provider does't define
 * IVskyWMSDbSchemaMigrator implementation.
 */
public class NullVskyWMSDbSchemaMigrator : IVskyWMSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
