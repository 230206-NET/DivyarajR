using System;
using System.Collections.Generic;

namespace UILayer;

public class LoginPortal
{
    private readonly string role;
    public List<UserRole> roleType = new List<UserRole>();
    public DisplayLoginPortal()
    {
        do
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Select your role type to proceed ahead: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[Login as Manager] Login to your account with manager details");
            Console.WriteLine("[Login as Employee] Login to your account with employee details");
            Console.WriteLine("[x] Log out of the session");

            string? roleType = Console.ReadLine();
            switch(roleType)
            {
                case "Login as Manager": 
                    roleType = "Manager";
                    break;
                case "Login as Employee":
                    roleType = "Employee";
                    break;
                case "x": 
                    Environment.Exit(0);
                    break;
                default: 
                    Console.WriteLine("Provide a valid input");
                    break;
            }
        }
        while(true);

        Console.WriteLine();
        Console.WriteLine("Enter your user id");
        int userID = Console.ReadLine();
        Console.WriteLine("Please enter your first name");
        string? userFirstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name");
        string? userLastName = Console.ReadLine();
        Console.WriteLine("Enter your user name");
        string? userName = Console.WriteLine();
        Console.WriteLine("Please enter your phone number");
        string? userPhoneNo = Console.WriteLine();
        Console.WriteLine("Kindly wait, verification in process");
        
        Boolean isCorrect = verifiedUser(userID, userFirstName, userLastName, userPhoneNo, role);
        if(isCorrect != false)
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("No account found in the system");
        }

    }
}