using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VskyWMS.Data;
using Volo.Abp.DependencyInjection;

namespace VskyWMS.EntityFrameworkCore;

public class EntityFrameworkCoreVskyWMSDbSchemaMigrator
    : IVskyWMSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreVskyWMSDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the VskyWMSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<VskyWMSDbContext>()
            .Database
            .MigrateAsync();
    }
}
