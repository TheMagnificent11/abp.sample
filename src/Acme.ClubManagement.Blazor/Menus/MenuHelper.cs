using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using Volo.Abp.UI.Navigation;

namespace Acme.ClubManagement.Blazor.Menus;

public sealed class MenuHelper
{
    private readonly Dictionary<string, MenuDetails> menuDetails;
    private readonly IStringLocalizer localizer;

    public MenuHelper(IStringLocalizer localizer)
    {
        this.menuDetails = new()
        {
            { MenuItems.Home, new MenuDetails(MenuItems.Home, "Menu:Home", icon: "fas fa-home") },
            { MenuItems.People, new MenuDetails(MenuItems.People, "Menu:People", url: "/people", icon: "fas fa-users") }
        };

        this.localizer = localizer;
    }

    public ApplicationMenuItem GetMenuItem(string name)
    {
        var details = this.menuDetails[name];

        var appMenuItem = new ApplicationMenuItem(details.Name, this.localizer[details.Localization]);

        if (details.Url != null)
        {
            appMenuItem.Url = details.Url;
        }

        if (details.Icon != null)
        {
            appMenuItem.Icon = details.Icon;
        }

        return appMenuItem;
    }

    public static class MenuItems
    {
        public const string Home = "Home";
        public const string People = "People";
    }
}
