using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public byte Capacity { get; set; }
        public decimal RoomPrice { get; set; }
        public bool RoomStatus { get; set; }
        public int RoomTypeID { get; set; }
        public int HouseKeepingID { get; set; }

        //Relational Properties

        public RoomType  RoomType { get; set; }
        public HouseKeeping HouseKeeping { get; set; }
        public List<RoomBooking> RoomBookings { get; set; }

    }
}
