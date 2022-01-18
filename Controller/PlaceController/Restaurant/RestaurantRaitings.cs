namespace TripAdvisor.Restaurant
{
    public class RestaurantRaitings
    {
        private float food;
        private float service;
        private float value;
        private float atmosphere;

        public float Food => food;

        public float Service => service;

        public float Value => value;

        public float Atmosphere => atmosphere;

        public RestaurantRaitings(float food, float service, float value, float atmosphere)
        {
            setRatings(food, service, value, atmosphere);
        }
        
        public void setRatings(float food, float service, float value, float atmosphere)
        {
            this.food = food;
            this.service = service;
            this.value = value;
            this.atmosphere = atmosphere;
        }
    }
}