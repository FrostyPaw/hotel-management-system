using System.Collections.Generic;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class ReservationCreationService
    {
        private readonly List<IReservationRule> _rules;

        public ReservationCreationService()
        {
            _rules = new List<IReservationRule>
            {
                new ValidDateRangeRule(),
                new GuestExistsRule(),
                new RoomExistsRule(),
                new RoomAvailabilityRule()
            };
        }

        public ReservationResult ValidateReservation(
            ReservationRequest request,
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            foreach (IReservationRule rule in _rules)
            {
                ReservationResult result = rule.Validate(request, guests, rooms, reservations);

                if (!result.Success)
                {
                    return result;
                }
            }

            return ReservationResult.Ok("Reservation can be created.");
        }
    }
}
