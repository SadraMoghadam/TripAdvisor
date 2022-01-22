using System;
using TripAdvisor.Controller.UserController;

namespace TripAdvisor
{
    public class UserScenario
    {
        public static UserInfo defaultUserInfo = new UserInfo(1, "sadra", "sadra_h_m@outlook.com", "scorpion", "abcd", true, 21, "here", "my picture");
        public static User defaultLoginedUser = new User(1, defaultUserInfo);
        public static void loginRegisterScenarios()
        {
            UserInfo userInfo = null;
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
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
                        Console.Write("picture(not required): ");
                        string picture = Console.ReadLine();
                        userInfo = new UserInfo(1, name, email, username, password, gender, age, address, picture);
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
        
        public static void profileScenarios()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
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
                        Console.Write("picture(not required): ");
                        string picture = Console.ReadLine();
                        UserInfo userInfo = new UserInfo(1, name, email, username, password, gender, age, address, picture);
                        defaultLoginedUser.updateUser(userInfo);
                        break;
                    case 2:
                        photosScenarios();
                        break;
                    case 3:
                        Console.WriteLine("add a trip: ");
                        Trip trip = new Trip();
                        Console.Write("title: ");
                        string title = Console.ReadLine();
                        Console.Write("description: ");
                        string description = Console.ReadLine();
                        Console.Write("location: ");
                        string location = Console.ReadLine();
                        trip.addTrip(1, title, description, location);
                        trip.showTrips(1);
                        break;
                    case 4:
                        Console.WriteLine("write a review: ");
                        WriteReview writeReview = new WriteReview();
                        Console.Write("title: ");
                        string title4 = Console.ReadLine();
                        Console.Write("description: ");
                        string description4 = Console.ReadLine();
                        Console.Write("star: ");
                        int star = int.Parse(Console.ReadLine());
                        Console.Write("place name: ");
                        string placeName = Console.ReadLine();
                        Console.Write("city: ");
                        string city = Console.ReadLine();
                        writeReview.submitReview(1, title4, description4, star, placeName, city);
                        User.Instance.showReviews(1);
                        break;
                    case 5:
                        break;
                }
                if (menu == 5)
                    break;
            }
        }

        public static void photosScenarios()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.Photos 2.TravelPhotos 3.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("1.AddPhoto 2.UpdatePhoto 3.DeletePhoto");
                        int input1 = int.Parse(Console.ReadLine());
                        Photos photos = new Photos();
                        photos.showPhoto(1);
                        if (input1 == 3)
                            photos.deletePhoto(1);
                        Console.Write("picture: ");
                        string p_picture = Console.ReadLine();
                        if(input1 == 1)
                            photos.addPhoto(1, p_picture);
                        else if(input1 == 2)
                            photos.updatePhoto(1, p_picture);
                        photos.showPhoto(1);
                        break;
                    case 2:
                        Console.WriteLine("1.AddPhoto 2.UpdatePhoto 3.DeletePhoto");
                        int input2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("1.AddPhoto 2.UpdatePhoto 3.DeletePhoto");
                        TravelPhotos travelPhotos = new TravelPhotos();
                        travelPhotos.showPhoto(1);
                        if (input2 == 3)
                            travelPhotos.deletePhoto(1, 1);
                        Console.Write("picture: ");
                        string picture = Console.ReadLine();
                        Console.Write("city: ");
                        string city = Console.ReadLine();
                        Console.Write("description: ");
                        string description = Console.ReadLine();
                        if(input2 == 1)
                            travelPhotos.addPhoto(1, picture, city, description);
                        else if(input2 == 2)
                            travelPhotos.updatePhoto(1, picture, 1, city, description);
                        travelPhotos.showPhoto(1);
                        break;
                    case 3:
                        break;
                }
                if (menu == 3)
                    break;
            }
        }
    }
}