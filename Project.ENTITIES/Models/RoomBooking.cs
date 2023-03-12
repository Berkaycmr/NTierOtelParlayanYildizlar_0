using System;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class RoomBooking : BaseEntity
    {
        public int RoomID { get; set; }
        public int BookingID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
