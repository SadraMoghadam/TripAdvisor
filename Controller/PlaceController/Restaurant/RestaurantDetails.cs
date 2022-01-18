using System.Collections.Generic;

namespace TripAdvisor.Restaurant
{
    public class RestaurantDetails
    {
        private List<string> cuisines;
        private List<string> specialDiets;
        private List<string> meals;
        private List<string> features;

        public List<string> Cuisines => cuisines;

        public List<string> SpecialDiets => specialDiets;

        public List<string> Meals => meals;

        public List<string> Features => features;

        public RestaurantDetails(List<string> cuisines, List<string> specialDiets, List<string> meals, List<string> features)
        {
            setDetails(cuisines, specialDiets, meals, features);
        }
        public void setDetails(List<string> cuisines, List<string> specialDiets, List<string> meals, List<string> features)
        {
            this.cuisines = cuisines;
            this.specialDiets = specialDiets;
            this.meals = meals;
            this.features = features;
        }
    }
}