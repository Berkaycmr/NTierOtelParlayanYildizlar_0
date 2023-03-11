using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public AppUserMap()
        {
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }

    }
}
