using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Services
{
    public class ReservationManager
    {
        private readonly string _filePath = "reservations.json";
        private List<Reservation> _reservations;

        public ReservationManager()
        {
            _reservations = LoadFromFile();
        }

        private List<Reservation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Reservation>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Reservation>>(json) ?? new List<Reservation>();
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(_reservations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
            SaveToFile();
        }

        public bool DeleteReservation(int id)
        {
            var reservation = _reservations.FirstOrDefault(r => r.ReservationID == id);
            if (reservation == null) return false;

            _reservations.Remove(reservation);
            SaveToFile();
            return true;
        }

        public bool EditReservation(Reservation updated)
        {
            var reservation = _reservations.FirstOrDefault(r => r.ReservationID == updated.ReservationID);
            if (reservation == null) return false;

            reservation.GuestID = updated.GuestID;
            reservation.RoomNumber = updated.RoomNumber;
            reservation.CheckInDate = updated.CheckInDate;
            reservation.CheckOutDate = updated.CheckOutDate;
            reservation.PaymentStatus = updated.PaymentStatus;

            SaveToFile();
            return true;
        }


        public List<Reservation> SearchReservations(string keyword)
        {
            keyword = keyword.ToLower();

            return _reservations.Where(r =>
                r.ReservationID.ToString().Contains(keyword) ||
                r.GuestID.ToString().Contains(keyword) ||
                r.RoomNumber.ToString().Contains(keyword))
                .ToList();
        }
    }
}
