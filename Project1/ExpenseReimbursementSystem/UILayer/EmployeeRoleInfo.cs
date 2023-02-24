using System;
using System.Text;

namespace UILayer;
public class EmployeeRoleInfo
{
    public EmployeeRoleInfo(userInfo user)
    {
        Console.WriteLine("New user {0} has logged in to the portal", user.userName);
        Console.WriteLine("Welcome to ERS Portal", user.userFirstName, user.userLastName);
        while(!exit)
        {
            Console.WriteLine("Select an option to be reimbursed: ");
            Console.WriteLine("[1] Create a new reimbursement ticket");
            Console.WriteLine("[2] View your previous submitted reimbursement tickets");
            Console.WriteLine("[3] Check status of your reimbursement ticket");
            Console.WriteLine("[4] Logout");
            
            bool isValid = false;
            while(!isValid)
            {
                string? choice = Console.ReadLine();
                switch(choice)
                { 
                    case "1":
                        Console.WriteLine("Create a mew reimbursement tickets");
                        isValid = true;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("View your previous submitted reimbursement tickets");
                        isValid = true;
                        break;
                    
                    case "3":
                        Console.Clear();
                        Console.WriteLine("View your previous submitted reimbursement tickets");
                        isValid = true;
                        break;
                }
            }
        }
    }
}
