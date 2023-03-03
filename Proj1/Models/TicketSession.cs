using Models.CustomException;
using System.Text;
using Serilog;
namespace Models;
    public class TicketSession
    {
        public TicketSession()
        {
            TicketForm = new List<Ticket>();
        }

        public DateTime TicketDate { get; set; } = DateTime.Now;
        private string _ticketName = DateTime.Now.ToString();
        public string TicketName 
        {
            get{
                return _ticketName;
            }
            set{
                if(value.Length >= 100){
                    Log.Warning("Models: assigning name to new ticket session: name length too long");
                    throw new ArgumentLengthException("Name must be less than 100 characters");
                }
                if(!string.IsNullOrWhiteSpace(value)){
                    _ticketName = value;
                }
            }
        }
        public List<Ticket> TicketForm { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            
            sb.Append($"Name: {this.TicketName}\nDate: {this.TicketDate}");

            foreach(Ticket e in TicketForm) {
                sb.Append("\n");
                sb.Append(e.ToString());
            }

            return sb.ToString();
        }
    }