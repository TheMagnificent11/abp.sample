using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.ClubManagement.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ClubManagementDbContextFactory : IDesignTimeDbContextFactory<ClubManagementDbContext>
    {
        public ClubManagementDbContext CreateDbContext(string[] args)
        {
            ClubManagementEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ClubManagementDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ClubManagementDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.ClubManagement.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
