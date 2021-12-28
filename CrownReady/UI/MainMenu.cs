using Models;
// using DL;
using BL;

namespace UI;

using System.Collections.Generic; //this is temp storage for models: User, Storefront

// create a public class called 'MainMenu'
public class MainMenu {

    private CRBL _bl;

    public MainMenu()
    {
        _bl = new CRBL();
    }



    // create method inside class to hold code from Program.cs file
    public void Start() {

        Console.Out.NewLine = "\r\n\r\n"; //For more info check out link: https://www.sitereq.com/post/6-ways-to-insert-new-line-in-c-and-aspnet
        Console.ForegroundColor = ConsoleColor.Cyan;
        bool exit = false;

        // Testing for various Storefront locations:
        StoreFront locationOne = new StoreFront();
        // locationOne.Name = "CrownReady - Pearland";
        locationOne.SetName("CrownReady - Pearland");
        // locationOne.Address = "random address";
        locationOne.SetAddress("random address");
        // locationOne.City = "Pearland";
        locationOne.SetCity("Pearland");
        // locationOne.State = "TX";
        locationOne.SetState("TX");

        StoreFront locationTwo = new StoreFront();
        // locationTwo.Name = "CrownReady - Sugar Land";
        locationTwo.SetName("CrownReady - Sugar Land");
        // locationTwo.Address = "random address";
        locationTwo.SetAddress("random address");
        // locationTwo.City = "Sugar Land";
        locationTwo.SetCity("Sugar Land");
        // locationTwo.State = "TX";
        locationTwo.SetState("TX");

        StoreFront locationThree = new StoreFront();
        // locationThree.Name = "CrownReady - Houston";
        locationThree.SetName("CrownReady - Houston");
        // locationThree.Address = "random address";
        locationThree.SetAddress("random address");
        // locationThree.City = "Houston";
        locationThree.SetCity("Houston");
        // locationThree.State = "TX";
        locationThree.SetState("TX");

        // initialize list of storefront locations
        List<StoreFront> allLocations = new List<StoreFront>();
        allLocations.Add(locationOne);
        allLocations.Add(locationTwo);
        allLocations.Add(locationThree);

        // Testing for various users:
        User userOne = new User();
        userOne.Name = "Joy";
        userOne.Email = "joy@email.com";
        User userTwo = new User();
        userTwo.Name = "Test";
        userTwo.Email = "test@email.com";

        List<User> allUsers = new List<User>();
        allUsers.Add(userOne);
        allUsers.Add(userTwo);
        
        // the function below is for greeting the user and asking them to either
        // login or sign up
        // User menu = new User();
        // menu.Greeting();

        bool close = false;

        do
        {

        // Optional: Strongly considering having 'readline' be a standout color from 'writeline'
        Console.WriteLine("Hello, Welcome to CrownReady Beauty Supply!");
        Console.WriteLine("The place where you find ... no matter your skin type or hair texture");
        Console.WriteLine("Let's get started!");
        Console.WriteLine("[1] Login");
        Console.WriteLine("[2] Create Account");

        string response = Console.ReadLine();

        switch(response)
            {
                // If user input == Login, ask for user.email
                case "1":
                Console.WriteLine("Email:");
                string input = Console.ReadLine();
                
                foreach (User user in allUsers)
                {

                if (user.Email.Contains(input))
                {
                    Console.WriteLine($"Welcome back {user.Name}! You've successfully logged in!");
                    close = true;
                }
                else
                {
                    Console.WriteLine("Try Again.");
                    // this runs twice for some strange reason.
                }
                
                }

                break;

                // If user input == Create an account, ask for user.name and user.email
                case "2":
                // looking to create
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                User newUser = new User {
                    Name = name,
                    Email = email
                };
                // then add new user to list
                allUsers.Add(newUser);
                Console.WriteLine($"Congrats {name}! You successfully signed up!");
                close = true;
                // also make sure the user's account don't already exist
                break;
                
                default:
                // else, ask user to "Try again" and loop back to main menu
                Console.WriteLine("Sorry, Try again");
                break;
            }
            
        } while (!close);
        // Once the user successfully either creates an account or login, 
        // they'll proceed to the main menu

        do
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("So what would you like to do today?");
            Console.WriteLine("[1] Find locations");
            Console.WriteLine("[2] View products");
            Console.WriteLine("[3] View cart");
            Console.WriteLine("[x] Logout"); //Optional: have text be shown in red
            // Things to consider:
            // 1. If you choose to view products, 
            // 1. If you choose to find locations, the user can set location as store
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("All locations");

                    // code below for displaying each StoreFront location
                    foreach(StoreFront storeFrontDetail in allLocations)
                    // foreach({c# filename} {empty constructor } in {list name})
                    {
                        Console.WriteLine(storeFrontDetail.DisplayStoreFront());
                    }
                // create an option to return to the main menu
                break;
                case "2":
                    Console.WriteLine("View products");
                break;
                case "3":
                    Console.WriteLine("View cart");
                break;
                case "x":
                    Console.WriteLine("Goodbye!");
                    exit = true;
                break;
                default:
                    Console.WriteLine("Sorry about that but I don't understand");
                break;
            }
        } while(!exit);

    }

}