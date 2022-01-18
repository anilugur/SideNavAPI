namespace SideNavAPI.Modules
{
    public class NavItem
    {
        public string displayName { get; set; }
        public bool? disabled { get; set; }
        public string? iconName { get; set; }
        public string? route { get; set; }
    }
}
