

using DataBaseModel.Entities.AirlinePlanes;
using DataBaseModel.Entities.TicketAndOrders;

namespace DataBaseModel.Entities.RouteAndFlight
{
    public class Flight
    {
        public int NumberFlight { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int AirlinePlaneId { get; set; }
        public AirlinePlane AirlinePlane { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
