namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public decimal OrderPrice { get; set; }
        public string RoomNo { get; set; }
        public int? BookingID { get; set; }

        public override string ToString()
        {
            return $"Ürün : {Description} - Fiyatı : {OrderPrice:C2}";
        }

        //Relational Properties
        public virtual Booking Booking { get; set; }
    }
}
