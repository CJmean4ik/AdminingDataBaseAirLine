using DataBaseModel.Entities.TicketAndOrders;

namespace DataBaseModel.Entities.Accounts
{
    public class Cashier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
