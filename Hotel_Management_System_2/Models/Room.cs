using System;

namespace Hotel_Management_System_2.Models
{
    public enum RoomType
    {
        Single,
        Double,
        Suite
    }

    public enum RoomStatus
    {
        Available,
        Occupied,
        Maintenance
    }

    public class Room
    {
        public int RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }

        public override string ToString()
        {
            return $"Room {RoomNumber} ({Type}) - {Status}";
        }
    }
}
