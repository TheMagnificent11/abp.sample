using System;
using System.Collections.Generic;
using System.Text;
using Acme.ClubManagement.Localization;
using Volo.Abp.Application.Services;

namespace Acme.ClubManagement
{
    /* Inherit your application services from this class.
     */
    public abstract class ClubManagementAppService : ApplicationService
    {
        protected ClubManagementAppService()
        {
            LocalizationResource = typeof(ClubManagementResource);
        }
    }
}
