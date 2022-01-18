namespace TripAdvisor
{
    public class HotelRatings
    {
        private float location;
        private float cleanliness;
        private float service;
        private float value;

        public float Location => location;

        public float Cleanliness => cleanliness;

        public float Service => service;

        public float Value => value;

        public HotelRatings(float location, float cleanliness, float service, float value)
        {
            this.location = location;
            this.cleanliness = cleanliness;
            this.service = service;
            this.value = value;
        }

        public void editRatings(float location, float cleanliness, float service, float value)
        {
            this.location = location;
            this.cleanliness = cleanliness;
            this.service = service;
            this.value = value;
        }
    }
}