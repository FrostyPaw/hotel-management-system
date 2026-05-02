using System;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class ReservationRequest
    {
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
