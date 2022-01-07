using Acme.ClubManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.ClubManagement.Permissions
{
    public class ClubManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ClubManagementPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ClubManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ClubManagementResource>(name);
        }
    }
}
