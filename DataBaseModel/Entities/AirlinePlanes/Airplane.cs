namespace DataBaseModel.Entities.AirlinePlanes
{
    public  class Airplane
    {
        public int ID { get; set; }
        public string TypeAirplane { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<AirlinePlane> AirlinePlane { get; set; }
    }
    enum TypeAirplane
    {
        CommercialJet,
        PrivateJet
    }
}
