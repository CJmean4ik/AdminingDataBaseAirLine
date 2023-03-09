using DataBaseModel.Entities.TicketAndOrders;

namespace DataBaseModel.Entities.Accounts
{
    public class Passenger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Orders> Orders { get; set; }

    }
    public enum GenderType
    {
        Male,
        Female
    }
}
