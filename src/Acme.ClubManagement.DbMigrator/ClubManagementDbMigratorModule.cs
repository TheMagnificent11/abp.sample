using Acme.ClubManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.ClubManagement.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ClubManagementEntityFrameworkCoreModule),
        typeof(ClubManagementApplicationContractsModule)
        )]
    public class ClubManagementDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
