using System;

namespace Colonize.Website.Data.Entities
{
    public class Ship
    {
        public Ship()
        {

        }

        public Ship(string name, string description, ushort passengerCapacity, Uri imageUrl)
        {
            Name = name;
            Description = description;
            PassengerCapacity = passengerCapacity;
            ImageUrl = imageUrl;
        }

        public Ship(int id, string name, string description, ushort passengerCapacity, Uri imageUrl)
            : this(name, description, passengerCapacity, imageUrl)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort PassengerCapacity { get; set; }
        public Uri ImageUrl { get; set; }
    }
}