using AirlineDataBase;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.FlightPanel.CRUD
{
    internal class RemovingFlight
    {
        private AirCompanyContext context;
        private FlightPanelControl flightControl;
        public bool IsPrepering { get; set; }

        public RemovingFlight(AirCompanyContext context, FlightPanelControl flightControl)
        {
            this.context = context;
            this.flightControl = flightControl;
        }

        public void EnableControls(bool isEnable)
        {
            flightControl.UploadToCsvButton.Enabled = isEnable;
            flightControl.AddButton.Enabled = isEnable;

        }
        public async Task LoadToLocalCash()
        {
            if (context.Flights.Local.Count == 0)
                await context.Flights.LoadAsync();
        }

        private bool CheckExistFlight(out int flightId)
        {
            string flightIdStr = flightControl.FlightID.Text;

            if (!int.TryParse(flightIdStr,out int parsedFlightId))
            {
                MessageBox.Show("Вы ввели не вірний форма ID");
                flightId = parsedFlightId;
                return false;
            }
            flightId = parsedFlightId;

            int? route = context.Flights.Local
                .Where(w => w.NumberFlight == parsedFlightId)
                .Select(s => s.NumberFlight)
                .FirstOrDefault();

            if (route == 0) return false;

            return true;
        }
        private Flight PreperingToAdding()
        {
            if (!CheckExistFlight(out int flightId))
            {
                MessageBox.Show("Даного рейса не існує!");
                return null;
            }

            return GetFlight(flightId);
        }

        private Flight GetFlight(int flightId)
        {
            var route = context.Flights.Local
                 .Where(w => w.NumberFlight == flightId)
                 .FirstOrDefault();

            return route!;
        }
        public async Task<bool> RemoveFlight()
        {
            try
            {
                var flight = PreperingToAdding();
                if (flight == null) return false;


                context.Flights.Remove(flight);
                await context.SaveChangesAsync();
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неможливо видалити рейс " + ex.Message);
                return false;
            }
        }
    }
}
