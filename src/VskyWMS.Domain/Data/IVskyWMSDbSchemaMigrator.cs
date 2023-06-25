using System.Threading.Tasks;

namespace VskyWMS.Data;

public interface IVskyWMSDbSchemaMigrator
{
    Task MigrateAsync();
}
