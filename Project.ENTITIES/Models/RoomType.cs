using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class RoomType : BaseEntity
    {
        public string TypeName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public List<Room> Rooms { get; set; }
    }
}
