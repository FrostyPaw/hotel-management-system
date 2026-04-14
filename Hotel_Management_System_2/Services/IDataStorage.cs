using System;

using System.Collections.Generic;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Services
{
    public interface IDataStorage
    {
        void SaveGuests(List<Guest> guests);
        List<Guest> LoadGuests();
    }
}
