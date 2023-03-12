using Project.ENTITIES.Enums;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public byte Capacity { get; set; }
        public decimal RoomPrice { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public bool CleanStatus { get; set; }
        public int RoomTypeID { get; set; }
        public int HouseKeepingID { get; set; }

        public override string ToString()
        {
            return $"ODA NO: {RoomNumber} DOLULUK: {RoomStatus} TEMİZLİK : {CleanStatus} FİYATI : {RoomPrice} KAPASİTE : {Capacity}";
        }

        //Relational Properties

        public virtual RoomType RoomType { get; set; }
        public virtual HouseKeeping HouseKeeping { get; set; }
        public virtual List<RoomBooking> RoomBookings { get; set; }

    }
}
