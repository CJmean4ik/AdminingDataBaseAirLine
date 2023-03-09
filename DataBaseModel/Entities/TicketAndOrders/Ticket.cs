using DataBaseModel.Entities.RouteAndFlight;

namespace DataBaseModel.Entities.TicketAndOrders
{
    public class Ticket
    {
        public int NumberTicket { get; set; }
        public decimal Price { get; set; }
        public DateTime DataSales { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
