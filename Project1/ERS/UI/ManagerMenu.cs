using System; 
using Services;

namespace UI; 

public class ManagerMenu{
    private Account _acct; 
    private TicketServices _ticketservice;
    
    //private readonly AcctService _aservice; 
    public ManagerMenu(TicketServices service, Account acct){
        this._ticketservice = service;
        this._acct = acct;
    }

    public void Start(){
        while(true){
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("[1] View tickets that need approval or rejected based on expenses made");   //add bold to font
            Console.WriteLine("[2] Display Employee Menu"); 
            Console.WriteLine("[3] Log out");       //or exit system
            Console.WriteLine("[x] Exit");

            string? input = Console.ReadLine();   //nullable reference

            switch(input){
                case "1":
                    viewPendingTickets();
                continue;
                case "2":
                    employeeRevision();
                continue;
                case "3":
                break;
                case "x":
                    System.Environment.Exit(0);
                break;
            }
            break;
        }
    }


    private void viewPendingTickets(){
        int i = 1; 
        if(_ticketservice.searchTicketByStatus('P') is null){
            Console.WriteLine("There are no tickets to be viewed.");
        }
        foreach(Ticket t in _ticketservice.searchTicketByStatus('P')){
                Console.WriteLine($"{i,-5}{t.ToString()}");
                Console.WriteLine(("").PadRight(50, '-'));
                i++;
                ticketApproval(t);
        }
        

    }

    private void ticketApproval(Ticket t){
        Console.WriteLine("Approve ticket? [Y/N]");
                string? acttype = Console.ReadLine();
                if(acttype is not null)
                if(acttype.ToLower()[0] == 'n'){
                    t.status = 'R';
                    t.approveBy = _acct.workId;
               } else if(acttype.ToLower()[0] == 'y'){
                    t.status = 'A';
                    t.approveBy = _acct.workId;
               } 
        _ticketservice.ticketRevision(t);
    }

    private void employeeRevision(){
        throw new NotSupportedException();
    }
}