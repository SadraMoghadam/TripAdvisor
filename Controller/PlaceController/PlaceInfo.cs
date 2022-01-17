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
        private float rating;
        private float price;
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Location
        {
            get => location;
            set => location = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string ContactPhone
        {
            get => contactPhone;
            set => contactPhone = value;
        }

        public float Rating
        {
            get => rating;
            set => rating = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }
        
        // public string getName() { return name; }
        // public string getCity() { return city; }
        // public string getAddress() { return address; }
        // public string getLocation() { return location; }
        // public string getDescription() { return description; }
        // public string getContactPhone() { return contactPhone; }
        // public float getRating() { return rating; }
        // public float getPrice() { return price; }
        
        public PlaceInfo(string name, string city, string address, string location,
            string description, string contactPhone, float rating, float price)
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
