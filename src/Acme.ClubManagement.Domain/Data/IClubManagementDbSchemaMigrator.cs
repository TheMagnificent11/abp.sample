using System.Threading.Tasks;

namespace Acme.ClubManagement.Data
{
    public interface IClubManagementDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
