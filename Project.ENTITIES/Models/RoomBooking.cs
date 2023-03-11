namespace Project.ENTITIES.Models
{
    public class RoomBooking : BaseEntity
    {
        public int RoomID { get; set; }
        public int BookingID { get; set; }

        //Relational Properties
        public Room Room { get; set; }
        public Booking Booking { get; set; }
    }
}
