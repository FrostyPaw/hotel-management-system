using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Services
{
    public class FileDataStorage : IDataStorage
    {
        private readonly string _filePath = "guests.json";

        public void SaveGuests(List<Guest> guests)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(guests, options);
            File.WriteAllText(_filePath, jsonString);
        }

        public List<Guest> LoadGuests()
        {
            if (!File.Exists(_filePath))
                return new List<Guest>();

            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Guest>>(jsonString)
                   ?? new List<Guest>();
        }
    }
}
