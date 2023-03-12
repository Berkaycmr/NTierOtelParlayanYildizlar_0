using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class HouseKeeping : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual List<Room> Rooms { get; set; }

    }
}
