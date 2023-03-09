using DataBaseModel.Entities.RouteAndFlight;

namespace DataBaseModel.Entities.AirlinePlanes
{
    public class AirlinePlane
    {
        public int ID { get; set; }
        public string SendingAirline { get; set; }
        public int AirLineId { get; set; }
        public Airline AirLine { get; set; }


        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public bool InRaise { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
