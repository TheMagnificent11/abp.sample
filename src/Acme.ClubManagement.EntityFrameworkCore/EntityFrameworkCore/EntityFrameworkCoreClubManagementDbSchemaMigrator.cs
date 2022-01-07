using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.ClubManagement.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.ClubManagement.EntityFrameworkCore
{
    public class EntityFrameworkCoreClubManagementDbSchemaMigrator
        : IClubManagementDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreClubManagementDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ClubManagementDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ClubManagementDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
