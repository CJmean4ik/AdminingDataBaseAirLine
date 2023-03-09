

namespace DataBaseModel.Entities.RouteAndFlight
{
    public class Route
    {
        public int ID { get; set; }
        public string FromWhere { get; set; }
        public string Where { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Incoming { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
