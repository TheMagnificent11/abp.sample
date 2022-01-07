using Acme.ClubManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.ClubManagement
{
    [DependsOn(
        typeof(ClubManagementEntityFrameworkCoreTestModule)
        )]
    public class ClubManagementDomainTestModule : AbpModule
    {

    }
}