using System;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class Booking : BaseEntity
    {
        public byte PersonCount { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal? Price { get; set; }
        public int CustomerID { get; set; }
        public int? AppUserID { get; set; }

        public override string ToString()
        {
            return $"Kişi Sayısı : {PersonCount} Müşteri ID : {CustomerID} Giriş Tarihi : {CheckIn} Çıkış Tarihi : {CheckOut}";
        }

        //Relational Properties
        public virtual Customer Customer { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<RoomBooking> RoomBookings { get; set; }

    }
}
