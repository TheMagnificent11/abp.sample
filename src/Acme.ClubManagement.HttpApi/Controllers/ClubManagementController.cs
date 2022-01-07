using Acme.ClubManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.ClubManagement.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ClubManagementController : AbpControllerBase
    {
        protected ClubManagementController()
        {
            LocalizationResource = typeof(ClubManagementResource);
        }
    }
}