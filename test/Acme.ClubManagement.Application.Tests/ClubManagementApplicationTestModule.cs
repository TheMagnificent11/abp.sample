using Volo.Abp.Modularity;

namespace Acme.ClubManagement
{
    [DependsOn(
        typeof(ClubManagementApplicationModule),
        typeof(ClubManagementDomainTestModule)
        )]
    public class ClubManagementApplicationTestModule : AbpModule
    {

    }
}