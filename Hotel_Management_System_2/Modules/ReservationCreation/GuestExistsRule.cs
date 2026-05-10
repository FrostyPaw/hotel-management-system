using System.Collections.Generic;
using System.Linq;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class GuestExistsRule : IReservationRule
    {
        public ReservationResult Validate(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            bool guestExists = guests.Any(g => g.GuestID == request.GuestId);

            if (!guestExists)
            {
                return ReservationResult.Fail("Guest does not exist.");
            }

            return ReservationResult.Ok("Guest exists.");
        }
    }
}
