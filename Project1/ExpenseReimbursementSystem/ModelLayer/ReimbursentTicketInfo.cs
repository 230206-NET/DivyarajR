namespace ModelLayer;

public class ReimbursementTicketInfo
{
    public int ticketID {get; set;}
    public decimal ticketAmount {get; set;}
    public string ticketIssuedDate {get; set;}
    public string ticketDescription {get; set;}
    public string ticketStatus {get; set;}

    public ReimbursementTicketInfo(int ticketID, decimal ticketAmount, string ticketIssuedDate, string ticketDescription, string ticketStatus)
    {
        this.ticketID = ticketID;
        this.ticketAmount = ticketAmount;
        this.ticketIssuedDate = ticketIssuedDate;
        this.ticketDescription = ticketDescription;
        this.ticketStatus = ticketStatus;
    }

    public enum statusUpdate{
        Pending, Approved, Rejected
    }

    //override method
    public string ToString()
    {
        string inputString = string.Format("\ntickerID: {0} \nticketAmount: {0} \nticketIssuedDate: {0} \nticketDescription: {0} \nticketStatus: {0}", ticketID, ticketAmount, ticketIssuedDate, ticketDescription, ticketStatus);
        return inputString;
    }
}
