namespace Models;
    public class Ticket
    {
        public string? TicketName { get; set; }
        public string? TicketDes { get; set; }

        public override string ToString()
        {
            return $"Ticket Name: {this.TicketName}\nTicket Description:{this.TicketDes}";
        } 
    }