using System;

namespace TripAdvisor
{
    class PlaceInfo
    {
        private string name;
        private string city;
        private string address;
        private string location;
        private string description;
        private string contactPhone;
        private double rating;
        private double price;

        public string Name => name;

        public string City => city;

        public string Address => address;

        public string Location => location;

        public string Description => description;

        public string ContactPhone => contactPhone;

        public double Rating => rating;

        public double Price => price;

        // public string getName() { return name; }
        // public string getCity() { return city; }
        // public string getAddress() { return address; }
        // public string getLocation() { return location; }
        // public string getDescription() { return description; }
        // public string getContactPhone() { return contactPhone; }
        // public float getRating() { return rating; }
        // public float getPrice() { return price; }
        
        public PlaceInfo(string name, string city, string address, string location,
            string description, string contactPhone, double rating, double price)
        {
            Console.WriteLine("---------------we are in PlaceInfo---------------");
            this.name = name;
            this.city = city;
            this.address = address;
            this.location = location;
            this.description = description;
            this.contactPhone = contactPhone;
            this.rating = rating;
            this.price = price;
        }
        
    }
}
