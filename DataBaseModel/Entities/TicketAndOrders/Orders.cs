
using DataBaseModel.Entities.Accounts;

namespace DataBaseModel.Entities.TicketAndOrders
{
    public class Orders
    {
        public Guid ID { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int TicketId { get; set; }
        public Ticket  Ticket { get; set; }

        public int CashierId { get; set; }
        public Cashier Cashier { get; set; }
    }
}
