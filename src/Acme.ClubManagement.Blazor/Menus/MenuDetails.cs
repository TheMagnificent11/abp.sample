namespace Acme.ClubManagement.Blazor.Menus;

public class MenuDetails
{
    public MenuDetails(string name, string localization, string url = null, string icon = null)
    {
        this.Name = name;
        this.Localization = localization;
        this.Icon = icon;
        this.Url = url;
        this.Icon = icon;
    }

    public string Name { get; }

    public string Localization { get; }

    public string Url { get; }

    public string Icon { get; }
}
