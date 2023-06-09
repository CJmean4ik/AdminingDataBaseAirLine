using AirlineDataBase.DataBaseContext;
using AirlineDataBase.Entityes.TicketAndOrders;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel
{
    internal class AddingReservedSeats
    {
        public ReservedSeatsPanelControl ReservedSeats { get; set; }
        public AirCompanyContext Context { get; set; }

        private bool erorIsActive;
        public bool IsPrepering { get; set; }
        public bool IsLoadedToLocalCash { get; set; }
        public AddingReservedSeats(ReservedSeatsPanelControl reservedSeats, AirCompanyContext context)
        {
            ReservedSeats = reservedSeats;
            Context = context;
        }
        public void EnableControls(bool isEnable)
        {
            ReservedSeats.ShowTable.Enabled = isEnable;
            ReservedSeats.UpdateButton.Enabled = isEnable;
            ReservedSeats.RemoveButton.Enabled = isEnable;
            ReservedSeats.IdpassBox.Enabled = isEnable;
            ReservedSeats.ReportCreate.Enabled = isEnable;
        }
        public async Task LoadRelatedEnityToLocalCashAsync()
        {
            await Context.Orders.LoadAsync();
            await Context.Airplanes.LoadAsync();
            await Context.Passengers.LoadAsync();
            await Context.Tickets.LoadAsync();
            await Context.Flights.LoadAsync();
            await Context.ReservedSeats.LoadAsync();
        }
        private bool ExistOrdersInPassenger(out Guid ordersId)
        {
            var ordersList = Context.Orders.Local
                .Where(w =>
                w.Passenger.Name == ReservedSeats.NameBox.Text &&
                w.Passenger.Surname == ReservedSeats.SecondNameBox.Text &&
                w.Ticket.Flight.NameRoute == ReservedSeats.FlightNamesBox.Text
                )
                .ToList();

            if (ordersList.Count == 0)
            {
                ordersId = Guid.Empty;
                return false;
            }

            ordersId = ordersList[0].ID;
            return true;

        }
        private bool ExistAirplaneInOrdersPassenger(out int airplaneId)
        {
            var ordersList = Context.Orders.Local
               .Where(w => w.Ticket.Flight.AirlinePlane.Airplane.Model == ReservedSeats.AirplaneBox.Text)
               .ToList();

            if (ordersList.Count == 0)
            {

                airplaneId = 0;
                return false;
            }

            airplaneId = ordersList[0]
                .Ticket
                .Flight
                .AirlinePlane
                .Airplane
                .ID;

            return true;
        }
        private bool ExistReservedSeats(ReservedSeats reservedSeats)
        {
            try
            {
                var ordersList = Context.ReservedSeats.Local
                 .Where(
                 w =>
                 w.AirPlaneid == reservedSeats.AirPlaneid &&
                 w.OrderId == reservedSeats.OrderId &&
                 w.BookSeats == reservedSeats.BookSeats
                )
                 .ToList();

                if (ordersList == null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private ReservedSeats PreperingToAddingReservedSeats()
        {
            if (!ExistOrdersInPassenger(out Guid ordersId))
            {
                HandlingEror("Даний пасажир не має такого замовлення");
                return null;
            }

            if (!ExistAirplaneInOrdersPassenger(out int airplaneId))
            {
                HandlingEror("Даний пасажир не летить на такому літаку");
                return null;
            }

            var reservedSeats = ReservedSeatsFormation(ordersId, ReservedSeats.SeatsNumberBox.Text, airplaneId);

            if (!ExistReservedSeats(reservedSeats))
            {
                HandlingEror("Даний пасажир не летить на такому літаку");
                return null;
            }

            return reservedSeats;

        }

        public async Task<ReservedSeats> AddReservedSeatsAsync()
        {
            try
            {
                var reservedSeats = PreperingToAddingReservedSeats();

                if (reservedSeats == null) return null;

                Context.ReservedSeats.Add(reservedSeats);
                await Context.SaveChangesAsync();
                return reservedSeats;

            }
            catch (Exception ex)
            {
                HandlingEror("Не вдалося додати бронювання місця!");
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private ReservedSeats ReservedSeatsFormation(Guid ordersId, string numberSeats, int airplaneId)
        {
            if (!int.TryParse(numberSeats, out int number))
            {
                HandlingEror("Ви ввели не числовий номер місця");
                return null;
            }

            ReservedSeats reservedSeats = new ReservedSeats()
            {
                OrderId = ordersId,
                BookSeats = number,
                AirPlaneid = airplaneId,
            };
            return reservedSeats;
        }
        public void HandlingEror(string message)
        {
            if (!erorIsActive)
            {
                ReservedSeats.ErorLabel.Text = message;
                ReservedSeats.ErorLabel.Visible = true;
                return;
            }
            ReservedSeats.ErorLabel.Visible = false;
        }
    }
}
