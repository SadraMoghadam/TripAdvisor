namespace TripAdvisor.Restaurant
{
    public class RestaurantSearchFields
    {
        private string name;
        private string city;
        private string nation;

        public string Name => name;

        public string City => city;

        public string Nation => nation;

        public RestaurantSearchFields(string name, string city, string nation)
        {
            setFields(name, city, nation);
        }
        
        public void setFields(string name, string city, string nation)
        {
            this.name = name;
            this.city = city;
            this.nation = nation;
        }
    }
}