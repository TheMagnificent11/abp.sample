using Acme.ClubManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.ClubManagement.Blazor
{
    public abstract class ClubManagementComponentBase : AbpComponentBase
    {
        protected ClubManagementComponentBase()
        {
            LocalizationResource = typeof(ClubManagementResource);
        }
    }
}
