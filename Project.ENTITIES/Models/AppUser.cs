using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        //Relational Properties

        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Booking> Bookings { get; set; }


    }
}
