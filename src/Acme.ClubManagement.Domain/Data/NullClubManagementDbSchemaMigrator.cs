using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.ClubManagement.Data
{
    /* This is used if database provider does't define
     * IClubManagementDbSchemaMigrator implementation.
     */
    public class NullClubManagementDbSchemaMigrator : IClubManagementDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}