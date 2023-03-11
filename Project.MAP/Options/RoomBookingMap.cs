using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
    public class RoomBookingMap : BaseMap<RoomBooking>
    {
        public RoomBookingMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.RoomID,
                x.BookingID
            });
        }
    }
}
