using System;

namespace Hotel_Management_System_2.Models
{
    public enum PaymentStatus
    {
        Pending,
        Paid,
        Cancelled
    }

    public class Reservation
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public int RoomNumber { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public override string ToString()
        {
            return $"Reservation {ReservationID} | Room {RoomNumber} | Guest {GuestID} | {PaymentStatus}";
        }
    }
}
