using AirlineDataBase.DataBaseContext;
using AirlineDataBase.Entityes.TicketAndOrders;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.OrdersPanel
{
    internal class AddingOrders
    {
        public AirCompanyContext AirCompany { get; set; }
        public OrderPanelControl OrderPanelControl { get; set; }
        private bool erorIsActive;
        public AddingOrders(AirCompanyContext airCompany, OrderPanelControl orderPanelControl)
        {
            AirCompany = airCompany;
            OrderPanelControl = orderPanelControl;
        }
        public async Task LoadRelatedEnityToLocalCashAsync()
        {
            await AirCompany.Passengers.LoadAsync();
            await AirCompany.Tickets.LoadAsync();
            await AirCompany.Orders.LoadAsync();
        }
        public void EnableIdBox(bool state) => OrderPanelControl.IdpassBox.Enabled = state;
        private Orders PreperingToAddingOrders(int cashierId)
        {
            if (!ExistPassenger(out int passengerId))
            {
                HandlingEror("Такий пасажир не зареєстрований в системі");
                return null;
            }

            if (!ExistTicket(out int ticketId))
            {
                HandlingEror("Квитка з даним маршрутом не існує");
                return null;
            }

            var orders = OrderFormation(cashierId, passengerId, ticketId);

            if (!ExistOrders(orders))
            {
                HandlingEror("Дане замовлення на такого пасажира вже існує");
                return null;
            }
            return orders;
        }
        public async Task<Orders> AddOrdersAsync(int cashierId)
        {
            try
            {
                var orders = PreperingToAddingOrders(cashierId);

                if (orders == null) return null;

                AirCompany.Orders.Add(orders);
                await AirCompany.SaveChangesAsync();
                return orders;
            }
            catch (Exception ex)
            {
                HandlingEror("Не вдалося додати нове замовлення!");
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private Orders OrderFormation(int cashierId, int passengerId, int ticketId)
        {
            Orders orders = new Orders()
            {
                CashierId = cashierId,
                PassengerId = passengerId,
                TicketId = ticketId,
            };

            return orders;
        }
        private bool ExistTicket(out int ticketId)
        {
            try
            {
                var flight = AirCompany.Tickets.Local
               .Where(w =>
               w.Flight.NameRoute == OrderPanelControl.FlightNamesBox.Text &&
               w.Flight.Route.FromWhere == OrderPanelControl.FromWhereBox.Text &&
               w.Flight.Route.Where == OrderPanelControl.WhereBox.Text
               )
               .Select(s => s.NumberTicket)
               .ToList();

                if (flight.Count == 0)
                {
                    ticketId = 0;
                    return false;
                }

                ticketId = flight[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ticketId = 0;
                return false;
            }
            return true;
        }
        private bool ExistPassenger(out int idPassenger)
        {
            try
            {
                var passenger = AirCompany.Passengers.Local
                    .Where(w => w.Name == OrderPanelControl.NameBox.Text &&
                    w.Surname == OrderPanelControl.SecondNameBox.Text
                    )
                    .Select(s => s.ID)
                    .ToList();

                if (passenger.Count == 0)
                {
                    idPassenger = 0;
                    return false;

                }

                idPassenger = passenger[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                idPassenger = 0;
                return false;
            }
            return true;
        }
        private bool ExistOrders(Orders verifiableOrders)
        {
            try
            {
                var orders = AirCompany.Orders.Local
                     .Where(w =>
                     w.TicketId == verifiableOrders.TicketId &&
                     w.CashierId == verifiableOrders.CashierId &&
                     w.PassengerId == verifiableOrders.PassengerId
                     )
                     .FirstOrDefault();

                if (orders != null) return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;

        }
        public void HandlingEror(string message)
        {
            if (!erorIsActive)
            {
                OrderPanelControl.ErorLabel.Text = message;
                OrderPanelControl.ErorLabel.Visible = true;
                return;
            }
            OrderPanelControl.ErorLabel.Visible = false;
        }
    }
}
