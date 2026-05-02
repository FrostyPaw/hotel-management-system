using System.Collections.Generic;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class ValidDateRangeRule : IReservationRule
    {
        public ReservationResult Validate(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            if (request.CheckOutDate <= request.CheckInDate)
            {
                return ReservationResult.Fail("Check-out date must be after check-in date.");
            }

            return ReservationResult.Ok("Date range is valid.");
        }
    }
}
