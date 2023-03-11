namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public decimal OrderPrice { get; set; }
        public string RoomNo { get; set; }
        public int BookingID { get; set; }

        //Relational Properties
        public Booking Booking { get; set; }
    }
}
