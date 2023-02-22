namespace UI;

public class MainMenu
{
    public void ApplicationPage()
    {
        do
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Welcome to Expense Reimbursement System Portal!!");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Select an option to continue");
            Console.WriteLine("[1] Existing User? Login to the portal");
            Console.WriteLine("[2] New Registration? Register with your details");
            Console.WriteLine("[1] Exit Session");
            string? userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1": //Login Page for Existing User
                        Console.WriteLine("Enter your username (must be 4-10 characters): ");
                        string? userName = Console.ReadLine();
                        Console.WriteLine("Enter your password (must be alphanumeric combination): ");
                        string? userPassword = Console.ReadLine();
                        Console.WriteLine("Welcome to the portal, "+userName+".");
                        break;

                case "2": //If new user then create a registration 
                        Console.WriteLine("Enter your first name: ");
                        string? userFirstName = Console.ReadLine();
                        Console.WriteLine("Enter your last name: ");
                        string? userLastName = Console.ReadLine();
                        Console.WriteLine("Create username: ");
                        string? username = Console.ReadLine();
                        Console.WriteLine("Create password: ");
                        string? userpassword = Console.ReadLine();
                        Console.WriteLine("What's your role?");
                        Console.WriteLine("[1] Select 1 for Employee: ");
                        Console.WriteLine("[2] Select 2 for Manager");

                        string? roleType = Console.ReadLine();
                        switch(roleType)
                        {
                            case "1" : 
                                roleType = "Employee";
                                break;

                            case "2" : 
                                roleType = "Manager";
                                break;
                            default : 
                                Console.WriteLine("Selece a valid role type");
                                break;      
                        }
                    break;
                case "3": Console.WriteLine();
                          break;
                
            }
        }
        while(true);
    }
}
