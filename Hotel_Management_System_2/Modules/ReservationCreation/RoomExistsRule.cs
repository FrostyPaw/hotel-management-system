using System.Collections.Generic;
using System.Linq;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class RoomExistsRule : IReservationRule
    {
        public ReservationResult Validate(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            bool roomExists = rooms.Any(r => r.Id == request.RoomId);

            if (!roomExists)
            {
                return ReservationResult.Fail("Room does not exist.");
            }

            return ReservationResult.Ok("Room exists.");
        }
    }
}
