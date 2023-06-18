using AirlineDataBase;
using AirlineDataBase.Entityes.TicketAndOrders;

namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel.CRUD
{
    internal class UpdatingReservedSeats
    {
        private AirCompanyContext context;
        private ReservedSeatsPanelControl panelControl;

        public bool IsPrepering { get; set; }
        public bool IsActiveEror { get; set; }

        public UpdatingReservedSeats(AirCompanyContext context, ReservedSeatsPanelControl panelControl)
        {
            this.context = context;
            this.panelControl = panelControl;
        }

        public void EnabledControls(bool state)
        {
            panelControl.AddButton.Enabled = state;
            panelControl.RemoveButton.Enabled = state;
            panelControl.AirplaneBox.Enabled = state;
            panelControl.IdpassBox.Enabled = state;
            panelControl.FlightNamesBox.Enabled = state;
            panelControl.NameBox.Enabled = state;
            panelControl.SecondNameBox.Enabled = state;
            panelControl.ReportCreate.Enabled = state;
        }

        public void HandlingEror(string message)
        {
            if (!IsActiveEror)
            {
                panelControl.ErorLabel.Text = message;
                panelControl.ErorLabel.Visible = true;
                IsActiveEror = true;
                return;
            }
            panelControl.ErorLabel.Visible = false;
        }

        private bool ExistEmptySeats()
        {
            if (!int.TryParse(panelControl.SeatsNumberBox.Text, out int numberSeats))
            {
                HandlingEror("Місце має бути введине в числовому форматі!");
                return false;
            }
            return true;
        }

        private ReservedSeats PreperingToUpdateReservedSeats()
        {
            if (!ExistEmptySeats())
            {
                HandlingEror("Не виявленно такого Id");
                return null;
            }

            var reservedSeats = ReservedSeatsFormation(panelControl.SeatsNumberBox.Text);

            if (reservedSeats != null)
                return reservedSeats;

            return null;
        }

        private ReservedSeats ReservedSeatsFormation(string numberSeats)
        {
            if (!int.TryParse(numberSeats, out int number))
            {
                HandlingEror("Ви ввели не числовий номер місця");
                return null;
            }

            var reservedSeats = context.ReservedSeats
                 .Where(w => w.Order.Passenger.Name == panelControl.NameBox.Text && w.Order.Passenger.Surname == panelControl.SecondNameBox.Text)
                 .Select(s => s)
                 .FirstOrDefault();

            reservedSeats.BookSeats = int.Parse(numberSeats);

            return reservedSeats;
        }

        public async Task UpdateReservedSeatsAsync()
        {
            try
            {
                var reservedSeats = PreperingToUpdateReservedSeats();

                context.Entry(reservedSeats).Property(p => p.BookSeats).IsModified = true;

               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
