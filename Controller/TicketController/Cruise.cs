using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Cruise
    {
        private List<CruiseInfo> cruises;

        public Cruise(List<CruiseInfo> cruises)
        {
            this.cruises = cruises;
        }

        public void showCruises()
        {
            Console.WriteLine("showing list of cruises");
            return null;
        }
    }
}