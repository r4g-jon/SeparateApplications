using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace FrontWeb.Models
{
    [SiteType(Title = "Default site")]
    public class BlogSite : SiteContent<BlogSite>
    {
        [Region]
        public Regions.SiteInfo Information { get; set; }
    }
}