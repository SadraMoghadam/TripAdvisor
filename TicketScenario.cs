using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class TicketScenario
    {
        
        public static void ticketScenarios()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.Flights 2.Cruises 3.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        FlightScenarios();
                        break;
                    case 2:
                        CruiseScenarios();
                        break;
                    case 3:
                        break;
                }
                if (menu == 3)
                    break;
            }
        }

        public static void FlightScenarios()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.One-Way 2.Round-Trip 3.Multi-City 4.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        OneWayScenarios();
                        break;
                    case 2:
                        RoundTripScenario();
                        break;
                    case 3:
                        MultiCityScenarios();
                        break;
                }
                if (menu == 4)
                    break;
            }
        }

        public static void MultiCityScenarios()
        {
            Console.WriteLine("From: ");
            string city1 = Console.ReadLine();
            Console.WriteLine("To: ");
            string city2 = Console.ReadLine();
            Console.WriteLine("Departure date: ");
            Console.Write("Enter a month: ");
            int monthIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int dayIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int yearIn = int.Parse(Console.ReadLine());
            DateTime parsedDate = new DateTime(yearIn, monthIn, dayIn);
            Console.WriteLine("Travelers: ");
            Console.WriteLine("number of passengers: ");
            int pas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("SelectType: E - PE - BC - FC");
            string ty1 = Console.ReadLine();
            TravelersType ttype = TravelersType.Economy;
            if (ty1 == "E")
            {
                ttype = TravelersType.Economy;
            }
            else if (ty1 == "PE")
            {
                ttype = TravelersType.PremuimEconomy;
            }
            else if (ty1 == "BC")
            {
                ttype = TravelersType.BusinessClass;
            }
            else if (ty1 == "FC")
            {
                ttype = TravelersType.FirstClass;
            };
            List<TravelersType> tr = new List<TravelersType>();
            tr.Add(ttype);
            Travelers t1 = new Travelers(tr, pas1);
            MultiCitySearchFields m1 = new MultiCitySearchFields(1, city1, city2, parsedDate, t1);
            int call = 0;
            while (call == 1 || call ==2 || call == 0)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.Add 2.Remove 3.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        m1.addAnotherFlight();
                        call = 1;
                        break;
                    case 2:
                        m1.deleteAnotherFlight();
                        call = 2;
                        break;
                }

                if (menu == 3)
                {
                    call = 3;
                    break;
                }

            }
            FlightSearch fs1 = new FlightSearch(m1);
            FlightInfo f1 = new FlightInfo(123, null, "Tehran", "Mashhad");
            List<FlightInfo> lf = new List<FlightInfo>();
            fs1.search(m1);
            f1.showFlightInfo();
            lf.Add(f1);
            Flight flight = new Flight(lf);
            flight.showFlights(lf);
        }

        public static void RoundTripScenario()
        {
            Console.WriteLine("From: ");
            string city1 = Console.ReadLine();
            Console.WriteLine("To: ");
            string city2 = Console.ReadLine();
            Console.WriteLine("Departure date: ");
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime parsedDate = new DateTime(year, month, day);
            Console.WriteLine("Return date: ");
            Console.Write("Enter a month: ");
            int monthIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int dayIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int yearIn = int.Parse(Console.ReadLine());
            DateTime parsedDate2 = new DateTime(yearIn, monthIn, dayIn);
            Console.WriteLine("Travelers: ");
            Console.WriteLine("number of passengers: ");
            int pas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("SelectType: E - PE - BC - FC");
            string ty1 = Console.ReadLine();
            TravelersType ttype = TravelersType.Economy;
            if (ty1 == "E")
            {
                ttype = TravelersType.Economy;
            }
            else if (ty1 == "PE")
            {
                ttype = TravelersType.PremuimEconomy;
            }
            else if (ty1 == "BC")
            {
                ttype = TravelersType.BusinessClass;
            }
            else if (ty1 == "FC")
            {
                ttype = TravelersType.FirstClass;
            };
            List<TravelersType> tr = new List<TravelersType>();
            tr.Add(ttype);
            Travelers t1 = new Travelers(tr, pas1);
            RoundWaySearchFields r1 = new RoundWaySearchFields(city1, city2, parsedDate, parsedDate2, t1);
            FlightSearch fs1 = new FlightSearch(r1);
            Airline a1 = new Airline("IranAir", "12:30", "13:10", "MehrAbad");
            Airline a2 = new Airline("QeshmAir", "11:30", "14:10", "ShahidMadani");
            //Airline a3 = new Airline("MahanAir", "10:30", "16:10", "ImamKhomeini");
            List<Airline> airlines1 = new List<Airline>();
            airlines1.Add(a1);
            airlines1.Add(a2);
            FlightInfo f1 = new FlightInfo(240, airlines1, "Tehran", "Tabriz");
            List<FlightInfo> lf = new List<FlightInfo>();
            if((r1.FromCity == f1.FromCity && r1.Destination == f1.Destination)||(r1.Destination == f1.FromCity && r1.FromCity==f1.Destination))
                fs1.search(r1);
                f1.showFlightInfo();
                lf.Add(f1);
                Flight flight = new Flight(lf);
                flight.showFlights(lf);
        }

        public static void OneWayScenarios()
        {
            Console.WriteLine("From: ");
            string city1 = Console.ReadLine();
            Console.WriteLine("To: ");
            string city2 = Console.ReadLine();
            Console.WriteLine("Departure date: ");
            Console.Write("Enter a month: ");
            int monthIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int dayIn = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int yearIn = int.Parse(Console.ReadLine());
            DateTime parsedDate = new DateTime(yearIn, monthIn, dayIn);
            Console.WriteLine("Travelers: ");
            Console.WriteLine("number of passengers: ");
            int pas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("SelectType: E - PE - BC - FC");
            string ty1 = Console.ReadLine();
            TravelersType ttype = TravelersType.Economy;
            if (ty1 == "E")
            {
                ttype = TravelersType.Economy;
            }
            else if (ty1 == "PE")
            {
                ttype = TravelersType.PremuimEconomy;
            }
            else if (ty1 == "BC")
            {
                ttype = TravelersType.BusinessClass;
            }
            else if (ty1 == "FC")
            {
                ttype = TravelersType.FirstClass;
            };
            List<TravelersType> tr = new List<TravelersType>();
            tr.Add(ttype);
            Travelers t1 = new Travelers(tr, pas1);
            OneWaySearchFields o1 = new OneWaySearchFields(city1, city2, parsedDate, t1);
            FlightSearch fs1 = new FlightSearch(o1);
            //CruiseInfo ci = new CruiseInfo(3,125,"Iran", "Anzali", "Jan");
            //ci.showCruiseInfo();
            Airline a1 = new Airline("IranAir", "12:30", "13:10", "MehrAbad");
            //Airline a2 = new Airline("QeshmAir", "11:30", "14:10", "ShahidMadani");
            //Airline a3 = new Airline("MahanAir", "10:30", "16:10", "ImamKhomeini");
            List<Airline> airlines1 = new List<Airline>();
            airlines1.Add(a1);
            //airlines1.Add(a2);
            FlightInfo f1 = new FlightInfo(123, airlines1, "Tehran", "Mashhad");
            List<FlightInfo> lf = new List<FlightInfo>();
            if (o1.FromCity == f1.FromCity && o1.Destination == f1.Destination)
            {
                fs1.search(o1);
                f1.showFlightInfo();
                lf.Add(f1);
                Flight flight = new Flight(lf);
                flight.showFlights(lf);
            }

        }

        public static void CruiseScenarios()
        {
            Console.WriteLine("Country: ");
            string country1 = Console.ReadLine();
            Console.WriteLine("DepartureMonth: ");
            string dm = Console.ReadLine();
            CruiseSearchFields crsf = new CruiseSearchFields(Country.Bahamas, DepartureMonth.Jan);
            CruiseInfo ci = new CruiseInfo(3,125,"Bahamas", "Nassau", "Jan");
            ci.showCruiseInfo();
            List<CruiseInfo> cc = new List<CruiseInfo>();
            cc.Add(ci);
            Cruise cruise = new Cruise(cc);
            cruise.showCruises();
            
        }
    }
}