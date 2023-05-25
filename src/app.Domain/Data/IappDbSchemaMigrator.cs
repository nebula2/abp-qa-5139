using System.Threading.Tasks;

namespace app.Data;

public interface IappDbSchemaMigrator
{
    Task MigrateAsync();
}
