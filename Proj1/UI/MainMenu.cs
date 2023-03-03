/*
using DataAccess;
using Services;
namespace UI;
    public class MainMenu
    {
        //private readonly TicketService _service;
        //private List<TicketSession> tic = new();
        public MainMenu() {
        //_service = service;
        }
        public void Start()
        {
            // Login Screen
            User login = new User();

            Console.WriteLine("Username: ");
            string user = Console.ReadLine();
            Console.WriteLine("Password: ");
            string pass = Console.ReadLine();

            login.UserName = user;
            login.Password = pass;

            Console.WriteLine("User : " + user);
            Console.WriteLine("Username : " + login.UserName);

            Console.WriteLine("Pass : " + pass);
            Console.WriteLine("Password : " + login.Password);

            // After Lpgin
            while(true) 
            {
                Console.WriteLine("Expense Tracker:");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[1] Create a new Ticket");
                Console.WriteLine("[2] Modify an existing Ticket");
                Console.WriteLine("[3] View all Tickets");
                Console.WriteLine("[x] Exit");

                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        // TODO: add new ticket
                        CreateNewTicket();
                    break;
                    
                    case "2":
                        // ToDo: Modify Existing Workout
                       // SearchTicketsByName();
                    break;
                    case "3":
                        // TODO: Veiw all tickets
                        List<TicketSession> sessions = new FileStorage().GetAllTicket();
                        foreach(TicketSession s in sessions) {
                            Console.WriteLine(s);
                        }
                    break;

                    case "x":
                        Environment.Exit(0);
                    break;

                    default:
                        Console.WriteLine("I don't understand your input");
                    break;
                }
            }
        }
        // private void SearchTicketsByName() 
        // {
        //     Console.WriteLine("Which Ticket would you like to serach for?");
        //     string input = Console.ReadLine();

        //     List<TicketSession> sessions = _service.SearchTicketsByName(input);

        //     foreach(TicketSession s in sessions) {
        //         Console.WriteLine(s);
        //     }
        // }
        private void CreateNewTicket()
        {
            TicketSession session = new TicketSession();
            Console.WriteLine("Creating new Ticket: ");
            Console.WriteLine("Ticket Date: ");
            string? TicketDate = Console.ReadLine();

            DateTime parsed;
            bool parseSuccess = DateTime.TryParse(TicketDate, out parsed);

            if(parseSuccess)
            {
                 session.TicketDate = parsed;
            }

            while(true) 
            {
                Console.WriteLine("Ticket Name: ");

                string nameInput = Console.ReadLine();
                try {
                    session.TicketName = nameInput;
                    break;
                }
                catch(ArgumentLengthException ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            while(true) 
            {
                Console.WriteLine("What did you do?");

                string ticketName = Console.ReadLine();

                Console.WriteLine("Any Description?");
                string ticketNotes = Console.ReadLine();

                Ticket ex = new Ticket {
                    TicketName = ticketName,
                    TicketDes = ticketNotes
                };

                session.TicketForm.Add(ex);
                Console.WriteLine("Add more? [y/n]");
                string more = Console.ReadLine();
                if(more.ToLower()[0] == 'n') break;
            }

           // _service.CreateNewSession(session);
            Console.WriteLine(session);
        }
    }
*/