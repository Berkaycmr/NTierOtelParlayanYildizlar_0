using Project.ENTITIES.Models;
using System.Data.Entity.ModelConfiguration;

namespace Project.MAP.Options
{
    public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {

        }
    }
}
