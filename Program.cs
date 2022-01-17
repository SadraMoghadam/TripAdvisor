using System;

namespace TripAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PlaceInfo pi = new PlaceInfo("a", "b", "c", "d", "e", "f", 1, 2);
            
            Place p = new Place(pi, null, null);

            
            Console.WriteLine(pi.Name);
            Console.WriteLine(p.PlaceInfo.Name);
            
        }
    }
}
