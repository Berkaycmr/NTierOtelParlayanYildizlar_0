using System;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class Booking : BaseEntity
    {
        public byte Person_Count { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }
        public int AppUserID { get; set; }


        //Relational Properties
        public Customer Customer { get; set; }
        public AppUser AppUser { get; set; }
        public List<Order> Orders { get; set; }
        public List<RoomBooking> RoomBookings { get; set; }

    }
}
