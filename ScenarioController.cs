using System;
using System.Collections.Generic;
using System.Linq;
using TripAdvisor.Controller.UserController;
using TripAdvisor.Restaurant;

namespace TripAdvisor
{
    class ScenarioController
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Select scenario:");
                Console.WriteLine("1.LoginRegisterScenario 2.ProfileScenario 3.PlaceScenario 4.TicketScenario 5.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        UserScenario.loginRegisterScenarios();
                        break;
                    case 2:
                        UserScenario.profileScenarios();
                        break;
                    case 3:
                        PlaceScenario.placeScenarios();
                        break;
                    case 4:
                        TicketScenario.ticketScenarios();
                        break;
                    case 5: 
                        break;
                }
            }
        }
        
    }
}
