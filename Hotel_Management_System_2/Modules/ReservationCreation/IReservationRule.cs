using System.Collections.Generic;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public interface IReservationRule
    {
        ReservationResult Validate(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations);
    }
}
