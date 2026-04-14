using System;

namespace Hotel_Management_System_2.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomNumber { get; set; }

        public override string ToString()
        {
            return $"{GuestID}: {LastName} {FirstName}, Room {RoomNumber}";
        }
    }
}
