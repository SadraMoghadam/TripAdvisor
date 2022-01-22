using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class CruiseInfo
    {
        private int nights;
        private float price;
        private string country;
        private string departs;
        private string sailingDates;

        public int Nights => nights;

        public float Price => price;

        public string Country => country;

        public string Departs => departs;

        public string Depart => depart;


        public CruiseInfo(int nights, float price, string country, string departs, string sailingDates)
        {
            this.nights = nights;
            this.price = price;
            this.country = country;
            this.departs = departs;
            this.sailingDates = sailingDates;
        }


        public void showCruiseInfo()
        {
            Console.WriteLine("showing cruiseInfo");
        }

    }
}