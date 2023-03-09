namespace DataBaseModel.Entities.AirlinePlanes
{
    public class Airline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

        public List<AirlinePlane> AirlinePlanes { get; set; }
    }
}
