using Volo.Abp.Settings;

namespace Acme.ClubManagement.Settings
{
    public class ClubManagementSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ClubManagementSettings.MySetting1));
        }
    }
}
