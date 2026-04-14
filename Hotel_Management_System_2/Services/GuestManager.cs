using System;
using System.Collections.Generic;
using System.Linq;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Services
{
    public class GuestManager
    {
        private readonly IDataStorage _dataStorage;
        private List<Guest> _guests;

        public GuestManager(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
            _guests = _dataStorage.LoadGuests();
        }


        // ADD GUEST

        public void AddGuest(Guest guest)
        {
            _guests.Add(guest);
            SaveChanges();
        }


        // DELETE GUEST

        public bool DeleteGuest(int id)
        {
            var guest = _guests.FirstOrDefault(g => g.GuestID == id);
            if (guest == null) return false;

            _guests.Remove(guest);
            SaveChanges();
            return true;
        }


        // EDIT GUEST

        public bool EditGuest(Guest updatedGuest)
        {
            var index = _guests.FindIndex(g => g.GuestID == updatedGuest.GuestID);
            if (index == -1) return false;

            _guests[index] = updatedGuest;
            SaveChanges();
            return true;
        }


        // VIEW ALL

        public List<Guest> GetAllGuests()
        {
            return _guests.ToList(); // copy of the list
        }


        // SEARCH GUEST BY KEYWORD

        public List<Guest> SearchGuests(string keyword)
        {
            keyword = keyword.ToLower();

            return _guests.Where(g =>
                g.FirstName.ToLower().Contains(keyword) ||
                g.LastName.ToLower().Contains(keyword) ||
                g.GuestID.ToString().Contains(keyword) ||
                g.RoomNumber.ToString().Contains(keyword)
            ).ToList();
        }


        // SORT GUESTS

        public List<Guest> SortByLastName()
        {
            return _guests.OrderBy(g => g.LastName).ThenBy(g => g.FirstName).ToList();
        }

        public List<Guest> SortById()
        {
            return _guests.OrderBy(g => g.GuestID).ToList();
        }

        public List<Guest> SortByRoom()
        {
            return _guests.OrderBy(g => g.RoomNumber).ToList();
        }


        // STATISTICS

        public (int totalGuests, int uniqueRooms) GetStatistics()
        {
            int totalGuests = _guests.Count;
            int uniqueRooms = _guests.Select(g => g.RoomNumber).Distinct().Count();

            return (totalGuests, uniqueRooms);
        }


        // SAVE HELPERS

        private void SaveChanges()
        {
            _dataStorage.SaveGuests(_guests);
        }
    }
}
