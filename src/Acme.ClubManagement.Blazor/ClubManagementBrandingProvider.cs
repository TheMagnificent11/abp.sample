using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.ClubManagement.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class ClubManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ClubManagement";
    }
}
