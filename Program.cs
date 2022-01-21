using System;
using System.Collections.Generic;
using System.Linq;

namespace TripAdvisor
{
    class Program
    {
        static UserInfo defaultUserInfo = new UserInfo(1, "sadra", "sadra_h_m@outlook.com", "scorpion", "abcd", true, 21, "here");
        static User defaultLoginedUser = new User(1, defaultUserInfo);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select scenario:");
                Console.WriteLine("1.senarioLoginRegister 2.senarioProfile 3.senarioPlace 4.SearchTicket 5.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        senarioLoginRegister();
                        break;
                    case 2:
                        senarioProfile();
                        break;
                    case 3:
                        senarioPlace();
                        break;
                    case 4:
                        SearchTicket();
                        break;
                    case 5: 
                        break;
                }
            }

            
            // PlaceInfo pi = new PlaceInfo("a", "b", "c", "d", "e", "f", 1, 2);
            // List<TravelerType> travelerTypes= new List<TravelerType>();
            // travelerTypes.Add(TravelerType.Couples);
            // travelerTypes.Add(TravelerType.Families);
            // List<Comment> comments = new List<Comment>();
            // Comment comment = new Comment("ali", DateTime.Now, "paris", "its awsome", 4.5);
            // comments.Add(comment);
            // List<Review> reviews = new List<Review>();
            // Review review = new Review(null, null, travelerTypes, comments, "English");
            // reviews.Add(review);
            // Place p = new Place(1, pi, reviews, null);
            //
            //
            // Console.WriteLine(pi.Name);
            // Console.WriteLine(p.PlaceInfo.Name);
            //
            //
            // Console.WriteLine(p.Reviews.First().getComments());
        }

        public static void senarioLoginRegister()
        {
            UserInfo userInfo = null;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Login 2.Register 3.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        User user = new User(1, defaultUserInfo);
                        Console.Write("username: ");
                        string userName = Console.ReadLine();
                        Console.Write("password: ");
                        string pass = Console.ReadLine();
                        user.logIn(userName, pass);
                        defaultLoginedUser = user;
                        break;
                    case 2:
                        Console.Write("name: ");
                        string name = Console.ReadLine();
                        Console.Write("email: ");
                        string email = Console.ReadLine();
                        Console.Write("username: ");
                        string username = Console.ReadLine();
                        Console.Write("password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("gender(not required): 1.Male 2.Female");
                        int gender_num = int.Parse(Console.ReadLine());
                        bool gender;
                        if (gender_num == 1)
                            gender = true;
                        else
                            gender = false;
                        Console.Write("age(not required): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("address(not required): ");
                        string address = Console.ReadLine();
                        userInfo = new UserInfo(1, name, email, username, password, gender, age, address);
                        User reg_user = new User(1, userInfo);
                        reg_user.register();
                        break;
                    case 3:
                        break;
                }
                if(menu == 1 || menu == 3)
                    break;
            }
        }
        
        public static void senarioProfile()
        {
            while (true)
            {
                Console.WriteLine("Choose a page from your profile");
                Console.WriteLine("1.EditProfile 2.Photos 3.Trip 4.WriteReview 5.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("name: ");
                        string name = Console.ReadLine();
                        Console.Write("email: ");
                        string email = Console.ReadLine();
                        Console.Write("username: ");
                        string username = Console.ReadLine();
                        Console.Write("password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("gender(not required): 1.Male 2.Female");
                        int gender_num = int.Parse(Console.ReadLine());
                        bool gender;
                        if (gender_num == 1)
                            gender = true;
                        else
                            gender = false;
                        Console.Write("age(not required): ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("address(not required): ");
                        string address = Console.ReadLine();
                        UserInfo userInfo = new UserInfo(1, name, email, username, password, gender, age, address);
                        defaultLoginedUser.updateUser(userInfo);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

                if (menu == 5)
                    break;
            }
        }
        
        public static void senarioPlace()
        {
            Console.WriteLine("3");
        }
        
        public static void SearchTicket()
        {
            Console.WriteLine("4");
        }
        
    }
}
