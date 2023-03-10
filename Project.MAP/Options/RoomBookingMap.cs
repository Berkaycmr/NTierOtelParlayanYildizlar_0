using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomBookingMap:BaseMap<RoomBooking>
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
