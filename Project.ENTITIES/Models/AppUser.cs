using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        //Relational Properties

        public AppUserProfile Profile { get; set; }
        public List<Booking> Bookings { get; set; }


    }
}
