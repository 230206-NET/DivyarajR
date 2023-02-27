using Models; 

namespace DataAccess; 
public interface IRepo{
    
    /// <summary>
    /// Retrieves all ticket submissions done by employee
    /// </summary>
    /// <returns>a list of ticket submissions</returns>
    List<Ticket> GetAllTicketSubmissions(int id);

     /// <summary>
    /// Retrieves all ticket submissions 
    /// </summary>
    /// <returns>a list of ticket submissions</returns>
    List<Ticket> GetAllTickets();

    bool updateTickets(Ticket updatedTicket);

    /// <summary>
    /// Retrieves all accounts
    /// </summary>
    /// <returns>a list of accounts</returns>
    List<Account> GetAllAccounts();

    /// <summary>
    /// Persists a new ticket to storage
    /// </summary>
    bool SubmitTicket(Ticket ticketToSubmit);

    void createNewAccount(Account accountToCreate);

    Account checkExistingAccount(int id, string? pwd);
}