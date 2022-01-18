using System.ComponentModel.DataAnnotations;

namespace SideNavAPI.Data
{
    public class NavItemEntry
    {
        [Key]
        public int id { get; set; }
        public string displayName { get; set; }
        public bool? disabled { get; set; }
        public string? iconName { get; set; }
        public string? route { get; set; }
    }
}
