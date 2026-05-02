using System.Collections.Generic;
using System.Linq;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class RoomAvailabilityRule : IReservationRule
    {
        public ReservationResult Validate(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            bool overlaps = reservations.Any(r =>
                r.RoomId == request.RoomId &&
                request.CheckInDate < r.CheckOutDate &&
                request.CheckOutDate > r.CheckInDate
            );

            if (overlaps)
            {
                return ReservationResult.Fail("Room is not available for the selected dates.");
            }

            return ReservationResult.Ok("Room is available.");
        }
    }
}
